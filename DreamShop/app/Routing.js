dreamShopApp.config(['$locationProvider', '$stateProvider', '$urlRouterProvider', '$urlMatcherFactoryProvider', '$compileProvider',
    function ($locationProvider, $stateProvider, $urlRouterProvider, $urlMatcherFactoryProvider, $compileProvider) {

        //console.log('Appt.Main is now running')
        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode({
                enabled: true,
                requireBase: true
            }).hashPrefix('!');
        };
        $urlMatcherFactoryProvider.strictMode(false);
        $compileProvider.debugInfoEnabled(false);

        $stateProvider
            .state('home',
                {
                    url: '/',
                    templateUrl: './views/home/home.html',
                    controller: 'HomeController'
                })
            .state('category',
                {
                    url: '/category',
                    templateUrl: './views/category/category.html',
                    controller: 'CategoryController'
                })
            .state('product',
                {
                    url: '/product',
                    templateUrl: './views/product/product.html',
                    controller: 'ProductController'
                });

        $urlRouterProvider.otherwise('/home');
    }]); 
