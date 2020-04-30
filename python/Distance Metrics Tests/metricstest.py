import sys
import time
import math
from random import randint


def gen_random_data(num_inputs, num_dims, min_val, max_val):
    return [[randint(min_val, max_val) for col in range(num_dims)] for row in range(num_inputs)]


def time_euclidean(data, num_inputs, num_dims, num_iterations, log_file):

    output = ""
    dist = 0

    for j in range(num_iterations):
        t0 = time.time()
        for i in range(num_inputs - 1):
            x = data[i]
            y = data[i+1]
            dist = math.sqrt(sum([pow(x[d] - y[d], 2) for d in range(num_dims)]))
        t1 = time.time()
        t = t1 - t0

        output += "EUCLIDEAN (%i inputs, %i dimensions): " % (num_inputs, num_dims)
        output += "total time = %fs (average = %fs)" % (t, t / (num_inputs - 1))
        output += '\n'
    
    log_file.write(output)



def time_manhattan(data, num_inputs, num_dims, num_iterations, log_file):

    output = ""
    dist = 0

    for j in range(num_iterations):
        t0 = time.time()
        for i in range(num_inputs - 1):
            x = data[i]
            y = data[i+1]
            dist = sum([abs(x[d] - y[d]) for d in range(num_dims)])
        t1 = time.time()
        t = t1 - t0

        output += "MANHATTAN (%i inputs, %i dimensions): " % (num_inputs, num_dims)
        output += "total time = %fs (average = %fs)" % (t, t / (num_inputs - 1))
        output += '\n'
    
    log_file.write(output)



if __name__ == "__main__":

    lf_path = "log.txt"
    num_inputs = 100000
    num_dims = 20
    num_iterations = 1
    
    data = gen_random_data(num_inputs, num_dims, 0, 100)
    print("Data: ", data[:3], "...")
    log_file = None

    try:
        log_file = open(lf_path, 'a')
    except FileNotFoundError:
        try:
            log_file = open(lf_path, 'x')
        except:
            print("ERROR: could not open file")
            sys.exit(1)

    print("------- starting tests --------")
    
    time_euclidean(data, num_inputs, num_dims, num_iterations, log_file)
    print(" * completed Euclidean")
    
    time_manhattan(data, num_inputs, num_dims, num_iterations, log_file)
    print(" * completed Manhattan")

    print("------- finished --------")
    log_file.close()
    sys.exit(0)
