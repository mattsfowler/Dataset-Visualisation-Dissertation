#packages
import sys
import math
import pandas as pd
import numpy as np
from random import randint

#my files
from somnormalise import load_csv_for_som as load_csv


def randfloat(sig_figs=3):
    divisor = 10**sig_figs
    return  randint(0, divisor) / divisor

def sub_vec(vector_a, vector_b, dimensions):
    output = []
    for d in range(dimensions):
        output.append(vector_a[d] - vector_b[d])
    return output

def compute_euclidean(vector_a, vector_b, dimensions):
    #euclidean (pythagorian)
    with open("log.txt", 'a') as log_file:
        log_file.write(str(vector_a) + ", " + str(vector_b) + "\n")
    return math.sqrt(sum([((vector_a[d] - vector_b[d]) **2) for d in range(dimensions)]))

def decay_radius(initial_radius, cur_iteration, time_constant):
    return initial_radius * math.exp(-cur_iteration / time_constant)

def decay_learning_rate(initial_learning_rate, cur_iteration, time_constant):
	return initial_learning_rate * math.exp(-cur_iteration / time_constant)

def neighbourhood_factor(x, y, bmu_x, bmu_y, radius):
    d = compute_euclidean([x, y], [bmu_x, bmu_y], 2)
    return math.exp(-(d**2) / (2 * (radius**2)))


def gen_som_matrix(training_data, output_width, output_height, iter_lim, init_lr, init_r):
    #check that the input list is not empty
    if len(training_data) <= 0:
        return []

    #set-up output space
    dim = len(training_data[0])
    output_size = output_width * output_height
    weights = [[randfloat() for w in range(dim)] for i in range(output_size)]

    #set-up time constant
    time_constant = iter_lim / math.log(init_r)

    #learn!
    for t in range(iter_lim):
        cur_input_index = randint(0, len(training_data) - 1)
        cur_input_value = training_data[cur_input_index]
        radius = decay_radius(init_lr, t, time_constant)
        l_rate = decay_learning_rate(init_r, t, time_constant)

        #calculate distance to each output neuron
        distances = [0 for i in range(output_size)]
        for weight_index in range(output_size):
            distances[weight_index] = compute_euclidean(cur_input_value, weights[weight_index], dim)
        
        #find best matching unit (BMU)
        index = distances.index(min(distances))
        bmu_x = math.floor(index / output_width)
        bmu_y = index % output_width
        
        #update weights
        for x in range(output_width):
            for y in range(output_height):
                index = x + (y * output_width)
                n_factor = neighbourhood_factor(x, y, bmu_x, bmu_y, radius)
                difference = sub_vec(cur_input_value, weights[index], dim)

                for d in range(dim):
                    weights[index][d] = weights[index][d] + (l_rate * n_factor * difference[d])
        return weights


def gen_coord(datum, dim, som_network, width, height):
    bmu_x = 0
    bmu_y = 0
    bmu_value = -1

    for x in range(width):
        for y in range(height):
            index = x + (y * width)
            dist = compute_euclidean(datum, som_network[index], dim)
            if bmu_value == -1 or dist < bmu_value:
                bmu_x = x
                bmu_y = y
                bmu_value = dist

    return (bmu_x, bmu_y)

def gen_coords(data, som_matrix, width, height):
    coord_list = []
    for datum in data:
        coord_list.append(gen_coord(datum, len(datum), som_matrix, width, height))
    return coord_list

def add_coords_to_dframe(df, som_matrix, width, height):
    col_name = "coords"
    df[col_name + "_x"] = np.nan
    df[col_name + "_y"] = np.nan
    
    for index, row in df.iterrows():
        datum = row.tolist()
        datum = datum[:len(datum) - 2]
        coord = gen_coord(datum, len(datum), som_matrix, width, height)
        df[col_name + "_x"][index] = str(coord[0])
        df[col_name + "_y"][index] = str(coord[1])
    
    return df


def print_points_ascii(coords, width, height, max_char_size=2):
    for x in range(width):
        print("|", end="")
        for y in range(height):
            num = coords.count((x, y))
            txt = str(num)
            txt = txt[:max_char_size] if len(txt) >= max_char_size else txt
            txt = txt + "".join([" " for i in range(max_char_size - len(txt))]) if len(txt) < max_char_size else txt
            print(txt + "|", end="")
        print()
    


if __name__ == "__main__":
    # My first attempt at making a functional Kohonen-net.

    #input parameters
    training_data = [[randfloat() for col in range(6)] for row in range(1500)]
    input_data = [[randfloat() for col in range(6)] for row in range(1500)] + training_data
    output_width = 15
    output_height = 15
    iteration_limit = len(training_data * 2)
    initial_learning_rate = 0.25
    initial_radius = max(output_width, output_height) / 2

    #generate the som network
    som_matrix = gen_som_matrix(training_data, output_width, output_height,
                                iteration_limit, initial_learning_rate, initial_radius)

    #generate coords
    coord_list = gen_coords(input_data, som_matrix, output_width, output_height)
    
    #print result
    print_points_ascii(coord_list, output_width, output_height)


