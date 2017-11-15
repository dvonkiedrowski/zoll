(function () {
	'use strict';

    angular.module('app').controller('controller', controller);

    controller.$inject = ['$http'];

    function controller($http) {
        var vm = this;
        vm.name = 'Lorem ipsum...';

        function activate() {
            $http.get('/api/Zoll').then(function (result) {
                vm.data = result.data;
                // ...
            });

            // ...
        }

        activate();
    }
})();