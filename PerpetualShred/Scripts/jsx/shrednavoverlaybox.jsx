import React, { Component } from "react";
import ReactDOM from "react-dom";
import ShredNavOverlay from './shrednavoverlay.jsx';
import ShredNavButton from './shrednavbutton.jsx';

class ShredNavOverlayBox extends Component {
    constructor(props, context) {
        super(props, context);
        this.state = {
            navmenuactive: false,
            allvidspageactive: false
        };

        this.toggle = this.toggle.bind(this);
        this.allVidsPressed = this.allVidsPressed.bind(this);
    }

    toggle() {
        if (this.state.allvidspageactive)
        {
            this.setState({ allvidspageactive: false });
        }
        this.setState({ navmenuactive: !this.state.navmenuactive});
    }
    
    allVidsPressed() {
        this.setState({ navmenuactive: false, allvidspageactive: true });
    }

    render() {
        return (
            <div>
                <ShredNavButton toggleHandler={this.toggle} 
                                animSwitcher={this.state.navmenuactive}/>
                
                <ShredNavOverlay toggleHandler={this.toggle} 
                                 allVidsHandler={this.allVidsPressed}
                                 vidPageAnimSwitcher={this.state.allvidspageactive}
                                 navMenuAnimSwitcher={this.state.navmenuactive}/>
            </div>
        )
    }
}

ReactDOM.render(<ShredNavOverlayBox />,
    document.getElementById('shrednavoverlaybox')
);