(function () {
    angular.module('datshop.products', ['datshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateurl: "/app/components/products/productListView.html",
            controller: "productListController"
        })
            .state('product_add', {
                url: "/product_add",
                templateurl: "/app/components/products/productAddView.html",
                controller: "productAddController"
            });
    }
})();