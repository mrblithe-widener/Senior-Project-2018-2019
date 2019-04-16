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
export function emptyFilter(text){
    if(! (typeof text ==='number') && (! text || text.match(/^\s+$/)))
        return "Not Available";
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
    return (<tr key={record.Column_Name} >
                <td key={record.Column_Name + "label"} data-toggle="tooltip" data-placement="bottom" title={record.Column_Description}>
                    {record.Column_Friendly_Name}
                </td>
                <td key={record.Column_Name + "value"} >
                    {emptyFilter(record.handler(dataset, record.Column_Name))}
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

export const TeacherRatioCols = [
    new ColumnRecord("numFullTime", "Number of Teachers", "the total full-time-equivalent classroom teachers")
]