import pandas as pd


def load_csv_for_som(filepath, index_column, columns_to_load):

    df = pd.read_csv(filepath, header=0, index_col=index_column, usecols=columns_to_load)

    #get reference to only the columns that contain data
    data_columns = columns_to_load.copy()
    del data_columns[index_column]

    #drop any entry with missing data
    for index, is_null in df.isna().iterrows():
        for key in data_columns:
            if is_null[key]:
                df = df.drop(index)
                break
    
    #squash values to be between 0 and 1
    c = 0
    for key in data_columns:
        min_val = df[key].min()
        max_val = df[key].max()

        for index, row in df.iterrows():
            df[key][index] = (row[key] - min_val) / max_val

    #debug perposes only
    with open("log.txt", 'a') as log_file:
        log_file.write(str(df.head(5)) + '\n')
    

    return df


if __name__ == "__main__":
    load_csv_for_som("D:\\Matt\\Documents\\GitRepos\\Dataset-Visualisation-Dissertation\\datasets\\World.csv",
                     0,
                     ["iso_a3", "pop_est_dens", "life_exp", "well_being", "inequality", "HPI"])
