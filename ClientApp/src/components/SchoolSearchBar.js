import React from "react";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import { Form, FormGroup, ListGroup, ListGroupItem, Input } from "reactstrap";
import {actionCreators} from "../store/Search"
import {Link} from "react-router-dom";

class SchoolSearchBar extends React.Component {
    constructor(props){
        super(props);
        this.state = {hideSearch:true}
    }
    onInputChange(e) {
        this.props.requestSearch(e.currentTarget.value);
    }
    handleSubmit(e){
        e.preventDefault();
    }
    searchChildrenTree(current, target){
        if(current === target)
            return true;
        if(!current || current.children.length === 0)
            return false
        for(let i = 0; i<current.children.length; i++){
            if(this.searchChildrenTree(current.children[i], target))
                return true;
        }
        return false;
    }
    handleFocusEnter(e){
        this.setState({hideSearch:false});
    }
    handleFocusLeave(e){
        const parent = document.getElementById("School-Search-Container");
        const searchResult = this.searchChildrenTree(parent, e.relatedTarget)
        if(this.searchChildrenTree(parent, e.relatedTarget))//Check if the new target is a child of the search bar container
            this.setState({hideSearch:false});
        else 
            this.setState({hideSearch:true})
    }
    render() {
        return (<div id="School-Search-Container">
            <Form onSubmit={this.handleSubmit.bind(this)}>
                <FormGroup>
                    <Input type="text" autoComplete="off" name="school_name" id="school_name" onChange={this.onInputChange.bind(this)} onFocus={this.handleFocusEnter.bind(this)}  onBlur={this.handleFocusLeave.bind(this)}
                    placeholder="Start typing a school name" />
                </FormGroup>
            </Form>
            {!this.state.hideSearch && this.props.searchResults && this.props.searchResults.length > 0 ?
                <div >
                    <ListGroup>
                        {this.props.searchResults.map((x, i) => <ListGroupItem onFocus={this.handleFocusEnter.bind(this)} onBlur={this.handleFocusLeave.bind(this)} key={i}>
                            <Link onFocus={this.handleFocusEnter.bind(this)} onBlur={this.handleFocusLeave.bind(this)} to={`/school/${x.nceesch}`}>{`${x.name}, ${x.countyName}, ${x.state}`}</Link> </ListGroupItem>)}
                        <ListGroupItem> Can't find what your looking for? Try entering the zip code where the school is located. </ListGroupItem>
                    </ListGroup>
                </div>
                :null
}
        </div>);
    }
}

export default connect((state) => { return { searchResults: state.search.results } }, (dispatch) => bindActionCreators(actionCreators, dispatch))(SchoolSearchBar);