(function() {
    'use strict';

    angular.module('app').controller('modalController', modalController);

    modalController.$inject = ['$http', '$uibModalInstance', 'row', 'dependencies'];

    function modalController($http, $uibModalInstance, row, dependencies) {
        var vm = this;
        vm.model = row;
        vm.dependencies = dependencies;

        // fix dates
        vm.model.LIEF_DAT = moment(vm.model.LIEF_DAT).toDate();

        vm.liefDat = {
            opened: false
        };

        vm.submit = function () {
            console.log(vm.model);

            //if (row.RECNUM) {
            //    $http.post('/api/Zoll', vm.model).then(vm.onSuccess, vm.onError);
            //} else {
            //    $http.put('/api/Zoll/' + vm.model.RECNUM, vm.model).then(vm.onSuccess, vm.onError);
            //}
        };

        vm.cancel = function () {
            $uibModalInstance.dismiss('cancel');
        };

        vm.onSuccess = function (result) {
            $uibModalInstance.close(result);
        };

        vm.onError = function (err) {
            console.log(err);
        };

        vm.openDatepicker = function (name) {
            vm[name].opened = true;
        }
    }
})();