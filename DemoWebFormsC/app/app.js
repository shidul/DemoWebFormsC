var app = angular.module('emp', []);

app.controller("empCtrl", ['$scope', '$http', function($scope, $http) {
    $scope.id = "10025";

    //var parameter = JSON.stringify({ type: "user", username: user_email, password: user_password });
    $http.post('http://localhost:49304/WebService1.asmx/getEmployee').
    success(function (data) {
        // this callback will be called asynchronously
        // when the response is available

        console.log(data);

        var x = JSON.parse(data);
        console.log(x);
    }).
      error(function (data) {
          // called asynchronously if an error occurs
          // or server returns response with an error status.
      });
}]);