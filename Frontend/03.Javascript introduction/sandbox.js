let number1 = 1.54;
let string1 = 'Hello world!';
let boolean1 = false;
let null1 = null;
let undefined1 = undefined;

let userData = {
  firstName: 'Manu',
  lastName: 'Caprariu',
  age: 23,
};

let userData2 = userData;

let userData3 = {
  firstName: 'Emanuel',
  lastName: 'Caprariu',
  age: 23,
};

//number
console.log(number1.toExponential(1));
console.log(number1.toFixed());
console.log(number1.toLocaleString());
console.log(number1.toPrecision());
console.log(number1.toString());
console.log(number1.valueOf());
console.log('is finite : ' + isFinite(number1));
console.log('is Not a number : ' + isNaN(number1));

//string
console.log(string1.charAt(0));
console.log(string1.charCodeAt(0));
console.log(string1.codePointAt(0));
console.log(string1.concat(` ${userData.firstName}`));
console.log(string1.endsWith(`ld!`));
console.log(string1.includes('Hello'));
console.log(string1.indexOf('o')); //prima aparitie
console.log(`last appearance of o ${string1.lastIndexOf('o')}`);
console.log('length of my string ' + string1.length);
console.log(string1.localeCompare('Hello'));
console.log(string1.match(/[a-zA-Z]/g));
console.log([...string1.matchAll(/[a-z]/g)][0]);
console.log(string1.normalize('NFD'));
console.log(string1.padEnd(15, 'asfa')); // daca maxLength este mai mare de current Length atunci completeaza pana la maxLength final
console.log(string1.padStart(15, 'aff')); //aceeasi chestie doar ca la inceput
console.log(string1.repeat(2));
console.log(string1.replace('H', 'h'));
console.log(string1.search('e'));
console.log(string1.slice(1, 4));
console.log(string1.split(' '));
console.log(string1.startsWith('H'));
console.log(string1.substring(1, 4));
console.log(string1.toLocaleLowerCase());
console.log(string1.toLocaleUpperCase());
console.log(string1.toLowerCase());
console.log(string1.toUpperCase());
console.log(string1.toString());
console.log(string1.trim());
console.log(string1.concat('                   ').trimEnd());
console.log(string1.padStart(20, '          ').trimStart());
console.log(string1.valueOf());

//boolean
console.log(boolean1.valueOf());

//object

userData.firstName = 'Emanuel';
console.log(userData);

console.log(`compare string with number == : ${'23' == 23}`);
console.log(`compare string with number === : ${'23' === 23}`);
console.log(`compare 2 objects == : ${userData == userData2}`);
console.log(`compare 2 objects === : ${userData === userData2}`);
console.log(`compare 2 objects == : ${userData === userData3}`);
