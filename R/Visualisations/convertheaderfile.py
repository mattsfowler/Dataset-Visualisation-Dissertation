import sys

if __name__ == "__main__":

    file_path = "CommunityData.txt"
    output_path = "CommunityHeader.txt"

    header_file = None
    try:
        header_file = open(file_path, "r")
    except:
        print("ERROR: could not open file to read")
        sys.exit(1)


    output_file = None
    try:
        output_file = open(output_path, "x")
    except:
        print("ERROR: output file could not be created or already exists")
        sys.exit(1)

    output = ""
    for line in header_file:
        stripped_line = line.strip()
        #each line contains 3 elements separated by a space.
        #we only care about the second one (index 1)
        split_line = stripped_line.split(" ")
        output += split_line[1] + " "
    output_file.write(output)

    header_file.close()
    output_file.close()
    sys.exit(0)
            
