/// <reference path="../../_references.js" />
(function () {
    angular.module('app').controller('homeController', function () {
        var self = this;

        self.title = 'Olá';

        self.welcomeMessage = 'Seja bem-vindo!';

        return self;
    });
})();