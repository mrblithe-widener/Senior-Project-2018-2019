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
						<h1 id="definitions-and-methodology">Definitions and Methodology</h1>
						<p>This analysis was performed using a variety of machine learning techniques with data from government sources. The first machine learning technique used was random forest decision trees. This method trains a collection of decision trees that vote on the data to obtain a result. A simple decision tree may take the form of deciding whether or not to wear shorts or long pants. It may state that if the temperature is above 70 degrees fahrenheit, the person will wear shorts. Several hundred of these trees are trained on a small portion of the data and the trees then vote on the result. This technique can also rank the importance of the attributes. The next machine learning tool used is a neural network. This works like the brain. It has a collection of neurons which create an output based off some internal weight when given an input. This weight is adjusted during the training process on the data. Finally, genetic algorithms are used. This algorithm draws from evolution in biology. A random population of organisms, or in this case hypothetical schools, are created and these “organisms” are combined to eventually produce a result. The performance of these hypothetical schools was created using a neural network.</p>
						<h1 id="selected-results">Selected Results</h1>
						<h2 id="location">Location</h2>
						<p>The location of the schools created by the genetic algorithms appeared in only a few states. In particular, the schools primarily appeared in Iowa, Pennsylvania and, New York, as well as a few additional states. These states appear to be darker as well as seen in the actual school data, meaning higher performance on the tests. Latitude, longitude, and state account for three of the top ten features in terms of importance as assigned by the random forest tree.</p>
						<p><img className="img-fluid" src={process.env.PUBLIC_URL+"/images/GeneticMap.png"} alt="The schools created by the genetic algorithm. Darker means higher scores" /> The Performance of the Schools Created by the Genetic Algorithm. Darker Means Higher Test Scores.</p>
						<p><img className="img-fluid" src={process.env.PUBLIC_URL+"/images/actualMap.png"} alt="The schools created by the genetic algorithm. Darker means higher scores" /> The School Performance from the Government Data. Darker Means Higher Test Scores.</p>
						<h2 id="student-to-teacher-ratios">Student to Teacher Ratios</h2>
						<p>As shown in the figure below, the schools the genetic algorithm created each have very low student to teacher ratios, while the actual schools have much higher student to teacher ratios. This shows that student to teacher ratios are highly significant. This is confirmed by the random forest decision tree, which determined the student to teacher ratio to be significant.</p>
						<p><img src={process.env.PUBLIC_URL+"/images/read_full_time_cropped.png"} className="img-fluid" /></p>
						<h2 id="title-i">Title I</h2>
						<p>The most significant attribute for a school according to the random forest decision tree was whether or not the school receives funding from Title I. Title I is a federal funding program. This program provides funds to schools with a high number of children of low-income families to help them achieve academic standards. As shown in the figure below the schools created by the genetic algorithms almost unanimously do not receive Title I money. The reason for this result requires further research.</p>
						<p><img src={process.env.PUBLIC_URL+"/images/school_wide_title_i_eligibility_Yes.png"} className="img-fluid" /></p>
						<h2 id="number-of-students">Number of Students</h2>
						<p>As seen in the figure below, the schools created by the genetic algorithm tend to have a higher number of students than real schools. However, as discussed above the hypothetical schools maintain a low student to teacher ratio by employing many faculty thus, meaning that having more students can be beneficial, but only if there is the teaching staff to adequately support those students. These numbers were extrapolated from the number of students who took and were assigned a proficiency score for the math portion of the standardized test.</p>
						<p><img src={process.env.PUBLIC_URL+ "/images/math_all_grades_numvalid_cropped.png"} className="img-fluid" /></p>
						<h2 id="per-pupil-spending">Per Pupil Spending</h2>
						<p>It was discovered that the amount of money spent per student, as well as the total amount spent, had less impact on performance. This was discovered using a decision tree to rank the importance of each attribute of the school.</p>
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
