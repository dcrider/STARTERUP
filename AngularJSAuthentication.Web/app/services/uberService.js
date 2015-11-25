'use strict';
app.factory('uberService', ['$http', '$q', 'localStorageService', 'ngAuthSettings', function ($http, $q, localStorageService, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri + "api/categories";
    console.log(serviceBase);
    var factory = {};






    return factory;
}]);