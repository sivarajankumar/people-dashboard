(function () {
    angular.module('app').service('localStorageService', function () {
        var self = this;
        var repository = window.localStorage;
        var prefix = 'app.';

        function getKey(key) {
            return prefix + key;
        }

        self.getItem = function (key, defaultValue) {
            return $.Deferred(function () {
                var item = repository.getItem(getKey(key));
                if (item == undefined) {
                    if (defaultValue === undefined) {
                        return this.reject();
                    }
                    return this.resolve(defaultValue);
                }
                
                try {
                    item = JSON.parse(item);
                    return this.resolve(item);
                }
                catch (error) {
                    this.reject(error);
                }                                    
            }).promise();
        };

        self.setItem = function (key, value) {
            return $.Deferred(function () {
                try {
                    repository.setItem(key, JSON.stringify(value));
                    this.resolve();
                }
                catch (error) {
                    this.reject(error);
                }
            }).promise();
        };

        return self;
    });
})();