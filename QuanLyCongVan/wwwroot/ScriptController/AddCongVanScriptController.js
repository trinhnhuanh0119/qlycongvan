﻿myApp.controller("AddCongVanJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {
        $scope.datagrid = [];
        $scope.idremove = 0;
        $scope.listCqbh = [];
        $scope.currentPage = 1;
        $scope.PageSize = 5;
        $scope.pageCount = 0;
        $scope.SearchObject = {
            SoVB: '',
            MaLoaiVB: '',
            MaCQBH: '',
            TrichYeu: '',
            NoiNhan: '',
            PageIndex: $scope.currentPage,
            PageSize: 5
        };
        $scope.model = {
            Id: 0,
            SoVB: '',
            MaLoaiVB: 0,
            MaCQBH: 0,
            TrichYeu: '',
            NoiNhan: ''
        };

        //hàm gọi event next trang
        $scope.pagechaned = function () {
            $scope.SearchObject.PageIndex = $scope.currentPage;
            GetData();
        }
        //hàm gọi event search
        $scope.sort = function () {
            GetData();
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
                //hàm thực hiện phân trang
                if (response.data.length > 0) {
                    $scope.pageCount = response.data[0].tongSo;
                } else {
                    $scope.pageCount = 0;
                }
            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi


            });

        }
        var GetDropDowns = function () {
            $http({
                method: 'GET',
                url: '/Cqbh/GetDropDowns'

            }).then(function successCallback(response) {
                $scope.listCqbh = response.data;

            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
                });
            $http({
                method: 'GET',
                url: '/LoaiVanBan/GetDropDowns'

            }).then(function successCallback(response) {
                $scope.listLoaiVanBan = response.data;

            }, function errorCallback(response) {
                // Hàm thực thi khi xảy ra lỗi
            });
        }
        ngInit = function () {
            GetData();
            GetDropDowns();
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
                    $.notify("Thêm thành công!", "success");
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
                params: { id: id }

            }).then(function successCallback(response) {
                // Hàm thực thi khi chạy đúng và trả về kết quả
                console.log(response);
                $("#confirm-status").modal('show');
                $.notify("Sửa thành công!", "success");
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
                $.notify("Xóa thành công!", "success");
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

    }
)