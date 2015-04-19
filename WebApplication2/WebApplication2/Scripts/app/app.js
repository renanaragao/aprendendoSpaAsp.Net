(function () {
    'use strict';

    var app = angular.module('spaExemplo', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {

        $routeProvider
            .when('/home', {
                templateUrl: '/dashboard/Scripts/app/views/home.html'
            })
            .when('/cadastro', {
                templateUrl: '/dashboard/Scripts/app/views/cadastro.html',
                controller: 'pessoaCadastroController as vm'
            })
            .when('/consulta', {
                templateUrl: '/dashboard/Scripts/app/views/consulta.html',
                controller: 'pessoaConsultaController as vm'
            })
            .otherwise({
                redirectTo: '/home'
            });

    }
    ]);

})();