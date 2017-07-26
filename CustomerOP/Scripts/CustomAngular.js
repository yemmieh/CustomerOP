//var myApp = angular.module("MyApp",[]);
//myApp.controller("CustomerController", function ($scope) {
//    $scope.customer= [{ FirstName: "oyeyemi", LastName: "male", country: "City", Country: "web developer" },
//                     { FirstName: "olamide", LastName: "male", country: "City", Country: "student" },
//                    { FirstName: "adebola", LastName: "female", country: "City", Country: "doctor" }, ];
//})
var CustomerApp = angular.module("CustomermerModule", []);
//CustomerApp.controller("CustomerController", function ($scope) {
//    $scope.names = [{ FirstName: "oyeyemi", LastName: "male", country: "City", Country: "web developer" },
//                     { FirstName: "olamide", LastName: "male", country: "City", Country: "student" },
//                    { FirstName: "adebola", LastName: "female", country: "City", Country: "doctor" }, ];
//})
CustomerApp.service("APIService", function ($http) {
    this.getSubs = function () {
        return $http.get("/api/values")
    }
});
CustomerApp.controller("CustomerController", function ($scope, APIService) {
    getAll();

    function getAll() {
        var servCall = APIService.getSubs();
        servCall.then(function (d) {
           // alert("cc");
            $scope.customer = d.data;
        }, function (error) {
            $log.error('Oops! Something went wrong while fetching the data.')
        })
    }
})

//var mainapp = angular.module("mainapp", []);
CustomerApp.config(function ($routeProvider) {
    $routeProvider
    .when('/',
    {
        controller: 'routecontroller',
        templateUrl: ''
    })
    .when('/Home/About',
    {
        controller: 'routecontroller',
        templateUrl: '/Home/About.cshtml'
    })
    .otherwise({
        redirectTo: '/'
    })
})