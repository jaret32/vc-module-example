angular.module('example')
    .factory('example.webApi', ['$resource', function ($resource) {
        return $resource('api/Example');
}]);
