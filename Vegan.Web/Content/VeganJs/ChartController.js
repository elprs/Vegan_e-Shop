﻿(function myfunction() {
    var ChartProject = angular.module("ChartProject", []);
    var ordersURL = "https://localhost:44332/api/Orders";
    var ChartController = function ($scope, $http) {
        var GetData = function () {
            $http.get(ordersURL)
                .then(function (response) {
                    console.log(response.data[0]);
                    for (var i = 0; i < response.length - 1; i++) {
                        $scope.Orders = response.data;  // sosto??
                        /*  $scope.Orders += response.data[0];*/
                        console.log(response);
                    }
                })
        }
        GetData();
    };

  ChartProject.controller("ChartController", ChartController);

})();

    //                    $scope.Care = response.data[0];
    //                    $scope.FoodHerbs = response.data[1];
    //                    $scope.Homes = response.data[2];
    //                    $scope.Supplements = response.data[3];
    //                    $scope.AllProducts = $scope.Care.concat($scope.FoodHerbs).concat($scope.Homes).concat($scope.Supplements);

    //                    //autocomplete
    //                    autocomplete(document.getElementById("searchlight"), AutocompleteItems($scope.AllProducts));

    //                    //search-btn
    //                    document.getElementById("searchbutton").addEventListener("click", function () {
    //                        var text = document.getElementById("searchlight").value;
    //                        var products = [];

    //                        for (var i in $scope.AllProducts) {

    //                            if (text == $scope.AllProducts[i].Title) {
    //                                if ($scope.AllProducts[i].SubCategory == "FaceCream") {
    //                                    var controller = $scope.AllProducts[i].SubCategory + "s";
    //                                }
    //                                else {
    //                                    var controller = $scope.AllProducts[i].SubCategory;
    //                                }
    //                                var detailsActionMethod = "Details" + $scope.AllProducts[i].SubCategory;
    //                                var id = $scope.AllProducts[i].Id;
    //                                var url = "/" + controller + "/" + detailsActionMethod + "?" + "productId=" + id;
    //                                window.location.href = url;
    //                            }
    //                        }

    //                    });
    //                }, function myError(response) {
    //                    console.log(response);
    //                });


                                                        //        }

                                                        //        GetData();
                                                        //    };

                                                        //    ChartProject.controller("ChartController", ChartController);
