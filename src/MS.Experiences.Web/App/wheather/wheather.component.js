
function WheatherController(meteoFactory) {
    var vm = this;
    vm.data = meteoFactory.data;
    meteoFactory.loadMeteoAsync();
    return vm;
}

var meteo = angular.module('ms.experience.wheather');
meteo.component('wheather',
    {
        controller: ['WheatherFactory', WheatherController],
        templateUrl: 'App/wheather/wheather.html'
    });
