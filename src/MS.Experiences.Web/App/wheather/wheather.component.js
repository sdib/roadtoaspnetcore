
function WheatherController(wheatherFactory) {
    var vm = this;
    vm.data = wheatherFactory.data;
    wheatherFactory.loadWheatherAsync();
    return vm;
}

var wheather = angular.module('ms.experience.wheather');
wheather.component('wheather',
    {
        controller: ['WheatherFactory', WheatherController],
        templateUrl: 'App/wheather/wheather.html'
    });
