import * as React from 'react';
/**
 * a Function which provides a default handler for a column record
 * This function will retireve the column from the given dataset
 */
function defaultHandler(dataset, Column_Name){
    return dataset[Column_Name];
}

/**
 * This function will prepare the given text for display
 * It will replace any non number which is falsy or whitespace with 'Not Available'
 */
export function emptyFilter(text, colName = null){
	if(colName && colName.toLowerCase().includes("zip") && text)
		return text;
    if(! (typeof text ==='number') && (! text || text.match(/^\s+$/)))
        return "Not Available";
    if(typeof text === 'number')
        return text.toLocaleString();
    return text;
}

/**
 * This class contains the data needed to show the user the data from the particular dataset
 * The column_name is the actual column name in the json from the api
 * the column_friendly_name is the column name that the user will see next ot the data
 * The column_Description is the tool tip that will appear when the friendly name is hovered over
 * The handler processes the raw input into a viewable form and defaults to the defaultHandler
 */
class ColumnRecord{
    constructor(Column_Name, Column_Friendly_Name, Column_Description, handler=defaultHandler){
        this.Column_Name = Column_Name;
        this.Column_Friendly_Name = Column_Friendly_Name;
        this.Column_Description = Column_Description;
        this.handler = handler;
    }
}

/**
 * This function renders the content of a column record for viewing
 * it converts this information for that particular record into the form the user will see
 * @param {*} record  the record to parse (the meta data to tell the row what to show)
 * @param {*} dataset  the dataset to pull the data from
 */

export function RenderRowContent(record, dataset) {
    return (<tr key={record.Column_Name} data-toggle="tooltip" data-placement="bottom" title={record.Column_Description}>
                <td key={record.Column_Name + "label"} >
                    {record.Column_Friendly_Name}
                </td>
                <td key={record.Column_Name + "value"} >
					{emptyFilter(record.handler(dataset, record.Column_Name), record.Column_Name)}
                </td>
            </tr>);
}

export const MathCols = [
    new ColumnRecord("math_all_grades_numvalid","Math: Number of Testing Students", "Total number of students that completed an assessment and for whom a proficiency level was assigned", (dataset, _)=>dataset['mathAllGradesNumvalid'] <0?"Not Available":dataset['mathAllGradesNumvalid']),
    new ColumnRecord("math_pct_prof", "Math: Percentage Proficient", "Percentage of students in the school that scored at or above proficient", (dataset,_)=>dataset['mathAllGradesPctprofLow']>0?((dataset['mathAllGradesPctprofLow']+dataset['mathAllGradesPctprofHigh'])/2)+'%':""),
	new ColumnRecord("math_full_time", "Math: Student to Teacher Ratio", "The number of students, who were tested, divided by the total full-time-equivalent classroom teachers", (num_students, num_teach)=>num_students> 0 && num_teach > 0? (num_students/num_teach).toFixed(2):"Not Available")
]

export const ReadCols = [
    new ColumnRecord("read_all_grades_numvalid","Reading: Number of Testing Students", "Total number of students that completed an assessment and for whom a proficiency level was assigned", (dataset, _)=>dataset['readAllGradesNumvalid'] <0?"Not Available":dataset['readAllGradesNumvalid']),
    new ColumnRecord("read_pct_prof", "Reading: Percentage Proficient", "Percentage of students in the school that scored at or above proficient", (dataset,_)=>dataset['readAllGradesPctprofLow']>0?((dataset['readAllGradesPctprofLow']+dataset['readAllGradesPctprofHigh'])/2)+'%':""),
	new ColumnRecord("read_full_time", "Reading: Student to Teacher Ratio", "The number of students, who were tested, divided by the total full-time-equivalent classroom teachers", (num_students, num_teach)=>num_students> 0 && num_teach > 0? (num_students/num_teach).toFixed(2):"Not Available")
]

/**
 *  this function converts the locale to a readable form based off the documentation
 * @param {The dataset to pull the from} dataset 
 * @param {This is meaningless in this context and is ignored} Column_Name 
 */

