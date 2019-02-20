dreamShopApp.controller('HomeController', ['$scope', '$http', function ($scope, $http) {
    $scope.allCategories = "Все категории";
    $scope.titleProduct = "";
    $scope.titleCategory = "";
    $scope.treeModel = {};
    $scope.categoryProducts = {};
    $scope.chosenProduct = {};

    (function () {
        $http({
            method: 'GET',
            url: '/api/shop/GetCategoryTree'
        }).then(function (response) {
            $scope.treeModel = response.data;
        }, function (error) {
            console.log(error);
        });
    })();

    $scope.showSelected = function (node) {
        $scope.titleCategory = node.name;
        $http({
            method: 'GET',
            url: '/api/shop/GetCategoryProducts?CategoryId=' + node.id
        }).then(function (response) {
            $scope.categoryProducts = response.data;
        }, function (error) {
            console.log(error);
        });
    };

    $scope.getProduct = function (product) {
        $scope.titleProduct = product.name;
        $http({
            method: 'GET',
            url: '/api/shop/GetProduct?productId=' + product.id
        }).then(function (response) {
            $scope.chosenProduct = response.data;
        }, function (error) {
            console.log(error);
        });
    };

    $scope.treeOptions = {
        nodeChildren: "subCategories",
        dirSelectable: true
    };
}]);
