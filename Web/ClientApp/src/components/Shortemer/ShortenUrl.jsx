import * as React from 'react';
import { connect } from 'react-redux';
import * as store from '../Shortemer/ShortenUrl.js';

import '../../css/shortemerform.css';

class ShortenUrl extends React.PureComponent {
    render() {
        return (
            <React.Fragment>
                <div className="text-center">
                    <main className="form-signin">
                        <form>
                            <img className="mb-4" src="/logo_transparent.png" alt="" width="50%" height="50%"/>
                            <h1 className="h3 mb-3 fw-normal">縮網址</h1>
                            <div className="form-floating">
                                <input type="email" className="form-control" id="floatingInput" placeholder="name@example.com"
                                    onChange={(e) => { this.props.setUrl(e.target.value); }} />
                                <label htmlFor="floatingInput">在這裡輸入你的網址:</label>
                            </div>
                            <button className="w-100 btn btn-lg btn-primary" type="button" onClick={() => { this.props.post(); }}>產生</button>
                            <p className="mt-5 mb-3 text-muted">© 2017–2021</p>
                            <p className="mt-5 mb-3 text-muted">{this.props.value.translationUrl}</p>
                        </form>
                    </main>
                </div>
            </React.Fragment>
        );
    }
};

export default connect((state) => state.shortemer, store.actionCreators)(ShortenUrl);
