import sys
import json
import pandas as pd

from somnormalise import load_csv_for_som as load_csv
from mykohonen import add_coords_to_dframe


if __name__ == "__main__":
    
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


    input_data = load_csv(params["trainingData"],
                             params["indexCol"],
                             params["colsToLoad"])
    matrix_file = params["matrixFile"]
    map_width = params["mapWidth"]
    map_height = params["mapHeight"]
    coord_file = params["coordFile"]

    som_matrix = []
    with open(matrix_file, 'r') as m_file:
        for line in m_file:
            som_matrix.append(list(map(float, line.split(','))))

    with open("log.txt", 'a') as log_file:
        log_file.write(str(input_data.head(5)) + "\n")
        log_file.write(str(som_matrix) + "\n")

    input_data = add_coords_to_dframe(input_data, som_matrix, map_width, map_height)
    input_data.to_csv(coord_file)

