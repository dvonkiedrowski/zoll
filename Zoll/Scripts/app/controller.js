(function () {
	'use strict';

    angular.module('app').controller('controller', controller);

    controller.$inject = ['$http', '$uibModal', '$scope', '$filter'];

    function controller($http, $uibModal, $scope, $filter) {
        var vm = this;
        vm.dependencies = [];
        vm.gridOptions = {
            data: [],
            urlSync: true
        };

        function activate() {
            $http.get('/api/Dependencies').then(function (result) {
                vm.dependencies = result.data;
            });

            $http.get('/api/Zoll').then(function (result) {
                vm.gridOptions.data = result.data;
            });
        }

        vm.openModal = function (row) {
            var modalInstance = $uibModal.open({
                templateUrl: 'modalContent.html',
                controller: 'modalController',
                controllerAs: '$ctrl',
                size: 'lg',
                resolve: {
                    row: function () {
                        return row;
                    },
                    dependencies: function () {
                        return vm.dependencies;
                    }
                }
            });

            modalInstance.result.then(function () {
                activate();
            }, function () {
            });
        };

        activate();
    }
})();