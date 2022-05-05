var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
function printLabel(labelValueObj) {
    console.log(labelValueObj);
}
var labelObj = {
    size: 10,
    label: 'Some label here'
};
printLabel(labelObj);
var Animal = /** @class */ (function () {
    function Animal(name) {
        this.name = name;
    }
    Animal.prototype.callAnimal = function () {
        return "Come to me ".concat(this.name);
    };
    Animal.prototype.move = function (metersToMove) {
        if (metersToMove === void 0) { metersToMove = 0; }
        console.log("Move ".concat(metersToMove, " meters"));
    };
    return Animal;
}());
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog(name, color) {
        var _this = _super.call(this, name) || this;
        _this.color = color;
        return _this;
    }
    Dog.prototype.bark = function () {
        console.log('Woof wooffff from ' + this.name);
        console.log(_super.prototype.callAnimal.call(this));
    };
    Dog.prototype.move = function (metersToMove) {
        _super.prototype.move.call(this, metersToMove);
    };
    return Dog;
}(Animal));
var dog = new Animal('Arthur');
console.log(dog.callAnimal());
var dogFromDog = new Dog('Kitty', 'black');
dogFromDog.bark();
dogFromDog.move(2);
console.log(dogFromDog.color);