function handleLocale(dataset,Column_Name){
	switch(dataset['locale']){
		case 11:
			return "City, Large: Territory inside an urbanized area and inside a principal city with population of 250,000 or more.";
		case 12:
			return "City, Midsize: Territory inside an urbanized area and inside a principal city with population less than 250,000 and greater than or equal to 100,000.";
		case 13:
			return "City, Small: Territory inside an urbanized area and inside a principal city with population less than 100,000.";
		case 21:
			return "Suburban, Large: Territory outside a principal city and inside an urbanized area with population of 250,000 or more.";
		case 22:
			return "Suburban, Midsize: Territory outside a principal city and inside an urbanized area with population less than 250,000 and greater than or equal to 100,000."
		case 23:
			return" Suburban, Small: Territory outside a principal city and inside an urbanized area with population less than 100,000."
		case 31:
			return "Town, Fringe: Territory inside an urban cluster that is less than or equal to 10 miles from an urbanized area."
		case 32:
			return "Town, Distant: Territory inside an urban cluster that is more than 10 miles and less than or equal to 35 miles from an urbanized area.";
		case 33:
			return "Town, Remote: Territory inside an urban cluster that is more than 35 miles from an urbanized area.";
		case 41:
			return "Rural, Fringe: Census-defined rural territory that is less than or equal to 5 miles from an urbanized area, as well as rural territory that is less than or equal to 2.5 miles from an urban cluster.";
		case 42:
			return "Rural, Distant: Census-defined rural territory that is more than 5 miles but less than or equal to 25 miles from an urbanized area, as well as rural territory that is more than 2.5 miles but less than or equal to 10 miles from an urban cluster.";
		case 43:
			return "Rural, Distant: Census-defined rural territory that is more than 5 miles but less than or equal to 25 miles from an urbanized area, as well as rural territory that is more than 2.5 miles but less than or equal to 10 miles from an urban cluster."
		default:
			return "Not Available";
	}
}

export const GeoCols = [
	new ColumnRecord("city", "City", "City the school is located in"),
	new ColumnRecord("lat", "Latitude", "Latitude of the school"),
	new ColumnRecord("lon", "Longitude", "Longitude of the school"),
	new ColumnRecord("countyName", "County Name", "Name of the county the school is located in"),
	new ColumnRecord("state", "State", "State the school is in"),
	new ColumnRecord("street", "Street", "The street address of the school"),
	new ColumnRecord("zip", "Zipcode", "Zip code the school is in"),
	new ColumnRecord("locale", "Area Description", "Type of Area the school is located in", handleLocale),
];
function title1Handler(dataset, column){
	if(dataset[column] !== -9)
		return dataset[column]
	return "";//Will be replaced with not available
}
export const Title1Cols = [
	new ColumnRecord("schoolWideTitleIEligibility", "School Wide Title 1 Eligibility", "Does the school qualify for Title 1", title1Handler),
	new ColumnRecord("ntnlSchoolLunchProgramStatus", "School Lunch Program Status","Does the school qualify for school lunch program", title1Handler),
	new ColumnRecord("titleIStatusDescription", "Title 1 Status", "Does School qualify for Title 1 funding?",title1Handler),
	new ColumnRecord("titleIEligibility","Title 1 Eligibility", "Is the school eligible for Title 1",title1Handler),
];

/**
 * Handles special cases for business data.
 * Info based off docs for dataset 
 * @param {the business dataset} dataset 
 * @param {The column for processing} column 
 */
function businessHandler(dataset, column){
	switch(dataset[column]){
		case 'D':
			return null;
		case "b":
			return "20 to 99 employees";
		case "a":
			return "0 to 19 employees";
		case "h":
			return "2,500 to 4,999 employees";
		case "c":
			return "100 to 249 employees";
		case "i":
			return "5,000 to 9,999 employees";
		case "f":
			return "500 to 999 employees";
		case "e":
			return "250 to 499 employees";
		case "g":
			return "1,000 to 2,499 employees";
		case "j":
			return "10,000 to 24,999 employees";
		case "k":
			return "25,000 to 49,999 employees";
		case "l":
			return "50,000 to 99,999 employees";
		default:
			if(dataset[column] && !isNaN(dataset[column]))//isNan checks if the string is numeric
				return (+dataset[column]).toLocaleString()// The plus here is converting the value to a number
			else
				return dataset[column]
	}
}

export const BusinessCols = [
	new ColumnRecord("numEstablishments","Number Of Establishments", "Total number of businesses in same zip code as the school" ),
	new ColumnRecord("numPaidEmployees", "Number of Paid Employees in Surrounding Zip Code", "Total number of paid employees",businessHandler),
	new ColumnRecord("firstQuarterPayroll", "First Quarter Payroll","First quarter payroll of the businesses in the surrounding zip code",(dataset,column)=> `$ ${emptyFilter(businessHandler(dataset, column))}`),
	new ColumnRecord("annualPayroll", "Annual Payroll", "Annual payroll of the businesses in the surrounding zip code", (dataset,column)=> `$ ${emptyFilter(businessHandler(dataset, column))}`)
];

export const TeacherRatioCols = [
    new ColumnRecord("numFullTime", "Number of Teachers", "the total full-time-equivalent classroom teachers")
]

