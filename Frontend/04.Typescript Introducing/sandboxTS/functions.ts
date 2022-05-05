let video = {
  title: 'a',
  play() {
    console.log(this);
  },
};

video.play();

function playVideo() {
  console.log(this);
}

playVideo();

let video1 = {
  title: 'a',
  play: function () {
    return function () {
      console.log(this);
    };
  },
};

var t = video1.play();
t();

let videoArrow = {
  title: 'a',
  play: function () {
    return () => {
      console.log(this);
    };
  },
};

var tArrow = videoArrow.play();
tArrow();

//overloads
let suits = [
  { suit: 'heart', card: 7 },
  { suit: 'spade', card: 6 },
  { suit: 'club', card: 8 },
  { suit: 'diamond', card: 14 },
];

function pickCard(x: { suit: string; card: number }[]): number;
function pickCard(x: number): { suit: string; card: number };

function pickCard(x: any): any {
  if (typeof x == 'object') {
    let pickedCard = Math.floor(Math.random() * x.length);
    return pickedCard;
  } else if (typeof x == 'number') {
    let pickedSuit = Math.floor(x / 13);
    return { suit: suits[pickedSuit], card: x % 13 };
  }
}

console.log(pickCard(9));
console.log(pickCard(suits));

//generics
function identity<T>(arg: T): T {
  return arg;
}

console.log(identity(3));
console.log(identity('hello'));
console.log(identity(false));

//Generic types
interface IGenericIdentity {
  <T>(arg: T): T;
}

let myIdentity: IGenericIdentity = identity;

class GenericNumber<T> {
  zeroValue: T;
  add: (x: T, y: T) => T;
}
let myGenericNumber = new GenericNumber<number>();
myGenericNumber.zeroValue = 0;
myGenericNumber.add = function (x, y) {
  return x + y;
};

//generic constraints;

interface LengthWise {
  length: number;
}
function loggingIdentity<T extends LengthWise>(arg: T) {
  console.log(arg.length);
  return arg;
}

let len: LengthWise = {
  length: 100,
};

loggingIdentity(len);

//type compatibillty
interface Named {
  name: string;
}
class Person {
  name: string;
}
let p: Named;
p = new Person();
p.name = 'CF';

interface Named1 {
  name: string;
}

let p1: Named1;
let y = { name: 'Marius', age: 24 };
p1 = y; //ok pentru ca avem name

//comparing functions

let z = (a: number) => 0;
let w = (b: number, c: string) => 0;
w = z; // OK

// z = w; //ERror

let items1 = [1, 2, 3];
//daca nu ai nevoie de toate nu le folosi
items1.forEach((item, index, array) => console.log(item));

items1.forEach((item) => console.log(item));

//iterations

//for .. of statements
let randomArray = [1, 2, 3, 45, 6, 7];
for (let entry of randomArray) {
  console.log(entry); // 1, 2, 3, 45,6, 7
}

let list1 = [4, 5, 6];
for (let i in list1) {
  console.log(i); // 0 , 1, 2
}
for (let i of list1) {
  console.log(i); // 4, 5,  6
}
