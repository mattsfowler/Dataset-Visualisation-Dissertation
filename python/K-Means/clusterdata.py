import os
import json
import csv
from kmeans import kmeans
from readcsv import read_and_normalise_csv

def load_params(param_path):

    params = None
    with open(param_path, 'r') as pfile:
        params = json.loads(pfile.read())
    print(params[0])
    params[2] = int(params[2]) #index col
    params[3] = int(params[3]) #name col
    params[4] = json.loads(params[4]) #data columns
    params[5] = int(params[5]) #number of clusters
    params[6] = int(params[6]) #max iterations
    return params


def cluster_data(inputpath, outputpath, index_column, name_column, columns_to_load, num_clusters, max_iterations):

    names, input_data = read_and_normalise_csv(inputpath, index_column, name_column, columns_to_load)
    cluster_map = kmeans(input_data, num_clusters, max_iterations)

    f = None
    try:
        f = open(outputpath, 'w')
    except FileNotFoundError:
        try:
            f = open(outputpath, 'x')
        except:
            print("ERROR: could not load file")
            return (0, [], 0)

    #cluster_ary = sorted(list(zip(names, cluster_map)), key = lambda x: x[1], reverse=True)
    cluster_ary = [[] for c in range(num_clusters)]
    for i in range(len(names)):
        cluster_ary[cluster_map[i]].append(names[i])
        
    f.write(json.dumps(cluster_ary))
    f.close()
    return cluster_ary



if __name__ == "__main__":

    #NOTE: no command parsing set up, paramaters retrieved from params.json

    #Data from the world bank detailing various aspects related to quality of life in each country
    #NOTE: the cluster IDs do not indicate the 'rank' of that country. E.g. the clustering algorithm
    #  could give the USA a value of 1, and Bangladesh a value of 3. These are arbitrary cluster
    #  names ranging from 1 to the max number of clusters.

    args = []
    try:
        params_dir = os.getcwd() + "\\..\\..\\..\\..\\python\K-Means\params.json"
        args = load_params(params_dir)
    except FileNotFoundError:
        params_dir = "params.json"
        args = load_params(params_dir)
    cluster_data(args[0], args[1], args[2], args[3], args[4], args[5], args[6])
    
    
