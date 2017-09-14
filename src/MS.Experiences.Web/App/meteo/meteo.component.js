
var meteo = angular.module('ms.experience.meteo', []);

function MeteoController($http) {
    var vm = this;

    vm.weatherForecasts = [];
    vm.isLoading = true;
    $http.get('api/weather/5').then(function (response) {
        var elements = response.data;
        for (var i = 0; i < elements.length; i++) {
            vm.weatherForecasts.push(elements[i]);
        }
        vm.isLoading = false;
    });

    return vm;
}

meteo.component('meteo',
    {
        controller: ['$http', MeteoController],
        templateUrl: 'App/meteo/meteo.html'
    });