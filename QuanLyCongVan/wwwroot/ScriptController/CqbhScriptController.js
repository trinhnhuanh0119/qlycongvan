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

    });