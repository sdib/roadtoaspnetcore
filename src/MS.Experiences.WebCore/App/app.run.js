import 'angular';
import 'bootstrap/dist/css/bootstrap.min.css';

if (module['hot']) {
    module['hot'].accept();
} 

import weather from './weather';
import './app.css';

var modules = [weather.name];
var app = angular.module('ms.experience', modules);

app.run([function () { }]);
