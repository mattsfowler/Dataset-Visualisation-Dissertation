import numpy as np
import matplotlib.pyplot as plt
from matplotlib.patches import RegularPolygon
import threading


# -------- SETUP ---------
NUM_INPUTS = 500
OUTPUT_SIZE = 8
n_iterations = 2000

raw_data = np.random.randint(0, 255, (3, NUM_INPUTS)) #3 rand vals between 0-255, repeat x times
network_dimensions = np.array([OUTPUT_SIZE, OUTPUT_SIZE])
init_learning_rate = 0.01
# establish size variables based on data
m = raw_data.shape[0]
n = raw_data.shape[1]

# weight matrix (i.e. the SOM) needs to be one m-dimensional vector for each neuron in the SOM
net = np.random.random((network_dimensions[0], network_dimensions[1], m))

# initial neighbourhood radius
init_radius = max(network_dimensions[0], network_dimensions[1]) / 2
# radius decay parameter
time_constant = n_iterations / np.log(init_radius)


# --------- NORMALISATION --------

normalise_data = True

# if True, assume all data is on common scale
# if False, normalise to [0 1] range along each column
normalise_by_column = False

# we want to keep a copy of the raw data for later
data = raw_data

# check if data needs to be normalised
if normalise_data:
    if normalise_by_column:
        # normalise along each column
        col_maxes = raw_data.max(axis=0)
        data = raw_data / col_maxes[np.newaxis, :]
    else:
        # normalise entire dataset
        data = raw_data / data.max()


# ------- VISUALISATION --------
class SquareVis:
    def __init__(self):
        self.SQUARE_SIZE = 0
        self.RADIUS = 0
        self.ORIENTATION = 0
        self.fig = None
        self.ax = None

        
    def create_graph(self):
        self.SQUARE_SIZE = 1
        self.RADIUS = np.sqrt((self.SQUARE_SIZE ** 2) * 2) / 2
        self.ORIENTATION = 0.785398
        self.fig, self.ax = plt.subplots()
        self.ax.set_xlim([0, OUTPUT_SIZE])
        self.ax.set_ylim([0, OUTPUT_SIZE])
        plt.show(block=False) #deprecated apparently


    def update_graph(self, net_input):
        for row in range(len(net_input)):
            x = row * self.SQUARE_SIZE
            for col in range(len(net_input[row])):
                y = col * self.SQUARE_SIZE
                colour = tuple(net_input[row][col])
                sq = RegularPolygon((x+0.5, y+0.5), 4, radius=self.RADIUS, 
                                    orientation=self.ORIENTATION, facecolor=colour, edgecolor='k')
                self.ax.add_patch(sq)
        plt.draw()


# ------- LEARNING --------

def find_bmu(t, net, m):
    """
        Find the best matching unit for a give vector, t, in the SOM.
        Returns: a (bmu, bmu_idx) tuple where bmu is the high-dimensional BMU
            and bmu_idx is the index of this vector in the SOM.
    """
    bmu_idx = np.array([0, 0])
    # set the initial minimum distance to a huge number
    min_dist = np.iinfo(np.int).max
    # calculate the high-dimensional distance between each neuron and the input
    for x in range(net.shape[0]):
        for y in range(net.shape[1]):
            w = net[x, y, :].reshape(m, 1)
            # don't bother with actual Euclidean distance, to avoid expensive sqrt operation
            sq_dist = np.sum((w - t) ** 2)
            if sq_dist < min_dist:
                min_dist = sq_dist
                bmu_idx = np.array([x, y])
    # get vector corresponding to bmu_idx
    bmu = net[bmu_idx[0], bmu_idx[1], :].reshape(m, 1)
    # return the (bmu, bmu_idx) tuple
    return (bmu, bmu_idx)


def decay_radius(initial_radius, i, time_constant):
    return initial_radius * np.exp(-i / time_constant)

def decay_learning_rate(initial_learning_rate, i, n_iterations):
    return initial_learning_rate * np.exp(-i / n_iterations)

def calculate_influence(distance, radius):
    return np.exp(-distance / (2 * (radius**2)))


print("Starting learning...")
marks = []
num_marks = 5
interval = n_iterations / num_marks
for i in range(num_marks):
    marks.append(interval * (i + 1))

V = SquareVis()
V.create_graph()

# Learning Loop:
for i in range(n_iterations):
    #progress report
    if i in marks:
        print("Progress: " + str(int((i / n_iterations) * 100)) + "%", end="")
        print(" (n = " + str(i) + ")")

    # select a training example at random
    t = data[:, np.random.randint(0, n)].reshape(np.array([m, 1]))
    # find its Best Matching Unit (BMU)
    bmu, bmu_idx = find_bmu(t, net, m)
    r = decay_radius(init_radius, i, time_constant)
    l = decay_learning_rate(init_learning_rate, i, n_iterations)

    # now we know the BMU, update its weight vector to move closer to input
    # and move its neighbours in 2-D space closer
    # by a factor proportional to their 2-D distance from the BMU
    for x in range(net.shape[0]):
        for y in range(net.shape[1]):
            w = net[x, y, :].reshape(m, 1)
            # get the 2-D distance (again, not the actual Euclidean distance)
            w_dist = np.sum((np.array([x, y]) - bmu_idx) ** 2)
            # if the distance is within the current neighbourhood radius
            if w_dist <= r**2:
                # calculate the degree of influence (based on the 2-D distance)
                influence = calculate_influence(w_dist, r)
                # now update the neuron's weight using the formula:
                # new w = old w + (learning rate * influence * delta)
                # where delta = input vector (t) - old w
                new_w = w + (l * influence * (t - w))
                # commit the new weight
                net[x, y, :] = new_w.reshape(1, 3)
    V.update_graph(net)


# -------- VISUALISATION ---------
# Matplotlib and RegularPolygon to make a grid of 
#    squares, where each square's colour is the value
#    in the net.

##def visualise_sqr(net_input):
##    SQUARE_SIZE = 1
##    RADIUS = np.sqrt((SQUARE_SIZE ** 2) * 2) / 2
##    ORIENTATION = 0.785398
##    fig, ax = plt.subplots()
##    ax.set_xlim([0, OUTPUT_SIZE])
##    ax.set_ylim([0, OUTPUT_SIZE])
##    plt.show(block=False) #deprecated apparently
##
##    for row in range(len(net_input)):
##        x = row * SQUARE_SIZE
##        for col in range(len(net_input[row])):
##            y = col * SQUARE_SIZE
##            colour = tuple(net_input[row][col])
##            sq = RegularPolygon((x+0.5, y+0.5), 4, radius=RADIUS, 
##                                orientation=ORIENTATION, facecolor=colour, edgecolor='k')
##            ax.add_patch(sq)
##    plt.draw()
##    print("poop")


#print("DEBUG: beginning visualisation...")
#visualise_sqr(net)



