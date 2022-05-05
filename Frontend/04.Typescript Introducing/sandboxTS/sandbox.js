//boolean
var isDone = true;
//number
var deciaml = 0.123;
var hex = 0x4d;
var oct = 484;
var binary = 23;
//string
var color = 'red';
var color2 = 'blue';
var firstName = 'Manu';
var sayHello = "Hello, ".concat(firstName);
console.log(sayHello);
//array
var listOfNumbers = [7, 2, 23, 21];
console.log('[]');
listOfNumbers.forEach(function (value, index) { return console.log(value); });
var integersList = [1, 2, 3, 4, 5];
console.log('Array');
integersList.filter(function (val) { return val !== 2; }).forEach(function (val) { return console.log(val); });
//enum
var Color;
(function (Color) {
    Color[Color["Blue"] = 1] = "Blue";
    Color[Color["Black"] = 2] = "Black";
    Color[Color["Green"] = 3] = "Green";
    Color[Color["Purple"] = 4] = "Purple";
})(Color || (Color = {}));
var blue = Color.Blue;
var colorName = Color[1];
console.log(colorName);
