
function WheatherFactory($http) {

    const loadWheatherAsync = function () {
        const _data = wheather.data;
        _data.isLoading = true;
        return $http.get('api/weather/5').then(function (response) {
            var elements = response.data;
            // for (var i = 0; i < elements.length; i++) {
            //     _data.weatherForecasts.push(elements[i]);
                _data.weatherForecasts.push(...elements);
            // }
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

import wheather from './wheather.module';
const name = 'WheatherFactory';
wheather.factory(name, ['$http', WheatherFactory]);

export default name;