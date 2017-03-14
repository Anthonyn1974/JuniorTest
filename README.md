# Data processing test
Make sure you set the dataProcessor as the start up project

The aim of this test is to read in the data and split it into n number of files, based on the record type field in csv data
you can find the data in the datafiles folder within the dataprocessor project

to get you started I have created a simple framework that reads in a data file(s) and adds them to the DataView.cs

Tasks.
you have to parse the data passed into the DataRecordModel.cs class and create the corresponding properties based on the csv heading names
Then you have to group the data in the view based on record type
Sum up the value for each group
write out the data into a file based on the record type, make the file name the contents of record type with a .csv extension
write out the value as a total row in the newly created csv file.

Start in the program class within the Dataprocessor project

Also the framework has limitations, feel free to change it but state why it's been changed.
