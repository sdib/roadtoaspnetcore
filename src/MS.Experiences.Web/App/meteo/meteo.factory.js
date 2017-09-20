
function MeteoFactory($http) {

    var loadMeteoAsync=function(){
        meteo.data.isLoading = true;
        return $http.get('api/weather/5').then(function (response) {
            var elements = response.data;
            for (var i = 0; i < elements.length; i++) {
                meteo.data.weatherForecasts.push(elements[i]);
            }
            meteo.data.isLoading = false;
        });
    }

    var meteo = {
        data: {
            weatherForecasts:[],
            isLoading:false
        },
        loadMeteoAsync:loadMeteoAsync
    };

    return meteo;
}
var meteo = angular.module('ms.experience.meteo');
meteo.factory('MeteoFactory', ['$http', MeteoFactory]);