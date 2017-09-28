const webpack = require("webpack");
const merge = require("webpack-merge");
const path = require("path");  

console.log(
  `WebPack environment : ${process.env.NODE_ENV}`
);

module.exports = (function makeWebpackConfig() {
  var config = {};

  config.entry = {
    app: "./App/app.run.js"
  };

  config.output = {
      path: path.join(__dirname, "wwwroot/dist"),
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
  var webpackEnvConfig = require("./webpack.config." + process.env.NODE_ENV + ".js");
  var finalConfig = merge(config, webpackEnvConfig);

  return finalConfig;
})();
