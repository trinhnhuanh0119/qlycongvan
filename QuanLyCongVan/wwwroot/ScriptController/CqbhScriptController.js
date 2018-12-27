myApp.controller("CqbhJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.SearchObject = {
            MaCQBH: '',
            TenCQBH: '',
            DiaChi: '',
            DienThoai: '',
            Fax:'',
            Email:'',
            GhiChu: '',
            TenVietTat: '',
            MaCapCQBH:'',
            PageIndex: 1,
            PageSize: 10
        };
        $scope.model = {
            Id: 0,
            MaCqbh: 0,
            TenCqbh: '',
            DiaChi: '',
            DienThoai: '',
            Fax: '',
            Email: '',
            GhiChu: '',
            TenVietTat: '',
            MaCapCqbh:0
        };

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/CQBH/getAllSearch',
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
            $http({
                method: 'POST',
                url: '/Cqbh/Create',
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
        $scope.onEdit = function (id) {
            $http({
                method: 'GET',
                url: '/Cqbh/Edit',
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
        $scope.show = function () {
            $scope.model = {};
            $("#confirm-status").modal('show');
        }
    });