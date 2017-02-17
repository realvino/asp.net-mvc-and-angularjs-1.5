var mainApp = angular.module("mainApp", []);

mainApp.controller('productController', function ($scope, $http) {
    var vm = this;
    $scope.product = {};
    $scope.dis = true;
    $http.get('/Angular/GetProducts')
    .success(function (result) {
        $scope.products = result;
        console.log($scope.products);
    })
    .error(function (data) {
        console.log(data);
    })
    $scope.addProduct = function(input)
    {
        console.log(input);     
        $.ajax({
            type: "POST",
            url: "/Angular/addProduct",
            dataType: "json",
            processData: false,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({
                ProductCode: input.ProductCode,
                Productname: input.Productname,
                Price: input.Price
            }),
            success: function (resp) {
                console.log(resp);
                $scope.$apply(function () {
                    $scope.products = resp;
                    $scope.product = null;
                });
            }
        });
    }
    $scope.submitForm = function (isValid) {

        if (isValid) {
            $scope.dis = false;
        }

    };

});