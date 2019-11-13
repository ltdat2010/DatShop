//(function () {
    //angular.module('datshop', ['products.module','datshop.common']);
    //angular.config(config);

    //config.$inject = ['$stateProvider', '$urlRouterProvider'];

    //function config($stateProvider, $urlRouterProvider) {
    //    $stateProvider.state('home', {
    //        url: "/admin",
    //        templateurl: "/app/components/homeView.html",
    //        controller: "homeController"
    //    });
    //    //Tra ve admin neu khong phai truong hop nao
    //    $urlRouterProvider.otherwise('/admin');
    //}
//});
    //Thay the doan tren bang code ben duoi
angular.module('datshop', ['datshop.products', 'datshop.common'])
    .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        //Tra ve admin neu khong phai truong hop nao
        $urlRouterProvider.otherwise('/admin'); 

        $stateProvider
            .state('home', {
                url: "/admin",
                templateurl: "app/components/home/homeView.html",
                controller: "homeController"
            });
            
               
    }])();
    
console.log('dateshop routes');
