(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('ReportController', reportController);

    reportController.$inject = ['$scope', '$state', '$http'];

    function reportController($scope, $state, $http) {
        var vm = this;

        vm.data = {
            customerId: '' || $state.params.customerId,
            bills: '',
            reports: '',
            contracts: ''
        };

        vm.getReports = function () {
            $http.get(environment.apiUrl + "/reports/all/" + vm.data.customerId)
                .then(function (result) {
                    vm.data.reports = result.data;
                    console.log(result.data);
                });
        };

        vm.getReports();
    }

})(window.angular);