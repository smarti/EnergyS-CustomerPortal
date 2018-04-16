(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('LoginController', loginController);

    loginController.$inject = ['$scope', '$state', '$http' ];

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

            var requestData = {
                eMail: this.EMail,
                password: this.Password
            };

            var result = $http({
                method: 'post',
                url: environment.apiUrl + 'customers/login',
                data: requestData
            });

            if (result === 0)
                return;

            $state.go('dashboard', { customerId: result });
        };

        vm.changePassword = function () {
            if (vm.data.newPassword !== vm.data.newPasswordConfirm)
                return;

            var requestData = {
                customerId: this.customerId,
                oldPassword: this.CurrentPassword,
                newPassword: this.newPassword
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