import React from 'react'
import { BrowserRouter, Switch } from 'react-router-dom'
import { Redirect, Route } from 'react-router-dom'
import AuthorizedRoute from './store/AuthorizedRoute.js'
import ReactNotification from 'react-notifications-component'
/*import AuthorizedRouteCookie from './store/AuthorizedRouteCookie.js'*/
/*import { HashRouter } from "react-router-dom";*/

// Layouts
import Layout from './components/Layout.jsx';
import Home from './components/Home/Home.jsx';
import Login from './components/Login/Login.jsx';
import Logout from './components/Login/Logout.jsx';
import NotFound from './components/Error/NotFound.jsx';
import Unauthorized from './components/Error/Unauthorized.jsx';

import '../src/css/custom.css'
import 'react-notifications-component/dist/theme.css'

export default () => (
    <div>
        <BrowserRouter>
            <ReactNotification />
            <Layout>
                <Switch>
                    <AuthorizedRoute exact path="/home" component={Home} />
                    <AuthorizedRoute path="/login" component={Login} />
                    <AuthorizedRoute path="/logout" component={Logout} />
                    <Route path="/not_found" component={NotFound} />
                    <AuthorizedRoute path="/unauthorized" component={Unauthorized} />
                    <Redirect to="/home" />
                </Switch>
            </Layout>
        </BrowserRouter>
    </div>

);