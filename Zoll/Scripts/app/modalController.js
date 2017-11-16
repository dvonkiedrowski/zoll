(function () {
    'use strict';

    angular.module('app').controller('modalController', modalController);

    modalController.$inject = ['$http', '$uibModalInstance', 'row', 'dependencies'];

    function modalController($http, $uibModalInstance, row, dependencies) {
        var vm = this;
        vm.model = row;
        vm.dependencies = dependencies;

        // fix dates
        vm.model.LIEF_DAT = moment(vm.model.LIEF_DAT).toDate();
        vm.model.RECH_DAT = moment(vm.model.RECH_DAT).toDate();
        vm.model.AEN_DAT = moment(vm.model.AEN_DAT).toDate();

        vm.liefDat = {
            opened: false
        };

        vm.rechDat = {
            opened: false
        };

        vm.aenDat = {
            opened: false
        };

        vm.submit = function () {
            $http.post('/api/Zoll', vm.model).then(vm.onSuccess, vm.onError);
        };

        vm.reversal = function () {
            if (confirm("Wollen Sie diese Buchung wirklich stornieren?")) {
                $http.put('/api/Zoll/' + vm.model.RECNUM, vm.model).then(vm.onSuccess, vm.onError);
            }
        }

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