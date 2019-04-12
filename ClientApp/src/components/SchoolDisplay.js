import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import SchoolSearchBar from "./SchoolSearchBar";
import LoadingDisplay from "./LoadingDisplay";

class SchoolDisplay extends React.Component{

    constructor(props){
        super(props);
        this.state = {hasRequestedOthers:false};
    }

    

    componentDidMount(){
        if(this.props.match.params.ncesschid){
            this.setState({hasRequestedIndex:true});
            this.props.requestIndex(this.props.match.params.ncesschid);
        }
    }

    componentWillReceiveProps(newProps){
        if(newProps.Index && !this.props.Index){
            this.setState({hasRequestedOthers:true});
            this.props.requestMath(newProps.Index.nceesch);
            this.props.requestRead(newProps.Index.nceesch);
            if(newProps.Index.zip && newProps.Index.zip !== ''){
                this.props.requestBusiness(newProps.Index.zip);
                this.props.requestIncome(newProps.Index.zip);
            }
            this.props.requestFunding(newProps.Index.leaid);
            this.props.requestGeo(newProps.Index.nceesch);
            this.props.requestTeacherRatios(newProps.Index.nceesch);
            this.props.requestTitle1(newProps.Index.nceesch);
        }
    }

    render(){
        return (<div>
            <LoadingDisplay />
            {this.props.match.params.ncesschid}
             </div>);
    }
}

export default connect((state) => {console.log(state); return {
        Math_Scores:state.school.Math_Scores, 
        Read_Scores:state.school.Read_Scores,
        Business:state.school.Business,
        Funding:state.school.Funding,
        Geo:state.school.Geo,
        Income:state.school.Income,
        Index:state.school.Index,
        TeacherRatios:state.school.TeacherRatios,
        Title1:state.school.Title1

}}, (dispatch)=>bindActionCreators(actionCreators, dispatch))(SchoolDisplay);