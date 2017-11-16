(function () {
    'use strict';

    angular.module('app', ['ui.bootstrap', 'ngFabForm', 'ngMessages']).config(function (ngFabFormProvider) {
        ngFabFormProvider.extendConfig({
            validationsTemplate: '../../Templates/germanValidationTemplate.html'
        });
    });
})();