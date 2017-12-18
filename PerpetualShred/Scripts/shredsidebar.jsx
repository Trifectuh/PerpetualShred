﻿import React, { Component } from "react";

class Shredsidebar extends Component {
    render() {
        var visibility = "hide";

        if (this.props.menuVisibility) {
            visibility = "show";
        }

        return (
            <div>
                <div id="flyoutMenuBackground"
                    onMouseDown={this.props.handleMouseDown}
                    className={visibility}>
                </div>
                <div id="flyoutMenu"
                    onMouseDown={this.props.handleMouseDown}
                    className={visibility}>
                    <div id="vidtitle">
                        {jsModel.Title}
                    </div>
                    <div id="descriptionheader">
                        DESCRIPTION:
                    </div>
                    <div id="vidsynopsis">
                        {jsModel.Synopsis}
                    </div>
                    <div id="vidoriginlink">
                        read more at {jsModel.VideoService}.com
                    </div>
                </div>
            </div>
        );
    }
}

export default Shredsidebar;