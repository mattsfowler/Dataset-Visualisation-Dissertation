from random import randint
import math

DEC_POINT = 3


#function for calculating distance between points in the same space
def euclidean_dist(point_a, point_b):
    if len(point_a) != len(point_b):
        raise ValueError("point_a and point_b must be lists of the same size")
    return math.sqrt(sum(list(map(lambda x, y: (x - y)**2, point_a, point_b))))



def kmeans(input_data, num_clusters, max_iterations):
    
    num_dims = len(input_data[0])
    num_vals = len(input_data)

    min_val = input_data[0][0]
    max_val = input_data[0][0]
    for row in input_data:
        for col in row:
            if col < min_val:
                min_val = col
            if col > max_val:
                max_val = col

    #function output: maps each input row to a discrete class
    input_to_cluster_map = [-1 for i in range(num_vals)]

    #randomly make 'num_clusters' number of centroids within the range calculated
    centroids = [[(randint(int(min_val * (10**DEC_POINT)), int(max_val * (10**DEC_POINT))) / (10**DEC_POINT))
                  for d in range(num_dims)]
                 for i in range(num_clusters)]        

    #LEARN
    centroids_changed = True
    num_iterations = 0
    while centroids_changed and num_iterations < max_iterations:

        #number of input values that fall within the influence of the centroid with index i
        num_vals_in_influence_of = [0 for n in range(num_clusters)]

        #sum of all the distances within this cluster
        cluster_sum = [[0 for d in range(num_dims)] for n in range(num_clusters)]

        #for each input row, find closest centroid
        for row_index in range(num_vals):
            
            closest_cluster = -1
            distance = -1
            for c_index in range(num_clusters):
                c_distance = euclidean_dist(input_data[row_index], centroids[c_index])
                if c_distance < distance or distance == -1:
                    closest_cluster = c_index
                    distance = c_distance
            
            num_vals_in_influence_of[closest_cluster] += 1
            for d in range(num_dims):
                cluster_sum[closest_cluster][d] += input_data[row_index][d]
            input_to_cluster_map[row_index] = closest_cluster

        centroids_changed = False
        for c_index in range(num_clusters):
            for d in range(num_dims):
                new_val = cluster_sum[c_index][d] / max(1, num_vals_in_influence_of[c_index]) #max: potential divide by 0 if no values in cluster
                if centroids[c_index][d] != new_val:
                    centroids[c_index][d] = new_val
                    centroids_changed = True

        max_iterations += 1
    return input_to_cluster_map
        


if __name__ == "__main__":
    
    num_clusters = 4
    max_iterations = 100
    input_data = [[(randint(0, 100) / 100) for col in range(7)] for row in range(40)]

    cluster_map = kmeans(input_data, num_clusters, max_iterations)
    for index in range(len(input_data)):
        print("%a -> %i" % (input_data[index], cluster_map[index]))


        
        
