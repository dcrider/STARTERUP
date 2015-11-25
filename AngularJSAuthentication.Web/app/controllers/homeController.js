'use strict';
app.controller('homeController', ['$scope', '$http', 'categoryService', function ($scope, $http, categoryService) {

    $scope.categories = [];




    $scope.init = function () {
        categoryService.getCategories().then(function (results) {

            $scope.categories = results.data;

        }, function (error) {
            //alert(error.data.message);
        });
    }

    

}]);