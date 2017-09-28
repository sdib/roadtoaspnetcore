
function WheatherFactory($http) {

    var loadWheatherAsync = function () {
        var _data = wheather.data;
        _data.isLoading = true;
        return $http.get('api/weather/5').then(function (response) {
            var elements = response.data;
            for (var i = 0; i < elements.length; i++) {
                _data.weatherForecasts.push(elements[i]);
            }
            _data.isLoading = false;
        });
    }

    var wheather = {
        data: {
            weatherForecasts: [],
            isLoading: false
        },
        loadWheatherAsync: loadWheatherAsync
    };

    return wheather;
}
var wheather = angular.module('ms.experience.wheather');
wheather.factory('WheatherFactory', ['$http', WheatherFactory]);