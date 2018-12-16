﻿myApp.controller("CapcqbhJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.SearchObject = {
            MaCapCQBH: '',
            TenCapCQBH:'',
            GhiChu: '',
            PageIndex: 1,
            PageSize: 10
        };
        $scope.model = {
            Id: 0,
            MaCapCqbh: 0,
            TenCapCqbh: '',
            GhiChu:''
        };

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/CapCQBH/getAllSearch',
                data: JSON.stringify($scope.SearchObject),
                dataType: "json"

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $scope.datagrid = response.data;

            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi


            });

        }

        ngInit = function () {
            GetData();
        }
        ngInit();


        $scope.onCreate = function(){
            $http({
                method: 'POST',
                url: '/CapCqbh/Create',
                data: JSON.stringify($scope.model),
                dataType: "json"

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $scope.model = response.data;

            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
            });
        }

    });