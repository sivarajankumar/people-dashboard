(function () {
    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/pages/splash.html',
                controller: 'splashController',
                controllerAs: 'ctrl'
            })
            .when('/home', {
                templateUrl: 'views/pages/home.html',
                controller: 'homeController',
                controllerAs: 'ctrl'
            })
            .when('/login', {
                templateUrl: 'views/pages/login.html',
                controller: 'loginController',
                controllerAs: 'ctrl'
            });
    }]);
})();