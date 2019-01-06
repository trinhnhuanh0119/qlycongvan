﻿myApp.controller("VanBanJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.idremove = 0;
        $scope.SearchObject = {
            VBDiDen: -1,
            MaLoaiVB: '',
            MaCQBH: '',
            SoVB: '',
            SoDen: '',
            NgayDen: '',
            DoMat: '',
            DoKhan: '',
            TrichYeu: '',
            NoiNhan: '',
            NgayKy: '',
            NguoiKy: '',
            KetQuaXuLy: -1,
            FileDinhKem:-1,
            HanXuLy: '',
            PageIndex: 1,
            PageSize: 10
        };

        $scope.model = {
            Id: 0,
            VbdiDen: true,
            MaLoaiVb: 0,
            MaCqbh: 0,
            SoVb: '',
            SoDen: '',
            NgayDen: '',
            DoMat: '',
            DoKhan: '',
            TrichYeu:'',
            NoiNhan: '',
            NgayKy: '',
            NguoiKy: '',
            KetQuaXuLy: true,
            FileDinhKem: true,
            HanXuLy:''
        }

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/VanBan/getAllSearch',
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

        $scope.onCreate = function () {
            if ($scope.model.id == '' || $scope.model.id == null || $scope.model.id == 0) {
            $http({
                method: 'POST',
                url: '/VanBan/Create',
                data: JSON.stringify($scope.model),
                dataType: "json"

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $("#confirm-status").modal('hide');
                GetData();
            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
                    });
            } else {
                $http({
                    method: 'POST',
                    url: '/VanBan/Update',
                    data: JSON.stringify($scope.model),
                    dataType: "json"

                }).then(function successCallback(response) {
                    // Hàm thực thi khi chạy đúng và trả về kết quả
                    console.log(response);
                    $("#confirm-status").modal('hide');
                    GetData();
                }, function errorCallback(response) {
                    // Hàm thực thi khi xảy ra lỗi
                });
            }
        }
        $scope.onEdit = function (id) {
            $http({
                method: 'GET',
                url: '/VanBan/Edit',
                params: { id: id}

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $("#confirm-status").modal('show');
                $scope.model = response.data;
                

            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
            });
        }

        $scope.onDelete = function (id) {
            $http({
                method: 'Post',
                url: '/VanBan/Delete',
                params: { id: id }
            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                $("#notifycal").modal('hide');
                GetData();
            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
            });
        }

        $scope.show = function () {
            $scope.model = {};
            $("#confirm-status").modal('show');
        }

        $scope.confirmdelete = function (id) {
            $scope.idremove = id;
            $("#notifycal").modal('show');
        }
    });