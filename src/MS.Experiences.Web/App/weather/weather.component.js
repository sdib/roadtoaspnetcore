
function WeatherController(weatherFactory) {
    var vm = this;
    vm.data = weatherFactory.data;
    weatherFactory.loadWeatherAsync();
    return vm;
}

var weather = angular.module('ms.experience.weather');
weather.component('weather',
    {
        controller: ['WeatherFactory', WeatherController],
        templateUrl: 'App/weather/weather.html'
    });
