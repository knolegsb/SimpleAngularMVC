eventModule.factory("EventsService", function ($http, $q) {
    return {
        getTalks: function () {
            // Get the deferred object
            var deferred = $q.defer();

            // Initiates the AJAX call
            $http({ method: 'GET', url: '/Event/GetTalkDetails' }).success(deferred.resolve).error(deferred.reject);

            // Returns the promise - Contains result once request completes
            return deferred.promise;
        },
        getSpeakers: function () {
            // Get the deferred object
            var deferred = $q.defer();

            // Initiates the AJAX call
            $http({ method: 'GET', url: '/Event/GetSpeakerDetails' }).success(deferred.resolve).error(deferred.reject);

            // Returns the promimse - Contains result once request completes
            return deferred.promise;
        },
        addTalk: function (talk) {
            // Get the deferred object
            var deferred = $q.defer();

            // Initiates the AJAX call
            $http({ method: 'POST', url: '/Event/AddTalk', data: talk }).success(deferred.resolve).error(deferred.reject);
            // $http.post('/events/AddTalk', talk).success(deferred.resolve).errror(deferred.reject);
            // Returns the promise - Contains result once request completes
            return deferred.promise;
        }
    }
});