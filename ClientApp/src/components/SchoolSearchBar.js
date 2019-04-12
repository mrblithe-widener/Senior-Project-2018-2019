import React from "react";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import { Form, FormGroup, ListGroup, ListGroupItem, Input } from "reactstrap";
import {actionCreators} from "../store/Search"
import {Link} from "react-router-dom";

class SchoolSearchBar extends React.Component {
    componentWillMount() {
        //this.props.requestSearch("Paxon");
    }
    onInputChange(e) {
        this.props.requestSearch(e.currentTarget.value);
    }
    render() {
        return (<div>
            <Form>
                <FormGroup>
                    <Input type="text" name="school_name" id="school_name" onChange={this.onInputChange.bind(this)} placeholder="Start typing a school name" />
                </FormGroup>
            </Form>
            {this.props.searchResults && this.props.searchResults.length > 0 ?
                <div>
                    <ListGroup>
                        {this.props.searchResults.map((x, i) => <ListGroupItem key={i}><Link to={`/school/${x.nceesch}`}>{`${x.name}, ${x.countyName}, ${x.state}`}</Link> </ListGroupItem>)}
                        <ListGroupItem> Can't find what your looking for? Try entering the zip code where the school is located. </ListGroupItem>
                    </ListGroup>
                </div>
                :null
}
        </div>);
    }
}

export default connect((state) => { return { searchResults: state.search.results } }, (dispatch) => bindActionCreators(actionCreators, dispatch))(SchoolSearchBar);