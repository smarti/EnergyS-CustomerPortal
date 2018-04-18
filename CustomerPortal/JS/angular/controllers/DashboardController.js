(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('DashboardController', dashboardController);

    dashboardController.$inject = ['$scope', '$state', '$http'];

    function dashboardController($scope, $state, $http) {
        var vm = this;

        vm.data = {
            customerId: '' || $state.params.customerId
        };
    }

})(window.angular);