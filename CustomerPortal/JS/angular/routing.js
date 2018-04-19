(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .config(configRouting);

    configRouting.$inject = [
        '$stateProvider',
        '$urlRouterProvider'
    ];

    function configRouting($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise('/login/');

        const loginState = {
            url: '/login/:customerId',
            templateUrl: 'Partials/pages/login.html',
            controller: 'LoginController',
            controllerAs: 'loginCtrl'
        };

        const billsState = {
            url: '/bills/:customerId',
            templateUrl: 'Partials/pages/bills.html'
        };

        const contractsState = {
            url: '/contracts/:customerId',
            templateUrl: 'Partials/pages/contracts.html',
            controller: 'ContractController',
            controllerAs: 'contractCtrl'
        };

        const reportsState = {
            url: '/reports/:customerId',
            templateUrl: 'Partials/pages/reports.html'
        };

        const dashboardState = {
            url: '/dashboard/:customerId',
            templateUrl: 'Partials/pages/dashboard.html',
            controller: 'DashboardController',
            controllerAs: 'dashboardCtrl'
        };

        $stateProvider
            .state('login', loginState)
            .state('bills', billsState)
            .state('contracts', contractsState)
            .state('reports', reportsState)
            .state('dashboard', dashboardState)
            ;
    }

})(window.angular);