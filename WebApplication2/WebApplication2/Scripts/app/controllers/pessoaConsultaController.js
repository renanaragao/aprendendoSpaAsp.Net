(function () {
    'use strict';

    angular.module('spaExemplo').controller('pessoaConsultaController', ['$scope', '$http', function ($scope, $http) {

        $scope.refresh = refresh;

        $scope.refresh();

        function refresh() {

            $http.get('saidas/').success(function (data) {

                $scope.pessoas = data;

            });

        };

    }
    ]);

})();