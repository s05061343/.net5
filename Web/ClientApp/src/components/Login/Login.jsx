import * as React from 'react';
import { connect } from 'react-redux';
import * as store from '../Login/Login.js';
import LoadingOverlay from 'react-loading-overlay';

import '../../css/style-se/css/s-signin.css';

class Login extends React.PureComponent {
    render() {
        return (
            <React.Fragment>
                <LoadingOverlay
                    active={this.props.loginUser}
                    spinner
                    text='Loading your content...'
                >
                <div className="text-center">
                    <main className="form-signin">
                        <form>
                            <div className="s-logo"></div>
                            <h1 className="s-title">SEOS醫美管理系統</h1>
                            <div className="form-floating">
                                <input type="text" className="form-control" id="floatingInput" placeholder="ID"
                                    onChange={(e) => { this.props.setUserId(e.target.value); }} />
                                <label htmlFor="floatingInput" >帳號</label>
                            </div>
                            <div className="form-floating">
                                <input type="password" className="form-control" id="floatingPassword" placeholder="Password"
                                    onChange={(e) => { this.props.setPassword(e.target.value); }} />
                                <label htmlFor="floatingPassword" >密碼</label>
                            </div>
                            <button type="button" className="w-100 btn btn-lg s-btn-primary" onClick={() => { this.props.post(); }}>登入</button>
                        </form>
                    </main>
                    </div>
                </LoadingOverlay>
            </React.Fragment>
        );
    }
};

export default connect((state) => state.loginUser, store.actionCreators)(Login);
