﻿
var myApp = angular.module('myApp', []);

myApp.controller('manageCtrl', ['$scope', '$http', function ($scope, $http) {
  
    $http.get("/Home/Search").success(function (res) {

        $scope.segments = res.Segments;



    }).error(function () {
        alert('error');
    });
    

}]);

