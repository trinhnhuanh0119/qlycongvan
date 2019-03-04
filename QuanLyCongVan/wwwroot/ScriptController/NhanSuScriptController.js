﻿myApp.controller("NhanSuJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.idremove = 0;
        $scope.currentPage = 1;
        $scope.PageSize = 5;
        $scope.pageCount = 0;
        $scope.SearchObject = {
            MaNhanSu: '',
            Ten:'',
            GioiTinh:-1,
            NgaySinh: '',
            Anh: '',
            NgayVaoNganh: '',
            DiaChiNR: '',
            DiaChiCQ: '',
            DienThoai: '',
            MaPhong:'',
            PageIndex: $scope.currentPage,
            PageSize: 5
        };

        $scope.model={
            Id: 0,
            MaNhanSu: 0,
            Ten: '',
            GioiTinh: true,
            NgaySinh:'',
            Anh: '',
            NgayVaoNganh: '',
            DiaChiNR: '',
            DiaChiCQ: '',
            DienThoai: '',
            MaPhong: 0
        }

        //hàm gọi event next trang
        $scope.pagechaned = function () {
            $scope.SearchObject.PageIndex = $scope.currentPage;
            GetData();
        }

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/NhanSu/getAllSearch',
                data: JSON.stringify($scope.SearchObject),
                dataType: "json"

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $scope.datagrid = response.data;
                //hàm thực hiện phân trang
                if (response.data.lenght > 0) {
                    $scope.pageCount = response.data[0].TongSo;
                } else {
                    $scope.pageCount = 0;
                }
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
                url: '/NhanSu/Create',
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
                    url: '/NhanSu/Update',
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
                url: '/NhanSu/Edit',
                params: { id: id }

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
                url: '/NhanSu/Delete',
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