(function (angular) {
    "use strict";

    // Angular.module with second array argument to create a new app.
    angular
        .module('CustomerPortalApp', [
            'ui.router',
            'ui.bootstrap'
        ]);

    // Appends ng-app to the document and starts the application.
    angular.element(document).ready(function () {
        angular.bootstrap(window.document, ['CustomerPortalApp']);
    });

})(window.angular);
const environment = {
    production: false,
    apiUrl: 'http://localhost:60074/api/'
};
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
            templateUrl: 'Partials/pages/contracts.html'
        };

        const reportsState = {
            url: '/reports/:customerId',
            templateUrl: 'Partials/pages/reports.html'
        };

        const dashboardState = {
            url: '/dashboard/:customerId',
            templateUrl: 'Partials/pages/dashboard.html',
            controller: 'DashboardController',
            controlleras: 'dashboardCtrl'
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
(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .run(runFunc);

    runFunc.$inject = [
        '$rootScope'
    ];

    function runFunc($rootScope) {
        $rootScope.$on("$stateChangeError", console.log.bind(console));
    }

})(window.angular);
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
(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('LoginController', loginController);

    loginController.$inject = ['$scope', '$state', '$http'];

    function loginController($scope, $state, $http) {
        var vm = this;

        vm.forms = {};
        vm.currentForm = 'login';

        vm.data = {
            customerId: '' || $state.params.customerId,
            EMail: '',
            Password: '',
            CurrentPassword: '',
            newPassword: '',
            newPasswordConfirm: ''
        };

        /**
         * Check if the login form is valid.
         * @returns {boolean} The validation result.
         */
        vm.isFormValid = function () {
            if (!vm.forms.hasOwnProperty('login'))
                return false;

            const f = vm.forms.login;
            if (angular.isUndefined(f))
                return false;

            const isValid = f.$valid === true && f.$dirty === true;
            return isValid;
        };

        vm.login = function () {
            if (!vm.isFormValid())
                return;

            const requestData = {
                eMail: vm.data.EMail,
                password: vm.data.Password
            };

            $http({
                method: 'post',
                url: environment.apiUrl + 'customers/login',
                data: requestData
            })
                .then(function (result) {
                    if (result.data === 0) {
                        console.log("result was 0");
                        return;
                    }

                    console.log(result.data);
                    $state.go('dashboard', { customerId: result.data });
                });
        };

        vm.changePassword = function () {
            if (vm.data.newPassword !== vm.data.newPasswordConfirm) {
                console.log("passwords did not match");
                return;
            }

            var requestData = {
                customerId: vm.data.customerId,
                oldPassword: vm.data.oldPassword,
                newPassword: vm.data.newPassword
            };

            $http({
                method: 'post',
                url: environment.apiUrl + 'customers/changePassword',
                data: requestData
            });
        };

        vm.showForm = function (formName) {
            switch (formName) {
                case 'changePassword':
                case 'login':
                    vm.currentForm = formName;
                    break;
                default:
                    throw new TypeError('Expected form name to be "changePassword" or "login".' + formName);
            }
        };
    }

})(window.angular);