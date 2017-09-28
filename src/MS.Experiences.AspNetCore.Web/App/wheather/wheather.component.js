


function WheatherController(wheatherFactory) {
    var vm = this;
    vm.data = wheatherFactory.data;
    wheatherFactory.loadWheatherAsync();
    return vm;
}

import wheather from './wheather.module';
import './wheather.css';
import wheatherFactory from './wheather.factory';
wheather.component('wheather',
    {
        controller: [wheatherFactory, WheatherController],
        template: require('./wheather.html')
    });
