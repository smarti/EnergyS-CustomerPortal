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