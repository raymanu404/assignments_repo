//boolean
let isDone: boolean = true;

//number
let deciaml: number = 0.123;
let hex: number = 0x4d;
let oct: number = 0o744;
let binary: number = 0b10111;

//string
let color: string = 'red';
let color2: string = 'blue';
let firstName = 'Manu';

let sayHello = `Hello, ${firstName}`;
console.log(sayHello);

//array

let listOfNumbers: number[] = [7, 2, 23, 21];
console.log('[]');
listOfNumbers.forEach((value, index) => console.log(value));

let integersList: Array<number> = [1, 2, 3, 4, 5];
console.log('Array');
integersList.filter((val) => val !== 2).forEach((val) => console.log(val));

//enum
enum Color {
  Blue = 1,
  Black,
  Green,
  Purple,
}

let blue: Color = Color.Blue;
let colorName: string = Color[1];
console.log(colorName);

//any
let notSure: any = 'some random string';
notSure = false;
notSure = 12.14;
console.log(notSure);

//Object - anything that is not primitive
declare function createObj(o: Object | null): void;

createObj({ firstName: 'Laura' }); // OK
createObj(null); //OK
//createObj("randomstring"); // Error

//type assertions - un fel de cast
let someValue: any = 'this is random string';
let strLength: number = (someValue as string).length;
let strLength2: number = (<string>someValue).length;

const userData = {
  firstName: 'Madalina',
  age: 24,
};
// userData.firstName = "Vasile"; // error
