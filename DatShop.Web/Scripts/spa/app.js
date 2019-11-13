
var myApp = angular.module('myModule', []);
//controller
//function myController0($scope, Validator) {
    
//    //$scope.message = "this is my controller0";
//}
//myApp.controller("myController0", myController0);
////function myController1($scope) {

////    //$scope.message = "this is my controller1";
////}

////function myController2($scope) {

////    //$scope.message = "this is my controller2";
////}

////myApp.controller("myController1", myController1);
////myApp.controller("myController2", myController2);
//////myApp.$inject = ['$scope'];
////service

myApp.controller("schoolController", schoolController);
myApp.service("Validator", Validator);

function schoolController($scope, Validator) {
    //Validator.checkNumber(2);
    $scope.message = Validator.checkNumber(2);
}
schoolController.$inject = ['$scope', 'Validator'];

function Validator($window) {
    //return 
    //{
    //    checkNumber: checkNumber
    //}
    this.checkNumber = checkNumber;

    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'this is even';
        }
        else
            return 'this is odd';
    }
}
