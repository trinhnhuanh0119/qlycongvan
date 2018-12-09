myApp.controller("VanBanJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
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

    });