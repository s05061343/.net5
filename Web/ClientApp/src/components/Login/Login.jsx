import * as React from 'react';
import { connect } from 'react-redux';
import * as store from '../Login/Login.js';

class Login extends React.PureComponent {
    render() {
        return (
            <React.Fragment>
                <div className="container">
                    <div className="row">
                        <div className="col-md-5 mx-auto">
                            <div id="first">
                                <div className="myform form ">
                                    <div className="logo mb-3">
                                        <div className="col-md-12 text-center">
                                            <h1>Login</h1>
                                        </div>
                                    </div>
                                    <form action="" method="post" name="login">
                                        <div className="mb-3">
                                            <input type="email" name="email" className="form-control" id="email" aria-describedby="emailHelp" placeholder="帳號"
                                                onChange={(e) => { this.props.setUserId(e.target.value); }} />
                                        </div>
                                        <div className="mb-3">
                                            <input type="password" name="password" id="password" className="form-control" aria-describedby="emailHelp" placeholder="密碼"
                                                onChange={(e) => { this.props.setPassword(e.target.value); }} />
                                        </div>
                                        <div className="d-grid gap-2">
                                            <button type="button" className="btn btn-primary btn-lg" onClick={() => { this.props.post(); }}>登入</button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </React.Fragment>
        );
    }
};

export default connect((state) => state.loginUser, store.actionCreators)(Login);
