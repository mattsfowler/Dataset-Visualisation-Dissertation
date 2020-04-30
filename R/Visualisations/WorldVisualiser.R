library(sf)
library(tmap)
library(som)
library(hexbin)
library(somplot)
library(kohonen)

#Get dataset
data("World")

#Convert to a matrix of only numeric columns
numeric_cols <- unlist(lapply(World, is.numeric))
#numeric_cols[1] <- TRUE #(keep the id column)
World.matrix <- World[,numeric_cols]
World.matrix$geometry <- NULL #(don't need the geometry for now)

#Normalise
World.matrix <- World.matrix[,5:8] #only use "life expectancy", wellbeing", "footprint" and "inequality"
World.matrix <- na.omit(World.matrix) #remove any row with a null value


# USING SOM LIBRARY
if (FALSE) {
  #Normalise further so that each row gets a mean of 0 and variance of 1
  World.matrix <- normalize(World.matrix) 
  
  xdim <- as.numeric(ncol(World.matrix))
  ydim <- as.numeric(nrow(World.matrix))
  #som_matrix <- som.init(World.matrix, xdim, ydim, init="linear")
  
  #obj <- som.train(World.matrix, som_matrix, xdim, ydim, alpha=NULL, alphaType="inverse",
  #          neigh="gaussian", topol="rect", radius=NULL, rlen=NULL, err.radius=1, inv.alp.c=NULL)
  
  obj <- som(World.matrix, xdim, ydim, init="linear", alpha=NULL, alphaType="inverse",
             neigh="gaussian", topol="rect", radius=NULL, rlen=NULL, err.radius=1,
             inv.alp.c=NULL)
  
  som_map <- som.project(obj, World.matrix)
}


# USING MY LIBRARY
if (TRUE) {
  worldxy <- read.csv("WorldCoords.csv")
  plot(worldxy$coords_x, worldxy$coords_y, main = "Ecenomic Development",
       xlab = "X", ylab = "y")
}

