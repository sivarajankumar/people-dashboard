/// <reference path="../../_references.js" />
(function () {
    angular.module('app').controller('loginController', ['$location', 'modelFactory', 'appService', function ($location, modelFactory, appService) {
        var self = this;

        self.title = 'Login';

        self.userLogin = modelFactory.createModel('userLogin');

        self.login = function () {
            appService.login(self.userLogin).done(function () {
                $location.path('/home');
            }).fail(function () {

            });
        };
        
        return self;

    }]);
})();