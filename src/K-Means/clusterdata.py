from kmeans import kmeans
from readcsv import read_and_normalise_csv

def cluster_data(filepath, index_column, name_column, columns_to_load, num_clusters, max_iterations):
    names, input_data = read_and_normalise_csv(filepath, index_column, name_column, columns_to_load)
    cluster_map = kmeans(input_data, num_clusters, max_iterations)
    return (names, input_data, cluster_map)


if __name__ == "__main__":

    #Data from the world bank detailing various aspects related to quality of life in each country
    #NOTE: the cluster IDs do not indicate the 'rank' of that country. E.g. the clustering algorithm
    #  could give the USA a value of 1, and Bangladesh a value of 3. These are arbitrary cluster
    #  names ranging from 1 to the max number of clusters.

    columns_to_load = ["iso_a3", "name", "gdp_cap_est", "life_exp", "inequality", "HPI"]
    names, input_data, cluster_map = cluster_data("World.csv", 0, 1, columns_to_load, 7, 1000)

    for country in sorted(list(zip(names, cluster_map)), key = lambda x: x[1], reverse=True):
        print(country[0], end=", ")
        print(country[1])