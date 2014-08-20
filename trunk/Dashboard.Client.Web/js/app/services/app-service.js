/// <reference path="../../_references.js" />
(function () {
    angular.module('app').service('appService', ['localStorageService', 'dictionaryFactory', function (localStorage, dictionary) {
        var self = this;

        self.getCurrentUser = function () {            
            return localStorage.getItem('currentUser');
        };

        self.login = function (userLogin) {
            return $.Deferred(function () {
                if (!userLogin.validate()) {
                    return this.reject();
                }
                
                if (userLogin.properties.email.value === 'adm@adm.com' && userLogin.properties.password.value === 'adm') {
                    return this.resolve(true);
                }

                userLogin.validationErrors.push(dictionary.sentences.userNotRegisteredOrWrongPassword);
                this.reject();
            }).promise();
        };

        return self;
    }]);
})();