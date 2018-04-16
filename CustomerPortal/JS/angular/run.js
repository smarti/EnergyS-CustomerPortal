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