/// <reference path="../../_references.js" />
(function () {
    angular.module('app').factory('dictionaryFactory', function () {
        return {
            validations: {
                required: 'O campo {0} é obrigatório.'
            },
            exceptions: {
                validatorNotFound: 'O validador {0} não foi encontrado.'
            },
            sentences: {
                userNotRegisteredOrWrongPassword: 'Usuário não cadastrado ou senha inválida.',
                loading: 'Aguarde...'
            }
        };
    });
})();