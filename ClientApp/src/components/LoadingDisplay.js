import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import {Spinner} from "reactstrap"


class LoadingDisplay extends React.Component{
    render(){
        if(this.props.loading && this.props.loading.length > 0)
            return <div className="text-center">
                <div className="spinner-border" role="status" style={{width:'10em', height:'10em'}}>
                  <span className="sr-only">Loading...</span>
                </div>
            </div>;
        return null;
    }
}

export default connect((state)=>{
    return state.loading
})(LoadingDisplay);
