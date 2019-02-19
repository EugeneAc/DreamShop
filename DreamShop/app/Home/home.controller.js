
dreamShopApp.controller('HomeController', ['$scope', function ($scope) {
    $scope.message = "Все категории";
    $scope.treeModel = {};

    $scope.GetCategoryTree = function (user) {
        $http({
            method: 'GET',
            url: '/api/shop/GetCategoryTree'
        }).then(function (response) {
            $scope.treeModel = response.data;
        }, function (error) {
            console.log(error);
        });
    };
}]);
