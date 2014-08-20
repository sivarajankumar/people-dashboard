/// <reference path="../../_references.js" />
(function () {
    angular.module('app').factory('modelFactory', ['metadataFactory', function (metadata) {
        function MetadataFactory() {
            this.models = {};

            this.models.userLogin = metadata.createModel({
                email: {
                    displayName: 'E-mail',
                    dataType: metadata.DataTypes.email,
                    value: '',
                    validations: [
                        metadata.Validators.required
                    ]
                },
                password: {
                    displayName: 'Senha',
                    dataType: metadata.DataTypes.text,
                    value: '',
                    validations: [
                        metadata.Validators.required
                    ]
                }
            });
        };

        MetadataFactory.prototype.createModel = function (modelName) {
            modelName = modelName.toLowerCase();
            for (var key in this.models) {
                if (key.toLowerCase() === modelName) {
                    return this.models[key];
                }
            }

            return null;
        };

        return new MetadataFactory();
    }]);
})();