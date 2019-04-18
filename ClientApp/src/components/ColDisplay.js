import * as React from "react";
import {Jumbotron, Table} from "reactstrap";
import {RenderRowContent} from "../utils/ColumnRecord";

export default class ColDisplay extends React.Component{
	render(){
		if(this.props.show && this.props.Cols && this.props.dataset)
			return (
				<Jumbotron>
					<h5> {this.props.Name} </h5>
                    <Table>
                        <tbody>
						    {this.props.Cols.sort((a,b)=> a.Column_Friendly_Name.toLowerCase()<b.Column_Friendly_Name.toLowerCase()?-1:1).map(x=>
							    RenderRowContent(x, this.props.dataset))
                                }
                        </tbody>
					</Table>
				</Jumbotron>)
		else
			return null;

	}
}
