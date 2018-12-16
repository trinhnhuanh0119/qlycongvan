myApp.controller("PhongBanJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.SearchObject = {
            MaPhong: '',
            TenPhong:'',
            DienThoai: '',
            Fax: '',
            MaNhanSu:'',
            PageIndex: 1,
            PageSize: 10
        };

        $scope.model = {
            Id: 0,
            MaPhong: 0,
            TenPhong: '',
            DienThoai: '',
            Fax: '',
            MaNhanSu:0
        }

        var GetData = function () {
            $http({
                method: 'POST',
                url: '/PhongBan/getAllSearch',
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
                url: '/PhongBan/Create',
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