(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('BillController', billController);

    billController.$inject = ['$scope', '$state', '$http'];

    function billController($scope, $state, $http) {
        var vm = this;

        vm.data = {
            customerId: '' || $state.params.customerId,
            bills: ''
        };

        vm.getBills = function () {
            $http.get(environment.apiUrl + vm.data.customerId + "/bills")
                .then(function (result) {
                    vm.data.bills = result.data;
                    console.log(result.data);
                });
        };

        vm.getBills();
    }

})(window.angular);