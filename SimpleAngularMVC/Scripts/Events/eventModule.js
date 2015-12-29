var eventModule = angular.module("eventModule", ['ngRoute'])
.config(function ($routeProvider) {
    $routeProvider.
        when('/Talks', {
            templateUrl: '/Templates/Talk.html',
            controller: 'eventController'
        }).
        when('/Speakers', {
            templateUrl: '/Templates/Speaker.html',
            controller: 'speakerController'
        }).
        otherwise({
            redirectTo: '/Event'
        });
});