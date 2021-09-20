import * as React from 'react';
import NavMenu from './NavMenu.jsx';

export default class Layout extends React.PureComponent {
    render() {
        return (
            <React.Fragment>
                <NavMenu />
                <div className="s-content">
                    {this.props.children}
                </div>
            </React.Fragment>
        );
    }
}