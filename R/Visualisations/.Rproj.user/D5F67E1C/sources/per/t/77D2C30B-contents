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


# USING KOHONEN LIBRARY
if (TRUE) {
  
  data(wines)
  set.seed(7)
  
  kohmap <- xyf(scale(wines), vintages,
                grid = somgrid(5, 5, "hexagonal"), rlen=100)
  plot(kohmap, type="changes")
  counts <- plot(kohmap, type="counts", shape = "straight")
  
  ## show both sets of codebook vectors in the map
  par(mfrow = c(1,2))
  plot(kohmap, type="codes", main = c("Codes X", "Codes Y"))
  
  par(mfrow = c(1,1))
  similarities <- plot(kohmap, type="quality", palette.name = terrain.colors)
  plot(kohmap, type="mapping",
       labels = as.integer(vintages), col = as.integer(vintages),
       main = "mapping plot")
  
  ## add background colors to units according to their predicted class labels
  xyfpredictions <- classmat2classvec(getCodes(kohmap, 2))
  bgcols <- c("gray", "pink", "lightgreen")
  plot(kohmap, type="mapping", col = as.integer(vintages),
       pchs = as.integer(vintages), bgcol = bgcols[as.integer(xyfpredictions)],
       main = "another mapping plot", shape = "straight", border = NA)
  
  ## Show 'component planes'
  set.seed(7)
  sommap <- som(scale(wines), grid = somgrid(6, 4, "hexagonal"))
  plot(sommap, type = "property", property = getCodes(sommap, 1)[,1],
       main = colnames(getCodes(sommap, 1))[1])
  
  ## Show the U matrix
  Umat <- plot(sommap, type="dist.neighbours", main = "SOM neighbour distances")
  ## use hierarchical clustering to cluster the codebook vectors
  som.hc <- cutree(hclust(object.distances(sommap, "codes")), 5)
  add.cluster.boundaries(sommap, som.hc)
  
  ## and the same for rectangular maps
  set.seed(7)
  sommap <- som(scale(wines),grid = somgrid(6, 4, "rectangular"))
  plot(sommap, type="dist.neighbours", main = "SOM neighbour distances")
  ## use hierarchical clustering to cluster the codebook vectors
  som.hc <- cutree(hclust(object.distances(sommap, "codes")), 5)
  add.cluster.boundaries(sommap, som.hc)
}
