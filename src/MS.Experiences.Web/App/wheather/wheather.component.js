
function WheatherController(wheatherFactory) {
    var vm = this;
    vm.data = wheatherFactory.data;
    wheatherFactory.loadWheatherAsync();
    return vm;
}

var meteo = angular.module('ms.experience.wheather');
meteo.component('wheather',
    {
        controller: ['WheatherFactory', WheatherController],
        templateUrl: 'App/wheather/wheather.html'
    });
