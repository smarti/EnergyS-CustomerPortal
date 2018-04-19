(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('ContractController', contractController);

    contractController.$inject = ['$scope', '$state', '$http'];

    function contractController($scope, $state, $http) {
        var vm = this;

        vm.data = {
            customerId: '' || $state.params.customerId,
            contracts: ''
        };

        vm.getContracts = function() {
            $http.get(environment.apiUrl + "/contracts/all/" + vm.data.customerId)
                .then(function(result) {
                    vm.data.contracts = result.data;
                    console.log(result.data);
                });
        };

        vm.getContracts();
    }

})(window.angular);