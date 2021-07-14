angular.module('example')
    .controller('example.helloWorldController', ['$scope', 'example.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = 'ExampleModule';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = 'example.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
