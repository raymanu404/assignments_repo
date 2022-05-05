function printLabel(labelValueObj) {
    console.log(labelValueObj);
}
var labelObj = {
    size: 10,
    label: 'Some label here'
};
printLabel(labelObj);
function createCar(config) {
    console.log(config.maxSpeed + ' ' + config.brandName);
    if (config.color !== undefined) {
        console.log(config.color);
    }
}
var car = createCar({ maxSpeed: 300, brandName: 'Mercedes', color: 'black' });
var Car = /** @class */ (function () {
    function Car(brandName, horsePower) {
        this.brandName = brandName;
        this.horsePower = horsePower;
    }
    Car.prototype.setColor = function (color) {
        this.color = color;
    };
    Car.prototype.printDetails = function () {
        console.log("".concat(this.brandName, " : ").concat(this.horsePower, " HP: ").concat(this.color !== undefined ? this.color : ''));
    };
    Car.prototype.setBrandName = function (brandName) {
        this.brandName = brandName;
    };
    Car.prototype.someToPrint = function (a, optionalDetails) {
        console.log("".concat(a, "  ").concat(optionalDetails ? optionalDetails : ''));
    };
    return Car;
}());
var myAudiCar = new Car('Audi', 280);
myAudiCar.setColor('Black');
myAudiCar.printDetails();
myAudiCar.someToPrint(2);
