
function MeteoController(meteoFactory) {
    var vm = this;
    vm.data = meteoFactory.data;
    meteoFactory.loadMeteoAsync();
    return vm;
}

var meteo = angular.module('ms.experience.wheather');
meteo.component('meteo',
    {
        controller: ['WheatherFactory', MeteoController],
        templateUrl: 'App/wheather/wheather.html'
    });
