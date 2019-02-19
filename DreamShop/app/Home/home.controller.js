
dreamShopApp.controller('HomeController', ['$scope', '$http', function ($scope, $http) {
	$scope.message = "Все категории";
    $scope.treeModel = {};

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

    $scope.treeOptions = {
        nodeChildren: "subCategories",
        dirSelectable: true
    };

    
}]);
