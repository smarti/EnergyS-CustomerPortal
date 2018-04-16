(function (angular) {
    "use strict";

    angular
        .module('CustomerPortalApp')
        .controller('LoginController', loginController);

    loginController.$inject = ['$scope', '$state'];

    function loginController($scope, $state) {
        var vm = this;

        vm.forms = {};
        vm.currentForm = 'login';

        vm.data = {
            Username: $state.params.username || '',
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

            // API CALL Login
            //$state.go('login', { username: "NEE@NIETDOEN.PLS" });
        };

        vm.changePassword = function () {
            if (newPassword !== newPasswordConfirm)
                return;

            //API CALL ChangePassword
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