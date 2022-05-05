var video = {
    title: 'a',
    play: function () {
        console.log(this);
    }
};
video.play();
function playVideo() {
    console.log(this);
}
playVideo();
var video1 = {
    title: 'a',
    play: function () {
        return function () {
            console.log(this);
        };
    }
};
var t = video1.play();
t();
var videoArrow = {
    title: 'a',
    play: function () {
        var _this = this;
        return function () {
            console.log(_this);
        };
    }
};
var tArrow = videoArrow.play();
tArrow();
//overloads
var suits = [
    { suit: 'heart', card: 7 },
    { suit: 'spade', card: 6 },
    { suit: 'club', card: 8 },
    { suit: 'diamond', card: 14 },
];
function pickCard(x) {
    if (typeof x == 'object') {
        var pickedCard = Math.floor(Math.random() * x.length);
        return pickedCard;
    }
    else if (typeof x == 'number') {
        var pickedSuit = Math.floor(x / 13);
        return { suit: suits[pickedSuit], card: x % 13 };
    }
}
console.log(pickCard(9));
console.log(pickCard(suits));
//generics
function identity(arg) {
    return arg;
}
console.log(identity(3));
console.log(identity('hello'));
console.log(identity(false));
var myIdentity = identity;
var GenericNumber = /** @class */ (function () {
    function GenericNumber() {
    }
    return GenericNumber;
}());
var myGenericNumber = new GenericNumber();
myGenericNumber.zeroValue = 0;
myGenericNumber.add = function (x, y) {
    return x + y;
};
function loggingIdentity(arg) {
    console.log(arg.length);
    return arg;
}
var len = {
    length: 100
};
loggingIdentity(len);
