
var myApp = angular.module('myApp', []);
myApp.directive('myUser', function () {
    return {
        template: 'Name: {{myCutText(user.name) }} Address: {{myCutText(user.address)}}'
    };
});
myApp.service('hexafy', function () {
    this.myFunc = function (x) {
        return x.toString(16) + "aaaa";
    }
});

myApp.filter('cutText', function () {

    // In the return function, we must pass in a single parameter which will be the data we will work on.
    // We have the ability to support multiple other parameters that can be passed into the filter optionally
    return function (input, optional1, optional2) {
        var output;
        output = input.substring(3);
        return output;
    }
});
myApp.controller('manageCtrl', ['$scope', '$http', 'hexafy', function ($scope, $http, hexafy) {  
    $http.get("/Home/Search", { params: { text: "a"} }).success(function (res) {
        $scope.segments = res.Segments;
    }).error(function () {
        alert('error');
        });
    $scope.myCutText = function (text) {
        return text.substring(4);
    }
    $scope.myNumber = hexafy.myFunc(9);
    $scope.users = [
        { Name: 'Nhan', Age: 26 },
        { Name: 'Josh', Age: 24 },
        { Name: 'Len', Age: 22 }
    ];
    $scope.user = {
        name: 'Naomi',
        address: '1600 Amphitheatre'
    };
    $scope.search = function () {
        $http.get("/Home/Search", { params: { text: $scope.text } }).success(function (res) {
            $scope.segments = res.Segments;
        }).error(function () {
            alert('error');
        });

    }
    //$scope.search = function () {
    //    $http.get("/Home/Search", { params: { searchText: $scope.searchText } }).success(function (res) {

    //        $scope.segments = res.Segments;



    //    }).error(function () {
    //        alert('error');
    //    });    }
  
    

}]);
myApp.controller('manageCtrl1', ['$scope', '$http', function ($scope, $http) {

    
    $scope.user = {
        name: 'nhan',
        address: 'abc'
    };


}]);


