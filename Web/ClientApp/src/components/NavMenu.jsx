import * as React from 'react';
import { connect } from 'react-redux';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import * as store from '../components/Login/Login.js';
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome"
import { fas } from '@fortawesome/free-solid-svg-icons'

import '../css/NavMenu.css';
import '../css/style-se/css/s-header.css'


class NavMenu extends React.PureComponent {
    state = {
        isOpen: false
    };

    render() {
        return (
            <header className='s-header'>
                <div className="container-fluid">
                    <Navbar className="navbar navbar-expand-lg py-0 s-header-body" light>
                        <NavbarToggler onClick={this.toggle} className="" data-bs-toggle="offcanvas" aria-label="Toggle navigation" />
                        <Collapse className="navbar-collapse offcanvas-collapse" isOpen={this.state.isOpen} >
                            <div className="s-header-logo">
                                <NavbarBrand tag={Link} to="/home" className="s-header-brand"></NavbarBrand>
                                <button aria-label="Toggle navigation" data-bs-toggle="offcanvas" type="button" className="navbar-toggler" onClick={this.toggle}>
                                    <FontAwesomeIcon icon={fas.faTimes} size="lg" color="white" />
                                </button>
                            </div>
                            <ul className="navbar-nav me-auto mb-2 mb-lg-0 s-menu">
                                <NavItem className="s-item">
                                    <NavLink tag={Link} to="/home">選項</NavLink>
                                </NavItem>
                                <NavItem className="s-item">
                                    <NavLink tag={Link} to="/not_found">選項</NavLink>
                                </NavItem>
                                <NavItem className="s-item">
                                    <NavLink tag={Link} to="/unauthorized">選項</NavLink>
                                </NavItem>
                            </ul>
                        </Collapse>
                    </Navbar>
                </div>
                <div className="s-headline py-2 bg-white border-bottom shadow-sm small">
                    <div className="container-fluid">
                        <div className="s-account">
                            <span className="s-item-type">基本權限(SE)-專員</span>
                            <span className="s-item-name">李米妮</span>
                            <span className="s-item-btn"><a className="btn btn-sm s-btn-primary" onClick={() => { this.props.logout(); }}>登出</a></span>
                        </div>
                        <nav className="s-breadcrumb" aria-label="breadcrumb">
                            <ol className="breadcrumb m-0">
                                <li className="breadcrumb-item"><a>首頁</a></li>
                                <li className="breadcrumb-item"><a>頁面</a></li>
                                <li className="breadcrumb-item active" aria-current="page">所在頁面</li>
                                <li className="s-item-btn"><a className="btn btn-sm s-btn-outline-primary">★加入最愛</a></li>
                                <li className="s-item-btn"><a className="btn btn-sm s-btn-outline-primary">友善列印</a></li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </header>
        );
    }

    toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
};

export default connect((state) => state.loginUser, store.actionCreators)(NavMenu);
