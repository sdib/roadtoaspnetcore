'use strict';
var webpack = require('webpack');

module.exports = function makeWebpackConfig() {
 
  var config ={};
    config.devtool = 'source-map';

  // Add build specific plugins
    config.plugins=[
      // Reference: http://webpack.github.io/docs/list-of-plugins.html#noerrorsplugin
      // Only emit files when there are no errors
      new webpack.NoEmitOnErrorsPlugin(),

      // Reference: http://webpack.github.io/docs/list-of-plugins.html#uglifyjsplugin
      // Minify all javascript, switch loaders to minimizing mode
      new webpack.optimize.UglifyJsPlugin(),
    ];


  return config;
}();
