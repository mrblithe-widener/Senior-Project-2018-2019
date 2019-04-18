import * as React from "react";
import {Jumbotron} from "reactstrap";


/**
 * Displays the content for the report
 */
export class Report extends React.Component{

    constructor(props){
        super(props);
        this.state = {showReport1:false, showReport2:false};
    }

    /**
     *  Handles the click event to show the given report
     * @param {The event handler} e 
     */
    handleClick(e){
        if(e.currentTarget.id ==="Report1")
            this.setState({showReport1:!this.state.showReport1});
        else if(e.currentTarget.id === 'Report2')
            this.setState({showReport2:!this.state.showReport2});
    }
    render(){
        return (<div>
            <Jumbotron>
            <h1>Our Report</h1>
            Michael Blithe, Josh Martini, Anton Smolka
            </Jumbotron>
            <div id="Report1" className="p-3 mb-2 bg-primary text-white" style={{borderRadius:10}} onClick={this.handleClick.bind(this)}>
                    Analysis of School Performance Data Using Machine Learning
            </div>

            {this.state.showReport1?(
                <div>
                    <div className="p-3 mb-2 bg-primary text-white">
                    <p className="lead">
                        [Report goes here]
                    </p>
                    </div>
                </div>
            ):null}
            <div id="Report2" className="p-3 mb-2 bg-primary text-white" style={{borderRadius:10}} onClick={this.handleClick.bind(this)}>
                Analysis of School Performance Data Using Statistical Analysis 
            </div>

            {this.state.showReport2?(
            <div>
                
                <div className="p-3 mb-2 bg-primary text-white">
                <p className="lead">
                    [Report goes here]
                </p>
                </div>
            </div>
            ):null}
        </div>);

    }
}