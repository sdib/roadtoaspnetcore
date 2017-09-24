'use strict';

// Modules
var webpack = require('webpack');
var merge = require('webpack-merge');
var autoprefixer = require('autoprefixer');
var ExtractTextPlugin = require('extract-text-webpack-plugin');

/**
 * Environment
 */
var env = {name:'test'};
env.isDev = process.argv.indexOf('--env.dev') > 0;
env.isProd = process.argv.indexOf('--env.prod') > 0;
env.isTest = !env.isDev && !env.isProd;
if(env.isProd) { 
  env.name = 'prod';
} else if(env.isDev){
  env.name = 'dev';
}

console.log(`WebPack environment test:${env.isTest} prod:${env.isProd} dev:${env.isDev} `);

module.exports = function makeWebpackConfig() {
  /**
   * Config
   * Reference: http://webpack.github.io/docs/configuration.html
   * This is the object where all configuration gets set
   */
  var config = {};

  config.node= {
   fs: "empty"
  }
  config.target= 'node';

  /**
   * Entry
   * Reference: http://webpack.github.io/docs/configuration.html#entry
   * Should be an empty object if it's generating a test build
   * Karma will set this when it's a test build
   */
  config.entry =  {
    app: './wwwroot/app/app.js'
  };

  /**
   * Output
   * Reference: http://webpack.github.io/docs/configuration.html#output
   * Should be an empty object if it's generating a test build
   * Karma will handle setting it up for you when it's a test build
   */
  config.output =  {
    // Absolute output directory
    path: __dirname + '/wwwroot/dist',

    // Filename for entry points
    // Only adds hash in build mode
    filename: 'app.bundle.js', //isProd ? '[name].[hash].js' : '[name].bundle.js',
  };

  /**
   * Loaders
   * Reference: http://webpack.github.io/docs/configuration.html#module-loaders
   * List: http://webpack.github.io/docs/list-of-loaders.html
   * This handles most of the magic responsible for converting modules
   */

  // Initialize module
  config.module = {
    
    rules: [{
      test: /\.js$/,
      include: /semantic/,
      loaders: ['imports-loader?define=>false&this=>window&angular']
    },{
      // JS LOADER
      // Reference: https://github.com/babel/babel-loader
      // Transpile .js files using babel-loader
      // Compiles ES6 and ES7 into ES5 code
      test: /\.js$/,
      loader: 'babel-loader',
      exclude: /node_modules/,
      query: {
          presets: ["es2015"]
      }
    }, {
      // CSS LOADER
      // Reference: https://github.com/webpack/css-loader
      // Allow loading css through js
      //
      // Reference: https://github.com/postcss/postcss-loader
      // Postprocess your css with PostCSS plugins
      test: /\.css$/,
      // Reference: https://github.com/webpack/extract-text-webpack-plugin
      // Extract css files in production builds
      //
      // Reference: https://github.com/webpack/style-loader
      // Use style-loader in development.

      use: ['style-loader', 'css-loader']
    }, {
      // ASSET LOADER
      // Reference: https://github.com/webpack/file-loader
      // Copy png, jpg, jpeg, gif, svg, woff, woff2, ttf, eot files to output
      // Rename the file using the asset hash
      // Pass along the updated reference to your code
      // You can add here any file extension you want to get copied to your output
      test: /\.(png|jpg|jpeg|gif|svg|woff|woff2|ttf|eot)$/,
      loader: 'file-loader'
    }, {
      // HTML LOADER
      // Reference: https://github.com/webpack/raw-loader
      // Allow loading html through js
      test: /\.html$/,
      loader: 'raw-loader'
  }

    ]
  };


  /**
   * PostCSS
   * Reference: https://github.com/postcss/autoprefixer-core
   * Add vendor prefixes to your css
   */
   // NOTE: This is now handled in the `postcss.config.js`
   //       webpack2 has some issues, making the config file necessary

  /**
   * Plugins
   * Reference: http://webpack.github.io/docs/configuration.html#plugins
   * List: http://webpack.github.io/docs/list-of-plugins.html
   */
  config.plugins = [
    new webpack.LoaderOptionsPlugin({
      test: /\.scss$/i,
      options: {
        postcss: {
          plugins: [autoprefixer]
        }
      }
    })
  ];

  // Configuration by environment
  var webpackEnvConfig = require('./webpack.config.'+ env.name + '.js');
  var finalConfig = merge(config, webpackEnvConfig);

  return finalConfig;
}();
