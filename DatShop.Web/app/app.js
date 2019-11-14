/// <reference path="../bower_components/angular/angular.js" />

(function () {
    angular.module('DatShop', ['ui.router']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();
//    //Thay the doan tren bang code ben duoi
//angular.module('datshop', ['datshop.products','ui.router'])
//    .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {       

//        $stateProvider
//            .state('home', {
//                url: "/admin",
//                templateurl: "/app/components/home/homeView.html",                
//                controller: "homeController"
//            });

//        //Tra ve admin neu khong phai truong hop nao
//        $urlRouterProvider.otherwise('/admin'); 
        
               
//    }]);
    
console.log('dateshop routes');
