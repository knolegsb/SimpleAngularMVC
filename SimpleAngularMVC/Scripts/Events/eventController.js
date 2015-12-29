//eventModule.controller("eventController", function ($scope, InitialLoadService, EventsService) {
//    $scope.talks = InitialLoadService.talks;
//    EventsService.getTalks().then(function (talks) { $scope.talks = talks }, function () {
//        alert('error while fetching talks from server')
//    })
//});

eventModule.controller("eventController", function ($scope, EventsService) {
    //$scope.talks = InitialLoadService.talks;
    EventsService.getTalks().then(function (talks) { $scope.talks = talks }, function () {
        alert('error while fetching talks from server')
    })
});