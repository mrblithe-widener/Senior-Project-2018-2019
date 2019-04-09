import pandas as pd
import numpy as np


#Loading the data with pandas
math_scores = pd.read_csv("./DB_Export/math.csv")
read = pd.read_csv("./DB_Export/read.csv")
business = pd.read_csv("./DB_Export/BUSSINES.csv")
geo = pd.read_csv("./DB_Export/geo.csv", low_memory=False)
funding = pd.read_csv("./DB_Export/FUNDING.csv")
income = pd.read_csv("./DB_Export/income.csv")
teachers = pd.read_csv("./DB_Export/Teacher Ratios.csv")
title1 = pd.read_csv("./DB_Export/title1.csv")
#Set indexs
math_scores = math_scores.set_index("math_ncessch")
read = read.set_index("read_ncessch")
business = business.set_index("zip_code")
funding["ncesid"] = pd.to_numeric(funding["ncesid"], errors="coerce")
funding = funding.set_index("ncesid")
geo = geo.set_index("ncessch")
income = income.set_index("zipcode")
teachers["ncessch"] = teachers["ncessch"]
teachers = teachers.set_index("ncessch")
title1["ncessch"] = title1["ncessch"]
title1 = title1.set_index("ncessch")

combined = geo.join(read, how='outer').join(math_scores, how='outer')
combined = combined.join(business, on='zip', how='outer')
combined = combined.join(income.drop(['state'], axis=1), on='math_leaid', how='outer')
combined = combined.join(teachers, how='outer')
combined = combined.join(title1.drop(['survey_year', 'fipst', 'postal_state_abbreviation','state_edu_agency_name', 'leaid', 'st_leaid', 'schid', 'st_schid','sch_name'],axis=1), how = 'outer')

result = pd.DataFrame()
result['name'] = combined['name']
result['zip'] = combined['zip']
result['state'] = combined['state']
result['county_name'] = combined['county_name']
result['leaid'] = combined['math_leaid']
result['nceesch'] = combined.index

result.to_csv('index.csv', index=False)
