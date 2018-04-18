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
            if (vm.data.newPassword !== vm.data.newPasswordConfirm)
                return;

            var requestData = {
                customerId: $state.params.customerId,
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