import pandas as pd
import numpy as np
import os.path

#TODO:
#   - data loaded by panda module - convert to numpy array

class DataLoader:
    """
    Helper class for loading in datasets from CSV files.
    """
    def __init__(self):
        self.__filepath = ""
        self.__pathloaded = False
        self.__attpath = ""
        self.__attpathloaded = False
        self.__attributes = None
        self.__data = None
        self.__dataloaded = False
        self.__hasheader = False
        self.__datarray = None
    

    def set_attribute_file(self, filepath):
        """
        Sets the target file for the data attribute file.

        :param filepath: target file path
        :returns: bool indicating method success
        """
        self.__attpath = filepath
        self.__attpathloaded = True
        return True
    

    def load_attributes(self):
        """
        Loads a txt file containing the attribute names for a dataset.
        Format is expected as:
            - each attribute seperated by a \\n character
            - each line formated as "@attribute attribute-name type-of-data"

        :returns: bool indicating any read/write failures
        """
        if not self.__attpathloaded:
            return False
        
        try:
            f = open(self.__attpath, "r")
            self.__attributes = []
            for line in f:
                lsplit = line.split(" ")
                if len(lsplit) < 2:
                    continue

                if (lsplit[0] == "@attribute"):
                    self.__attributes.append(lsplit[1])
            f.close()
        except IOError:
            print("ERROR: problem loading the attribute file")
            return False
        return True


    def set_path(self, filepath, hasheader=False):
        """
        Sets the target file for loading data.

        :param filepath: target file path
        :returns: bool indicating method success
        """
        self.__filepath = filepath
        self.__pathloaded = True
        self.__hasheader = hasheader
        return True


    def get_data(self):
        if self.__dataloaded:
            return self.__datarray
        else:
            return []


    #TODO:
    #   - error catching when loading files
    #   - checking if an attribute file has been given before attempting to load it
    #   - if no attribute file, auto-generate one
    def load(self, forceloadatts=False):
        """
        Loads data from the specified file path. If the file has no header, one
        will be added using values from a specified attribute file.

        :param forceloadatts: if true, will load attributes even if head_ file already exists
        :returns: bool indicating successful file reading
        """
        if not self.__pathloaded:
            return False

        datapath = self.__filepath

        if not self.__hasheader:
            self.load_attributes()
            if not os.path.exists("head_" + self.__filepath) or forceloadatts:
                attstring = ", ".join(self.__attributes)

                nohead = open(self.__filepath, "r")
                raw_data = nohead.read()
                nohead.close()

                withhead = open("head_" + self.__filepath, "w+")
                withhead.seek(0)
                withhead.truncate()     #deletes current contents
                withhead.write(attstring + "\n" + raw_data)
                withhead.close()
            datapath = "head_" + self.__filepath

        try:
            if not self.__hasheader and not self.__pathloaded:
                self.__data = pd.read_csv(datapath, header=None)
            else:
                self.__data = pd.read_csv(datapath)
            self.__dataloaded = True
            self.create_simple_array()
        return True
        except:
            print("ERROR: something went wrong when loading the data!")
            return False


    def clear(self):
        """
        Clears data from the instance (does not clear any file path set).
        """
        self.__data = []
        self.__dataloaded = False
    

    def create_simple_array(self):
        """
        Takes the pandas dataframe and converts it to a regular Python 2d array
        """
        if not self.__dataloaded:
            return False
        
        self.__datarray = self.__data.values.tolist()
        return True




if __name__ == "__main__":
    TestLoader = DataLoader()

    #TestLoader.set_path("CommViolPredUnnormalizedData.csv")
    #TestLoader.set_attribute_file("CommViolPredUnnormalizedDesc.txt")

    TestLoader.set_path("../datasets/census-income.data")

    TestLoader.load()
    print(TestLoader.get_data())