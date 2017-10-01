
function WeatherController(weatherFactory) {
    const vm = this;
    vm.data = weatherFactory.data;
    weatherFactory.loadWeatherAsync();
    return vm;
}

import weather from './weather.module';
import WeatherFactory from './weather.factory';
import './weather.css';

const name = 'weather';
weather.component(name,
    {
        controller: [WeatherFactory, WeatherController],
        template: require('./weather.html')
    });

export default name;