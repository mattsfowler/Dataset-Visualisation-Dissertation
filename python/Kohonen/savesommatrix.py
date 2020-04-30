import sys
import json
import pandas as pd
import csv

from somnormalise import load_csv_for_som as load_csv
from mykohonen import gen_som_matrix


if __name__ == "__main__":

    #debug perposes only
    with open("log.txt", 'a') as log_file:
        log_file.write(str(sys.argv) + '\n')

    #only expects a single command line arg (first arg is the script file)
    if len(sys.argv) != 2:
        sys.exit(1)

    #attempt to open the given parameters file
    params_dir = sys.argv[1]
    p_file = None
    try:
        p_file = open(params_dir, 'r')
    except FileNotFoundError:
        sys.exit(1)
    except OSError:
        sys.exit(1)

    #attempt to load parameters
    params = []
    try:
        params = json.loads(p_file.read())
    except:
        sys.exit(1)
    p_file.close()

    #input parameters for the SOM algorithm
    training_data = load_csv(params["trainingData"],
                                        params["indexCol"],
                                        params["colsToLoad"])
    matrix_file = params["matrixFile"]
    map_width = params["mapWidth"]
    map_height = params["mapHeight"]
    iter_lim = params["iterLim"]
    init_lr = params["initLR"]
    init_rad = params["initRad"]

    #generate matrix
    som_matrix = gen_som_matrix(training_data.values, map_width, map_height,
                                iter_lim, init_lr, init_rad)
    
    #with open("log.txt", 'a') as log_file:
    #    log_file.write(str(som_matrix) + '\n')

    out_file = None
    try:
        out_file = open(matrix_file, 'w', newline="")
    except FileNotFoundError:
        try:
            out_file = open(matrix_file, 'x', newline="")
        except:
            sys.exit(1)
    writer = csv.writer(out_file)
    writer.writerows(som_matrix)
    out_file.close()
    
    sys.exit(0)
