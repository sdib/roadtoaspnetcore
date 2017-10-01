
function WeatherFactory($http) {

    const loadWeatherAsync = function () {
        const _data = weather.data;
        _data.isLoading = true;
        return $http.get('api/weather/5').then(function (response) {
            var elements = response.data;
            _data.weatherForecasts.push(...elements);
            _data.isLoading = false;
        });
    }

    const weather = {
        data: {
            weatherForecasts: [],
            isLoading: false
        },
        loadWeatherAsync: loadWeatherAsync
    };

    return weather;
}

import weather from './weather.module';

const name = 'WeatherFactory';
weather.factory(name, ['$http', WeatherFactory]);

export default name;