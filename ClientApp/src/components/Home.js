import React from 'react';
import { connect } from 'react-redux';
import SchoolSearchBar from './SchoolSearchBar';

const Home = props => (
  <div>
    <SchoolSearchBar />
    </div>
    );

export default connect()(Home);
