import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import SchoolSearchBar from "./SchoolSearchBar";
import LoadingDisplay from "./LoadingDisplay";
import ErrorDisplay from "./ErrorDisplay";
import { errorActionCreators } from "../store/Error";
import {MathCols, RenderRowContent, ReadCols, emptyFilter} from "../utils/ColumnRecord";
import {Table} from "reactstrap";

class SchoolDisplay extends React.Component{

    constructor(props){
        super(props);
        this.state = {hasRequestedOthers:false};
    }

    componentWillUnmount(){
        this.props.error.clearError();
		this.props.school.clearAll();
    }
    

    componentDidMount(){
        if(this.props.match.params.ncesschid){
            this.setState({hasRequestedIndex:true});
            this.props.school.requestIndex(this.props.match.params.ncesschid);
        }
    }

    componentWillReceiveProps(newProps){
        if(newProps.Index && !this.props.Index){
            this.setState({hasRequestedOthers:true});
            this.props.school.requestMath(newProps.Index.nceesch);
            this.props.school.requestRead(newProps.Index.nceesch);
            if(newProps.Index.zip && newProps.Index.zip !== ''){
                this.props.school.requestBusiness(newProps.Index.zip);
                this.props.school.requestIncome(newProps.Index.zip);
            }
            this.props.school.requestFunding(newProps.Index.leaid);
            this.props.school.requestGeo(newProps.Index.nceesch);
            this.props.school.requestTeacherRatios(newProps.Index.nceesch);
            this.props.school.requestTitle1(newProps.Index.nceesch);
        }
    }

    render(){
        return (<div>
			<ErrorDisplay />
            <LoadingDisplay />
            {this.props.Math_Scores?<h4>{this.props.Math_Scores.mathSchnam+", "+this.props.Math_Scores.mathLeanm}</h4>:null}
            {this.props.Geo?<h5>{this.props.Geo.street+", "+this.props.Geo.city+", "+this.props.Geo.state+", "+this.props.Geo.zip}</h5>:null}
            <Table  borderless={true} style={{width:"75%"}}> 
				<tr>
					{this.props.Math_Scores? readMathRender(this.props.Math_Scores, MathCols):null}
					{this.props.Math_Scores && this.props.TeacherRatios? 
						[<td data-toggle="tooltip" data-placement="bottom" title={MathCols[2].Column_Description}>
							{MathCols[2].Column_Friendly_Name}
						</td>,
						<td>
							{emptyFilter(MathCols[2].handler(this.props.Math_Scores['mathAllGradesNumvalid'], this.props.TeacherRatios.numFullTime))}
						</td>]:null}</tr>
						<tr>
					{this.props.Read_Scores? readMathRender(this.props.Read_Scores, ReadCols):null}
					{this.props.Read_Scores && this.props.TeacherRatios? 
						[<td data-toggle="tooltip" data-placement="bottom" title={ReadCols[2].Column_Description}>
							{ReadCols[2].Column_Friendly_Name}
						</td>,
						<td>
							{emptyFilter(ReadCols[2].handler(this.props.Read_Scores['readAllGradesNumvalid'], this.props.TeacherRatios.numFullTime))}
						</td>]:null}
			</tr>

            </Table>
             </div>);
    }
}

function readMathRender(dataset, cols){
    return [
        <td data-toggle="tooltip" data-placement="bottom" title={cols[0].Column_Description}>
            {cols[0].Column_Friendly_Name}
        </td>,
        <td>
            {emptyFilter(cols[0].handler(dataset, cols[0].Column_Name))}
        </td> ,
        <td data-toggle="tooltip" data-placement="bottom" title={cols[1].Column_Description}>
            {cols[1].Column_Friendly_Name}
        </td>,
        <td>
            {emptyFilter(cols[1].handler(dataset, cols[1].Column_Name))}
        </td>
		];
}

export default connect((state) => {return {
        Math_Scores:state.school.Math_Scores, 
        Read_Scores:state.school.Read_Scores,
        Business:state.school.Business,
        Funding:state.school.Funding,
        Geo:state.school.Geo,
        Income:state.school.Income,
        Index:state.school.Index,
        TeacherRatios:state.school.TeacherRatios,
        Title1:state.school.Title1

}}, (dispatch)=>{
    return {school:bindActionCreators(actionCreators, dispatch),
        error:bindActionCreators(errorActionCreators, dispatch)}
    })(SchoolDisplay);