export const IncomeCols = [
	new ColumnRecord("beforeCreditsAmount", "Before Credits Amount", "Income tax bofore credits amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("excessIncomeCreditAmount","Excess Income Credit Amount", "Excess advance premium tax credit repayment amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numOfHeadHouseReturns", "Number of Head House Returns", "Total number of head house returns filed"),
	new ColumnRecord("unemployeementAmount","Unemployement Amount", "Total amount for unemployed tax returns",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numReturnsUnemployeement", "Total Returns from Unemployed People","Total tax returns recieved from unemployed people"),
	new ColumnRecord("businessProfessionalAmount","Business Professional Amount", "Business or professional net income (less loss) amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("stateLocalGeneralAmount", "State and Local General Sales Tax Amount","Total state and local general sales tax amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("stateLocalAmount", "State and Local Refund Amount", "State and local income tax refunds amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("netPremiumCreditsAmount", "Net Premium Credits", "Total net credit amounts",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numJointReturns", "Number of Joint Returns", "Total number of joint returns filed"),
	new ColumnRecord("personalPropertyAmounts", "Personal Property Amounts", "Total number of property amounts",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numberReturnsPersonalProperty", "Number of Property Taxes", "Number of property taxes files"),
	new ColumnRecord("numReturnsExcessIncomeCredit", "Number of returns with excess earned income credit", "Total number of returns with excess earned income credit"),
	new ColumnRecord("numReturnStateLocalGeneral", "Number of returns with state and local income tax refunds", "Total number of returns with state and local income tax refunds"),
	new ColumnRecord("numStateLocal", "Number of returns with State and local general sales tax", "Total number of returns with State and local general sales tax"),
	new ColumnRecord("numberReturnsNetPremiumCredits", "Number of returns with net premium tax credit", "Total number of returns with net premium tax credit"),
	new ColumnRecord("numDep", "Number of dependents", "Number of dependents"),
	new ColumnRecord("taxableAmount", "Taxable Income", "Taxable Income",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("educationExpenseAmount", "Educator expenses amount", "Total Educator expenses amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numBusinessProfessional","Number of Business Professionals", "Number of returns with business or professional net income (less loss)" ),
	new ColumnRecord("numSingleReturns", "Number of Single Returns", "Total number of single taxes filed"),
	new ColumnRecord("refundableEduAmount", "Refundable education credit amount", "Total Refundable education credit amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("nonRefundEduAmount", "Nonrefundable education credit amount", "Total nonrefundable education credit amount",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numberOfRefundableEdu", "Number of returns with refundable education credit", "Total number of returns with refundable education credit",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numReturnsNonRefundEdu", "Number of returns with nonrefundable education credit", "Total number of returns with nonrefundable education credit",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("sallariesWagesAmount", "Salaries and wages amount", "Total amount of salaray and wage taxes",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("toalIncomeAmount", "Total Income", "Total Income",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("agi", "Adjusted gross income", "Adjusted gross income",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("numExemptions", "Number of Exemptions", "Total number of exemptions"),
	new ColumnRecord("numReturnsSalaryWages", "Number of Salary and Wages Returns", "Total number of salary and wages returns"),
	new ColumnRecord("numberReturnsTaxable", "Total number of Taxable Returns", "Total number of returns that are taxable"),
	new ColumnRecord("numReturnsBeforeCredits", "Number of Returns before Credits", "Total number of returns filed before credits"),
	new ColumnRecord("numReturnTotalIncome", "Number of Income Returns", "Total number of income taxes files"),
	new ColumnRecord("numReturns", "Total number of returns", "Total number of tax returns recieved")
];

export const FundingCols = [
	new ColumnRecord("pctTitle1", "Percentage of Funding from Title 1", "Percentage of total funding that comes from Title 1",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("pctCharges", "Percent of revenue from charges", "Percentage of revenue from charges (such as school lunch)",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("strTrans", "Income from State Transportation Programs", "Total income from transportation programs from state",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("pctTotFed", "Percentage of Funding from Federal Sources", "Percent of total funding that comes from state sources",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("pctParentGovCont", "Parent government contributions", "Percentage of total funding from  Parent government contributions",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("pctRevLocale", "Percentage of Revenue From Local", "Percentage of total revenue generated from local sources",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("pctsGenForm", "Percentage of funding from General Assistance", "Percentage of total funding that comes from general assistance formula",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("locrCharges", "Revenue from local charges", "Revenue from charges to local government for goods and services (such as school lunch)",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilTotSuppServ", "Per Pupil Support Services", "Total Current Spending for Support Services Per Pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilSupportStaff", "Per Pupil Support Staff", "Amount Spent Per Pupil on Support Staff",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilSchoolAdmin", "Per Pupil School Administration", "Amount Spent Per Pupil on School Adminisration",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilGenAdmin", "Per Pupil General Administration","Amount Spent Per Pupil on General Adminisration",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("strSpecEd", "Federal Income for Special Education", "Amount Recieved for Special Education from federal government",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilInstBene", "Per pupil institutional benefits", "Amount per pupil the institution spends on benefits",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tlocrev", "Total Local Revenue", "Revenue generated from Local sources",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilInstSupportStaff", "Per pupil spend on support staff", "Amount of money spent on support staff by the institution per pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilInstSalWag", "Amount per pupil spent on wages", "Amount per pupil spent on salary and wages",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tPayGovt", "Total Payments to other governments", "Total amount payed to other governments",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrTax", "Income from local taxes", "Total income form local taxes",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrCitiesCounties", "Revenue from cities and counties", "Total revenue from cities and counties",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrOthr", "Other local revenues", "Total revenue from other local sources",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("fedTitle1", "Title 1 Recieved", "Federal Revenue from Title 1",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilEmployeeBen", "Employee Benefits Per Pupil", "How much benefits employees recieve per pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("pctOtherLocalGov", "Percentage of Local Funding (Other)", "Percentage of funding recieved from other local sources",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("longDebtRetired", "Long-term debt retired during the fiscal year", "Total Amount of long-term debt retired during the fiscal year",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilInstTot", "Total Spending for Instruction", "How much the school spends for instruction",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrOtherSchools", "Revenue from other local school systems", "Total revenue from other local school systems",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("strOthr", "Income from other state sources", "Total amount of revenue from other state sources",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCursGenAdmin", "Total Spening on General Admission", "Total schools spend on General Admission",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilSalaryWages", "Teacher Wages Per Pupil", "Total wages for teachers per pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("pctTotState", "Percentage of Funding from State", "Percentage of funding recieved from the state",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))} %`),
	new ColumnRecord("tCapital", "Total Capital Outlay Expenditure", "Total amount spent on replacement or repair of items",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("fedrOthr", "Federal Funding (Other)", "Funding recieved from other federal sources",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tIntrst", "Interest on School System Indebtedness", "Payment towards interest on school system indebtedness",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrPropTax", "Income from local property taxes", "Total income from local property taxes",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("perPupilTotSpending", "Spending Per Pupil", "How much the school spends per pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("fedrNutr", "Federal child nutrition programs", "Total income from federal child nutrition programs",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("outstandingDebt", "Outstanding Debt", "Total Outstanding Debt",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("fedDis", "Total revenue for children with disabilities", "Total revenue from federal government for children with disabilties",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("strGenFormulaAss", "Total  income from state general formula assistance", "Total income from state general formula assistance (Includes school lunch program, title 1, etc.)",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCursStaffSupport", "Current spending on staff support", "Total Current Spending for Support Services - Instructional staff support",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCursPupil", "Total Current Spending Per Pupil", "The amount of money currently spent per pupil",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tfedrev", "Total Revenue from Federal Goverment", "The amount of money recieved from the federal government",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurOther", "Total Spending (Other)", "Total spending to other and nonspecified",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("longDebtIssued","Long-term debt issued during the fiscal year", "Amount of long-term debt issued during the fiscal year",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tstrev", "Total Revenue from State", "Total revenue recieved from the state",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCursSchAdmin", "Total current spending on school administration", "Amount currently spent on school adminisration",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("locrParGovCont", "Local Parent Government Contrabutions", "Revenue from local parent government contributions",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCursOth", "Total Current Spending (Other)", "Total current spending to other sources",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurInstructionBene", "Total current spending on Employee benefits for instruction", "Total amount current spending on Employee benefits for instruction",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tEmployeeBen", "Total Employee Benefits", "Total amount spent on employee benefits",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurInstructionSalWag", "Total Spending on Wages", "Total spending on salary and wages to teachers",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurSupportServices","Total current spending on support services", "Total amount spent on support services",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurInstruction", "Total spending on instruction", "Total amount of spending on instruction",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("totalExpenditure", "Total Expenditure", "Total Expenditure a school has",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tSalWage", "Total spending on wages and salary", "Overall spending on wages and salary",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("totalrev", "Total Revenue", "Total Revenue the school recieve",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("tCurrSpnd", "Total Current Spending", "How much the school currently spends",(dataset,col)=> `$ ${emptyFilter(defaultHandler(dataset,col))}`),
	new ColumnRecord("pctTotalRev", "Percentage of Total Revenue Spent", "Percentage of total revenue the school is spending",(dataset,col)=> `${emptyFilter(defaultHandler(dataset,col))}%`)
];
