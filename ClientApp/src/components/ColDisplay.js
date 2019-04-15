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
						    {this.props.Cols.map(x=>
							    RenderRowContent(x, this.props.dataset))
                                }
                        </tbody>
					</Table>
				</Jumbotron>)
		else
			return null;

	}
}
