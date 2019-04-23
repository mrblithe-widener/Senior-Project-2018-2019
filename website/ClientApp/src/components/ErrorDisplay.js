import React from "react";
import {connect} from "react-redux";
import {actionCreators} from "../store/School";
import { bindActionCreators } from "redux";
import {Alert} from "reactstrap";

class ErrorDisplay extends React.Component{
	render(){
		if(this.props.error.errorMessage)
			return (<div>
						<Alert color="danger">
							{this.props.error.errorMessage}
						</Alert>
					</div>);
		else
			return null;
	}

}

export default connect((state)=>{return {error:state.error}})(ErrorDisplay);
