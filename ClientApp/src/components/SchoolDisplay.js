import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";


class SchoolDisplay extends React.Component{

    componentDidMount(){
        console.log(this.props);
        this.props.requestMath("421476001901");
    }
    render(){
        return (<div>
             
             </div>);
    }
}

export default connect(()=>{}, (dispatch)=>bindActionCreators(actionCreators, dispatch))(SchoolDisplay);