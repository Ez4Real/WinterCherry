const path = require("path");
const { CleanWebpackPlugin } = require("clean-webpack-plugin");
module.exports = {
  entry: "./wwwroot/src/js/app.js",
  output: {
    path: path.resolve(__dirname, "wwwroot/dist"),
    filename: "bundle.js",
  },
  plugins: [new CleanWebpackPlugin()],
};
