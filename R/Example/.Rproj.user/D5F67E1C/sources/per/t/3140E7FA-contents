library(sf)
library(tmap)

#Get dataset
data("World")

#Convert to a matrix of only numeric columns
numeric_cols <- unlist(lapply(World, is.numeric))
numeric_cols[1] <- TRUE #(keep the id column)
World.matrix <- World[,numeric_cols]
World.matrix$geometry <- NULL #(don't need the geometry for now)

#METHOD 1: Omit null values entirely
World.matrix <- na.omit(World)

#METHOD 2: Replace null values with 0
World.matrix[is.na(World.matrix)] <- 0

#METHOD 3: Replace null values with the mean of the column
#(column loop starts at 2, after the ID column)
for(row in 1:nrow(World.matrix)) {
  for(col in 2:ncol(World.matrix)) {
    if (is.na(World.matrix[row, col])) {
      World.matrix[row, col] <- mean(World.matrix[,col], na.rm = TRUE)
    }
  }
}

