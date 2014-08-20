/// <reference path="../../_references.js" />
(function () {
    angular.module('app').factory('metadataFactory', ['dictionaryFactory', function (dictionary) {
        var self = this;

        self.DataTypes = {
            integer: 0,
            decimal: 1,
            text: 2,
            email: 3,
            date: 4,
            bool: 5
        };

        var Validator = (function () {
            function Validator(validate) {
                this.isValid = false;
                this.errorMessage = '';
                this.validate = function (property) {
                    validate.call(this, property);
                }
            }

            return Validator;
        })();

        var Validators = {
            required: new Validator(function (property) {
                if (property.value == undefined || ( typeof(property.value) === 'string' && property.value.trim() === '')) {
                    this.errorMessage = String.format(dictionary.validations.required, property.displayName);
                    return this.isValid = false;
                }

                return this.isValid = true;
            }),

            typeCheck: {
                integer: new Validator(function (property) {
                    if (property.value == undefined) {
                        return this.isValid = true;
                    }

                    if (typeof (property) === 'number') {
                        return this.isValid = true;
                    }

                    return this.isValid = false;
                })
            }
        };

        var PropertyMetadata = (function () {
            function PropertyMetadata(displayName, fieldType, initialValue, validations) {
                this.displayName = displayName;
                this.fieldType = fieldType;
                this.value = initialValue;
                this.validations = validations || [];
                this.isValid = false;
                this.errorMessages = [];
            }

            PropertyMetadata.prototype.clearValidationErrors = function () {
                this.isValid = true;
                this.errorMessages.clear();
            };

            PropertyMetadata.prototype.validate = function () {
                this.clearValidationErrors();

                if (this.validations.length === 0) {
                    return this.isValid = true;
                }                

                this.validations.forEach(function (valName) {
                    var validator = Validators[valName];
                    if (!validator) {
                        throw new ReferenceError(String.format(dictionary.exceptions.validatorNotFound, validation));
                    }

                    validator.validate(this);
                    if (!validator.isValid) {
                        this.errorMessages.push(validator.errorMessage);
                        this.isValid = false;
                    }
                }, this);

                return this.isValid;
            };

            return PropertyMetadata;
        })();

        var BaseModel = (function () {
            function BaseModel() {
                this.isValid = false;
                this.errorMessages = [];
                this.properties = {};
            }

            BaseModel.prototype.forEachProperty = function (action) {
                for (var propName in this.properties) {
                    action.call(this, this.properties[propName]);
                }
            };

            BaseModel.prototype.clearValidationErrors = function () {
                this.isValid = true;
                this.errorMessages.clear();
                this.forEachProperty(function (property) {
                    property.clearValidationErrors();
                });
            };

            BaseModel.prototype.validate = function () {
                this.clearValidationErrors();

                this.forEachProperty(function (property) {
                    if (!property.validate()) {
                        this.isValid = false;
                    }
                });

                return this.isValid;
            };

            return BaseModel;
        })();

        

        self.Validators = (function () {
            var names = {};
            for (var key in Validators) {
                names[key] = key;
            }

            return names;
        })();
        

        self.createMetadata = function (displayName, fieldType, initialValue, validations) {
            return new PropertyMetadata(displayName, fieldType, initialValue, validations);
        };

        self.createModel = function (metadataInfos) {
            var model = new BaseModel();

            for (var key in metadataInfos) {
                var metadata = metadataInfos[key];
                model.properties[key] = self.createMetadata(metadata.displayName, metadata.dataType, metadata.value, metadata.validations);
            }

            return model;
        }

        return self;
    }]);
})();