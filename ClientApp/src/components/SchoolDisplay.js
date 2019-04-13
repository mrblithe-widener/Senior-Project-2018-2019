import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import SchoolSearchBar from "./SchoolSearchBar";
import LoadingDisplay from "./LoadingDisplay";
import ErrorDisplay from "./ErrorDisplay";
import { errorActionCreators } from "../store/Error";

class SchoolDisplay extends React.Component{

    constructor(props){
        super(props);
        this.state = {hasRequestedOthers:false};
    }

    componentWillUnmount(){
        this.props.error.clearError();
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
            {this.props.match.params.ncesschid}
             </div>);
    }
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
