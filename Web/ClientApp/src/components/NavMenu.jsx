import * as React from 'react';
import { connect } from 'react-redux';
/*import { NavItem, NavLink } from 'reactstrap';*/
import { Collapse, Navbar, NavbarBrand, NavbarToggler } from 'reactstrap';
import { Link } from 'react-router-dom';
import * as store from '../components/Login/Login.js';
//import { FontAwesomeIcon } from "@fortawesome/react-fontawesome"
//import { fas } from '@fortawesome/free-solid-svg-icons'

import '../css/navmenu.css';

class NavMenu extends React.PureComponent {
    state = {
        isOpen: false
    };

    render() {
        return (
            <Navbar className="navbar navbar-expand-lg fixed-top navbar-dark bg-custom" aria-label="Main navigation">
                <div className="container-fluid">
                    <NavbarToggler onClick={this.toggle} className="navbar-toggler p-0 border-0" data-bs-toggle="offcanvas" aria-label="Toggle navigation" >
                        <span className="navbar-toggler-icon"></span>
                    </NavbarToggler>
                    <NavbarBrand tag={Link} to="/shortenurl" className="navbar-brand">
                        Tomz WebSide
                    </NavbarBrand>
                    <Collapse className="navbar-collapse offcanvas-collapse" isOpen={this.state.isOpen} >
                        <ul className="navbar-nav me-auto mb-2 mb-lg-0 s-menu">
                            {/*<NavItem className="s-item">*/}
                            {/*    <NavLink tag={Link} to="/home">選項</NavLink>*/}
                            {/*</NavItem>*/}
                            {/*<NavItem className="s-item">*/}
                            {/*    <NavLink tag={Link} to="/not_found">選項</NavLink>*/}
                            {/*</NavItem>*/}
                            {/*<NavItem className="s-item">*/}
                            {/*    <NavLink tag={Link} to="/unauthorized">選項</NavLink>*/}
                            {/*</NavItem>*/}
                        </ul>
                    </Collapse>
                </div>
            </Navbar>
        );
    }

    toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
};

export default connect((state) => state.loginUser, store.actionCreators)(NavMenu);
