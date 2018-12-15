import sqlalchemy as sa 
import pandas as pd
import getpass
#The table names to retrieve
tables = ["BUSSINES",
        "FUNDING",
        "Teacher Ratios",
        "geo",
        "income",
        "math",
        "read",
        "title1"]

password = getpass.getpass("Enter password for POSTGRES:")

engine = sa.create_engine('postgresql://postgresuser:'+password+"@senior-project-mark1.cmx8janh3fmy.us-east-1.rds.amazonaws.com:5432/seniorproject")

for table_name in tables:
    #iterate over the tables and write them  as csvs
    print("Getting: ", table_name)
    table_df = pd.read_sql_table(table_name, engine)
    table_df.to_csv("Data/"+table_name+".csv")
