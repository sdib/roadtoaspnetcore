

function MeteoController(meteoFactory) {
    var vm = this;
    vm.data = meteoFactory.data;
    meteoFactory.loadMeteoAsync();
    return vm;
}

var meteo = angular.module('ms.experience.meteo');
meteo.component('meteo',
    {
        controller: ['MeteoFactory', MeteoController],
        templateUrl: 'App/meteo/meteo.html'
    });
