import json


if __name__ == "__main__":
    params = {}
    params["trainingData"] = "D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\datasets\World.csv"
    params["colsToLoad"] = ["iso_a3",
                            "pop_est_dens",
                            "life_exp",
                            "well_being",
                            "inequality",
                            "HPI"]
    params["indexCol"] = 0
    params["matrixFile"] = "D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\outputs\WorldSOM.csv"
    params["mapWidth"] = 15
    params["mapHeight"] = 15
    params["iterLim"] = 500
    params["initLR"] = 0.25
    params["initRad"] = 7.5
    params["coordFile"] = "D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\outputs\WorldCoords.csv"
    serialised = json.dumps(params)

    with open("params.json", 'w') as p_file:
        p_file.write(serialised)
