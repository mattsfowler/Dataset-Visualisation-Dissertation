import sys
from random import randint
from math import sqrt
from math import log
from math import exp


def randfloat(sig_figs=3):
    divisor = 10**sig_figs
    return  randint(0, divisor) / divisor


def compute_euclidean_squared(vector_a, vector_b, dimensions):
    #euclidean (pythagorian)
    return sum([(vector_a[d] - vector_b[d]) **2] for d in range(dimensions))


def decay_radius(initial_radius, cur_iteration, time_constant):
    return initial_radius * exp(-cur_iteration / time_constant)


def decay_learning_rate(initial_learning_rate, cur_iteration, time_constant):
	return initial_learning_rate * np.exp(-cur_iteration / time_constant)


def neighbourhood_function(bmu_vector, cur_vector, dimensions, cur_iteration, initial_radius, initial_learning_rate, time_constant):
    sqr_dist = compute_euclidean_squared(bmu_vector, cur_vector, dimensions)
    lr = decay_learning_rate(initial_learning_rate, cur_iteration, time_constant)
    r_sqr = decay_radius(initial_radius, cur_iteration, time_constant) ** 2
    return lr * exp(-sqr_dist / (2 * r_sqr))



if __name__ == "__main__":
    # My first attempt at making a functional Kohonen-net.

    #input parameters
    input_data = [[0, 0, 0], [255, 0, 0], [0, 255, 0], [0, 0, 255], [255, 255, 0], [0, 255, 255], [255, 0, 255], [255, 255, 255]]
    output_width = 6
    output_height = 6
    iteration_limit = 1000
    initial_learning_rate = 0.25
    initial_radius = max(output_width, output_height) / 2

    #check that the input list is not empty
    if len(input_data) <= 0:
        sys.exit(1)
    
    #set-up output space
    dim = len(input_data[0])
    output_size = output_width * output_height
    weights = [[randfloat for w in range(dim)] for i in range(output_size)]

    #set-up time constant
    time_constant = iteration_limit / log(initial_radius)

    #learn!
    for t in range(iteration_limit):
        cur_input_index = randint(0, len(input_data) - 1)
        cur_input_value = input_data[cur_input_index]

        #calculate distance to each output neuron
        distances = [0 for i in range(output_size)]
        for weight_index in range(output_size):
            distances[weight_index] = sqrt(compute_euclidean_squared(cur_input_value, weights[weight_index], dim))
        
        #find best matching unit (BMU)
        bmu_index = 0
        bmu_value = distances[bmu_index]
        for d in range(output_size):
            if distances[d] < bmu_value:
                bmu_index = d
                bmu_value = distances[d]
        
        #update weights
        for w in range(output_size):





