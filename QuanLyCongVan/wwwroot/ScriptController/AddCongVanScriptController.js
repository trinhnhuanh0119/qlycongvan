myApp.controller("AddCongVan",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {
        $scope.show = function () {
            $scope.model = {};
            $("#confirm-status").modal('show');
        }
    });