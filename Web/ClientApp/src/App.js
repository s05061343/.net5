import React from 'react'
import { BrowserRouter, Switch, Redirect } from 'react-router-dom'
import AuthorizedRoute from './store/AuthorizedRoute.js'

// Layouts
import Layout from './components/Layout.jsx';
import Home from './components/Home/Home.jsx';
import Login from './components/Login/Login.jsx';
import NotFound from './components/NoMatch/NotFound.jsx';
import Logout from './components/Login/Logout.jsx';

import '../src/css/custom.css'

export default () => (
    <BrowserRouter>
        <Layout>
            <Switch>
                <AuthorizedRoute exact path="/login" component={Login} />
                <AuthorizedRoute exact path="/404" component={NotFound} />
                <AuthorizedRoute exact path="/" component={Home} />
                <AuthorizedRoute path="/logout" component={Logout} />
                <Redirect to="/404" />
            </Switch>
        </Layout>
    </BrowserRouter>
);