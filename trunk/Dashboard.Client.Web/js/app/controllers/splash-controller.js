/// <reference path="../../_references.js" />
(function () {
    angular.module('app').controller('splashController', ['$location', 'dictionaryFactory', 'appService', function ($location, dictionary, appService) {
        var self = this;

        self.title = 'Dashboard';

        self.welcomeMessage = dictionary.sentences.loading;

        self.checkLogin = function () {
            appService.getCurrentUser().done(function () {
                $location.path('/home');
            }).fail(function () {
                $location.path('/login');
            });
        }

        return self;
    }]);
})();