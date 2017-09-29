
function WeatherController(weatherFactory) {
    var vm = this;
    vm.data = weatherFactory.data;
    weatherFactory.loadWeatherAsync();
    return vm;
}

var weather = angular.module('ms.experience.weather');
//import weather from './weather.module';
//import WeatherFactory from './weather.factory';
//import './weather.css';

weather.component('weather',
    {
        controller: ['WeatherFactory', WeatherController],
        templateUrl: 'App/weather/weather.html'
    });
