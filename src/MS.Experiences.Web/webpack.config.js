"use strict";

// Modules
var webpack = require("webpack");
var merge = require("webpack-merge");
//var autoprefixer = require("autoprefixer");
//var ExtractTextPlugin = require("extract-text-webpack-plugin");

/**
 * Environment
 */
var env = { name: "test" };
env.isDev = process.argv.indexOf("--env.dev") > 0;
env.isProd = process.argv.indexOf("--env.prod") > 0;
env.isTest = !env.isDev && !env.isProd;
if (env.isProd) {
  env.name = "prod";
} else if (env.isDev) {
  env.name = "dev";
}

console.log(
  `WebPack environment test:${env.isTest} prod:${env.isProd} dev:${env.isDev} `
);

module.exports = (function makeWebpackConfig() {
  var config = {};

  config.node = {
    fs: "empty"
  };

  config.target = "node";

  config.entry = {
    app: "./App/app.run.js"
  };

  config.output = {
    path: __dirname + "/wwwroot/dist",
    filename: "app.bundle.js"
  };

  config.module = {
    rules: [
      {
        test: /\.js$/,
        include: /semantic/,
        loaders: ["imports-loader?define=>false&this=>window&angular"]
      },
      {
        test: /\.js$/,
        loader: "babel-loader",
        exclude: /node_modules/,
      },
      {
        test: /\.css$/,
        use: ["style-loader", "css-loader"]
      },
      {
        test: /\.(png|jpg|jpeg|gif|svg|woff|woff2|ttf|eot)$/,
        loader: "file-loader"
      },
      {
        test: /\.html$/,
        loader: "raw-loader"
      }
    ]
  };

  // Configuration by environment
  var webpackEnvConfig = require("./webpack.config." + env.name + ".js");
  var finalConfig = merge(config, webpackEnvConfig);

  return finalConfig;
})();
