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
            url: '/login/:username',
            templateUrl: 'Partials/pages/login.html',
            controller: 'LoginController',
            controllerAs: 'loginCtrl'
        };

        const billsState = {
            url: '/bills',
            templateUrl: 'Partials/pages/bills.html'
        };

        const contractsState = {
            url: '/contracts',
            templateUrl: 'Partials/pages/contracts.html'
        };

        const reportsState = {
            url: '/reports',
            templateUrl: 'Partials/pages/reports.html'
        };

        const dashboardState = {
            url: '/dashboard',
            templateUrl: 'Partials/pages/dashboard.html'
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