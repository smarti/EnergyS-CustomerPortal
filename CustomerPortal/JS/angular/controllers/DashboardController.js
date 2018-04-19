(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('DashboardController', dashboardController);

    dashboardController.$inject = ['$scope', '$state', '$http'];

    function dashboardController($scope, $state, $http) {
        var vm = this;

        vm.data = {
            customerId: '' || $state.params.customerId,
            bills: '',
            reports: '',
            contracts: '',
            meterReadings: ''
        };

        vm.getMeterReadings = function () {
            $http.get(environment.apiUrl + vm.data.customerId + "/meterReadings")
                .then(function (result) {
                    vm.data.meterReadings = result.data;
                    console.log(result.data);
                });
        };

        vm.getBills = function () {
            $http.get(environment.apiUrl + vm.data.customerId + "/bills")
                .then(function (result) {
                    vm.data.bills = result.data;
                    console.log(result.data);
                });
        };

        vm.getReports = function () {
            $http.get(environment.apiUrl + "/reports/all/" + vm.data.customerId)
                .then(function (result) {
                    vm.data.reports = result.data;
                    console.log(result.data);
                });
        };

        vm.getContracts = function () {
            $http.get(environment.apiUrl + "/contracts/all/" + vm.data.customerId)
                .then(function (result) {
                    vm.data.contracts = result.data;
                    console.log(result.data);
                });
        };

        vm.getMeterReadings();
        vm.getBills();
        vm.getReports();
        vm.getContracts();
    }

})(window.angular);