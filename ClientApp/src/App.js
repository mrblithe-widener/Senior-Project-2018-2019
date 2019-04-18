import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import SchoolDisplay from './components/SchoolDisplay';
import {Report} from "./components/Report"

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/School/:ncesschid' component={SchoolDisplay} />
    <Route path="/report" component={Report} />
  </Layout>
);
