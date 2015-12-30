//var eventModule = angular.module("eventModule", ['ngRoute'])
//.config(function ($routeProvider) {
//    $routeProvider.
//        when('/Talks', {
//            templateUrl: '/Templates/Talk.html',
//            controller: 'eventController'
//        }).
//        when('/Speakers', {
//            templateUrl: '/Templates/Speaker.html',
//            controller: 'speakerController'
//        }).
//        otherwise({
//            redirectTo: '/Event'
//        });
//});

//var eventModule = angular.module("eventModule", [])
//.config(function ($routeProvider, $locationProvider) {
//    $routeProvider.
//        when('/Event/Talks', {
//            templateUrl: '/Templates/Talk.html',
//            controller: 'eventController'
//        });
//    $routeProvider.when('/Event/Speakers', {
//            templateUrl: '/Templates/Speaker.html',
//            controller: 'speakerController'
//        }).
//    $routeProvider.when('/Event/AddTalk', {
//            templateUrl: '/Templates/AddTalk.html',
//            controller: 'talkController'
//        });
//    $locationProvider.html5Mode(true);
//});

var eventModule = angular.module("eventModule", []).config(function ($routeProvider, $locationProvider) {
    //Path - it should be same as href link
    $routeProvider.when('/Event/Talks', { templateUrl: '/Templates/Talk.html', controller: 'eventController' });
    $routeProvider.when('/Event/Speakers', { templateUrl: '/Templates/Speaker.html', controller: 'speakerController' });
    $routeProvider.when('/Event/AddTalk', { templateUrl: '/Templates/AddTalk.html', controller: 'talkController' });
    $locationProvider.html5Mode(true);
});