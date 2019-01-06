myApp.controller("NguoiDungJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.SearchObject = {
            TenTaiKhoan: '',
            MatKhau:'',
            KichHoat: -1,
            MaNhanSu:'',
            PageIndex: 1,
            PageSize: 10
        };
        $scope.model = {
            Id: 0,
            TenTaiKhoan:'',
            MatKhau: '',
            KichHoat: true,
            MaNhanSu:0
        };

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/NguoiDung/getAllSearch',
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
                url: '/NguoiDung/Create',
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
                url: '/NguoiDung/Edit',
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