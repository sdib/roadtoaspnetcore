"use strict";
var webpack = require("webpack");

module.exports = (function makeWebpackConfig() {
  var config = {};
  config.devtool = "source-map";

  config.plugins = [
    new webpack.NoEmitOnErrorsPlugin(),
    new webpack.optimize.UglifyJsPlugin()
  ];

  return config;
})();
