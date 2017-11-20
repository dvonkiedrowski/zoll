(function () {
    'use strict';

    angular.module('app', ['ui.bootstrap', 'ngFabForm', 'ngMessages', 'dataGrid', 'pagination'])
        .config(function (ngFabFormProvider) {
            ngFabFormProvider.extendConfig({
                validationsTemplate: '../../Templates/germanValidationTemplate.html'
            });
        }).run(function (paginationConfig) {
            paginationConfig.firstText = 'Erste';
            paginationConfig.previousText = 'Vorherige';
            paginationConfig.nextText = 'Nächste';
            paginationConfig.lastText = 'Letzte';

        });
})();