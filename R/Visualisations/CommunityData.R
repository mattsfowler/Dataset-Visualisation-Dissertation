library(ggplot2)
#library(BBmisc)
library(dplyr)


#Load header file
header_data <- scan('CommunityHeader.txt', what ="")

#Load raw csv file (does not contain a header row, and is not normalised)
community = read.csv(file = "head_CommViolPredUnnormalizedData.csv", header=TRUE)

#Normalise all values
numeric_cols <- unlist(lapply(community, is.numeric))
community.std <- scale(community[,numeric_cols])


#Show a histogram of the column "percentage unemployment"
#Only using a single column, so can use un-normalised table
hist_unemploy <- ggplot(community, aes(x=pctUnemploy)) + 
  geom_histogram(binwidth = 0.5) +
  labs(title="Percentage Unemployment by Community", y = "Number of Communities") +
  scale_x_continuous(name="Unemployment (%)", breaks = seq(0 , 100, 2.5)) +
  theme_minimal()
print(hist_unemploy)


#Show a scatter plot of % unemployment against % povert
#Expected to be highly correlated. Both values are percentages between 0 and 100, so no
#  further normalisation is needed.
sctr_unemploy_poverty <- ggplot(community, aes(x=pctPoverty, y=pctUnemploy)) +
  geom_point()
print(sctr_unemploy_poverty)


