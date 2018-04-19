(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('ReportController', reportController);

    reportController.$inject = ['$scope', '$state', '$http'];

    function reportController($scope, $state, $http) {
        var vm = this;

        vm.forms = {};
        vm.currentForm = 'showReports';

        vm.data = {
            customerId: '' || $state.params.customerId,
            bills: '',
            reports: '',
            contracts: '',
            reportDescription: ''
        };

        vm.getReports = function () {
            $http.get(environment.apiUrl + "reports/all/" + vm.data.customerId)
                .then(function (result) {
                    vm.data.reports = result.data;
                    console.log(result.data);
                });
        };

        vm.addReport = function () {
            $http({
                method: 'post',
                url: environment.apiUrl + 'reports/add/' + vm.data.customerId,
                data: {
                    Description: vm.data.reportDescription
                }
            }).then(function (result) {
                console.log(result.data);
            });

        };

        vm.showForm = function (formName) {
            switch (formName) {
                case 'showReports':
                case 'addReport':
                    vm.currentForm = formName;
                    break;
                default:
                    throw new TypeError('Expected form name to be "showReports" or "addReport". ' + formName);
            }
        };

        vm.getReports();
    }

})(window.angular);