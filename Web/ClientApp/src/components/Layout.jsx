import * as React from 'react';
import NavMenu from './NavMenu.jsx';

export default class Layout extends React.PureComponent {
    render() {
        return (
            <React.Fragment>
                <NavMenu />
                <div className="nav-scroller bg-white shadow-sm">
                    <nav className="nav nav-underline" aria-label="Secondary navigation">
                        {/*<a className="nav-link active" aria-current="page" href="/#">Dashboard</a>*/}
                        {/*<a className="nav-link" href="/#">*/}
                        {/*    Friends*/}
                        {/*    <span className="badge bg-light text-dark rounded-pill align-text-bottom">27</span>*/}
                        {/*</a>*/}
                        {/*<a className="nav-link" href="/#">Explore</a>*/}
                        {/*<a className="nav-link" href="/#">Suggestions</a>*/}
                        {/*<a className="nav-link" href="/#">Link</a>*/}
                        {/*<a className="nav-link" href="/#">Link</a>*/}
                        {/*<a className="nav-link" href="/#">Link</a>*/}
                        {/*<a className="nav-link" href="/#">Link</a>*/}
                        {/*<a className="nav-link" href="/#">Link</a>*/}
                    </nav>
                </div>
                <div className='container'>
                    {this.props.children}
                </div>
            </React.Fragment>
        );
    }
}