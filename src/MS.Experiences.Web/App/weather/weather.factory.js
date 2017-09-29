
function WeatherFactory($http) {

    var loadWeatherAsync = function () {
        var _data = weather.data;
        _data.isLoading = true;
        return $http.get('api/weather/5').then(function (response) {
            var elements = response.data;
            for (var i = 0; i < elements.length; i++) {
                _data.weatherForecasts.push(elements[i]);
            }
            _data.isLoading = false;
        });
    }

    var weather = {
        data: {
            weatherForecasts: [],
            isLoading: false
        },
        loadWeatherAsync: loadWeatherAsync
    };

    return weather;
}
var weather = angular.module('ms.experience.weather');
//import weather from './weather.module';
weather.factory('WeatherFactory', ['$http', WeatherFactory]);