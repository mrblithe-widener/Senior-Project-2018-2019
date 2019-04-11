import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import SchoolSearchBar from "./SchoolSearchBar";

class SchoolDisplay extends React.Component{

    componentDidMount(){
        //this.props.requestMath("421476001901");
    }
    render(){
        return (<div>
            <SchoolSearchBar />
            {this.props.match.params.ncesschid}
             </div>);
    }
}

export default connect(() => { return {}}, (dispatch)=>bindActionCreators(actionCreators, dispatch))(SchoolDisplay);