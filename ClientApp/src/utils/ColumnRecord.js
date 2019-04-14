import * as React from 'react';
function defaultHandler(dataset, Column_Name){
    return dataset[Column_Name];
}

export function emptyFilter(text){
    if(! (typeof text ==='number') && (! text || text.match(/^\s+$/)))
        return "Not Available";
    return text;
}

class ColumnRecord{
    constructor(Column_Name, Column_Friendly_Name, Column_Description, handler=defaultHandler){
        this.Column_Name = Column_Name;
        this.Column_Friendly_Name = Column_Friendly_Name;
        this.Column_Description = Column_Description;
        this.handler = handler;
    }
}

export function RenderRowContent(record, dataset){
    return (<tr>
                    <td data-toggle="tooltip" data-placement="bottom" title={record.Column_Description}>
                        {record.Column_Friendly_Name}
                    </td>
                    <td>
                        {emptyFilter(record.handler(dataset, record.Column_Name))}
                    </td>
                </tr>);
}

export const MathCols = [
    new ColumnRecord("math_all_grades_numvalid","Math: Number of Testing Students", "Total number of students that completed an assessment and for whom a proficiency level was assigned", (dataset, _)=>dataset['mathAllGradesNumvalid'] <0?"Not Available":dataset['mathAllGradesNumvalid']),
    new ColumnRecord("math_pct_prof", "Math: Percentage Proficient", "Percentage of students in the school that scored at or above proficient", (dataset,_)=>dataset['mathAllGradesPctprofLow']>0?((dataset['mathAllGradesPctprofLow']+dataset['mathAllGradesPctprofHigh'])/2)+'%':""),
]

export const ReadCols = [
    new ColumnRecord("read_all_grades_numvalid","Read: Number of Testing Students", "Total number of students that completed an assessment and for whom a proficiency level was assigned", (dataset, _)=>dataset['readAllGradesNumvalid'] <0?"Not Available":dataset['readAllGradesNumvalid']),
    new ColumnRecord("read_pct_prof", "Read: Percentage Proficient", "Percentage of students in the school that scored at or above proficient", (dataset,_)=>dataset['readAllGradesPctprofLow']>0?((dataset['readAllGradesPctprofLow']+dataset['readAllGradesPctprofHigh'])/2)+'%':""),
]