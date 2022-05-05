"use strict";
exports.__esModule = true;
exports.Greater = void 0;
var Greater = /** @class */ (function () {
    function Greater(message) {
        this.greeting = message;
    }
    Greater.prototype.greet = function () {
        console.log('Hello , ' + this.greeting);
    };
    return Greater;
}());
exports.Greater = Greater;
