
import 'angular';
import 'bootstrap/dist/css/bootstrap.min.css';
import './app.css';
import wheather from './wheather';

const modules = [wheather.name];
const app = angular.module('ms.experience', modules);

app.run([function () { }]);
