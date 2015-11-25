'use strict';
app.factory('leaflyService', ['$http', '$q', 'localStorageService', 'ngAuthSettings', function ($http, $q, localStorageService, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri + "api/categories";
    console.log(serviceBase);
    var factory = {};






    return factory;
}]);