'use strict';
app.factory('categoryService', ['$http', '$q', 'localStorageService', 'ngAuthSettings', function ($http, $q, localStorageService, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri + "api/categories";
    console.log(serviceBase);
    var factory = {};

    var _call = function (url, data, method, cacheID) {
        var deferred = q.defer();
        if (typeof data == 'undefined') data = null;
        if (typeof method == 'undefined') method = 'GET';

        $http({
            url: url,
            method: method,
            data: data
        }).
        success(function (response) {
            if (typeof cacheID !== 'undefined' && cacheID !== null) {
                localStorageService.set(cacheID, response);
            }

            deferred.resolve(response);
        }).
        error(function (err, status) {
            deferred.reject(err);
        });

        return deferred.promise;
    }

    var _getAllCategories = function () {
        var url = serviceBase + 'all/';
        return _call(url, data, method);
    }



    factory.getAllCategories = _getAllCategories;

    return factory;
}]);