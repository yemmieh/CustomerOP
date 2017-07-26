var myApp = angular.module("MyApp", []);
myApp.controller("NamesController", function ($scope) {
    $scope.names = [{ name: "oyeyemi", sex: "male", country: "nigeria", occupation: "web developer" },
                     { name: "olamide", sex: "male", country: "USA", occupation: "student" },
                    { name: "adebola", sex: "female", country: "sudan", occupation: "doctor" }, ];
})