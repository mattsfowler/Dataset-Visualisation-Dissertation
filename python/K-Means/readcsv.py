import pandas as pd


def read_and_normalise_csv(filepath, index_column, name_column, columns_to_load):

    df = pd.read_csv(filepath, header=0, index_col=index_column, usecols=columns_to_load)

    #get reference to only the columns that contain data
    data_columns = columns_to_load.copy()
    if (index_column > name_column):
        del data_columns[index_column]
        del data_columns[name_column]
    elif (index_column < name_column):
        del data_columns[name_column]
        del data_columns[index_column]
    else:
        del data_columns[index_column]

    #drop any entry with missing data
    for index, is_null in df.isna().iterrows():
        for key in data_columns:
            if is_null[key]:
                df = df.drop(index)
                break

    #output value: list of corresponding row names + 2d list of normalised values
    row_names = list(df[columns_to_load[name_column]])
    normalised_values = [[0.0 for c in range(len(data_columns))] for r in range(df.size)]

    #squash values to be between 0 and 1
    c = 0
    for key in data_columns:
        min_val = df[key].min()
        max_val = df[key].max()

        r = 0
        for index, row in df.iterrows():
            normalised_values[r][c] = (row[key] - min_val) / max_val
            r += 1
        c += 1
    
    return (row_names, normalised_values)


if __name__ == "__main__":
    
    columns_to_load = ["iso_a3", "name", "gdp_cap_est", "life_exp", "inequality", "HPI"]
    print(read_and_normalise_csv("World.csv", 0, 1, columns_to_load))
