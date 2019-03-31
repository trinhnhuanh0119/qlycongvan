myApp.controller("NguoiDungJS",
    function ($location, $scope, $routeParams, $http, $window, $timeout) {

        $scope.datagrid = [];
        $scope.idremove = 0;
        $scope.currentPage = 1;
        $scope.listNS = [];
        $scope.PageSize = 5;
        $scope.pageCount = 0;
        $scope.SearchObject = {
            TenTaiKhoan: '',
            MatKhau:'',
            KichHoat: -1,
            MaNhanSu:'',
            PageIndex: $scope.currentPage,
            PageSize: 5
        };
        $scope.model = {
            Id: 0,
            TenTaiKhoan:'',
            MatKhau: '',
            KichHoat: true,
            MaNhanSu:0
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

        $scope.export = function () {
            $http({
                method: 'POST',
                url: '/NguoiDung/ExportExel',
                data: '',
                dataType: ""
            }).then(function successCallback(response) {
                $("#downloadfile").attr('src', response.data)
            },
                function errorCallback(response) {
                    // Hàm thực thi khi xảy ra lỗi
                });
        }

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
                url: '/NhanSu/GetDropDowns'

            }).then(function successCallback(response) {
                $scope.listNS = response.data;

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
            //$http({
            //    method: 'POST',
            //    url: '/NguoiDung/Create',
            //    data: JSON.stringify($scope.model),
            //    dataType: "json" //})
                $http.post('/NguoiDung/Create', JSON.stringify($scope.model)).then(function successCallback(response) {
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
                    url: '/NguoiDung/Update',
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
                url: '/NguoiDung/Edit',
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
                url: '/NguoiDung/Delete',
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
    });