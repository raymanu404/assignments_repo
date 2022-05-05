interface LabelValue {
  label: string;
}

function printLabel(labelValueObj: LabelValue) {
  console.log(labelValueObj);
}

let labelObj = {
  size: 10,
  label: 'Some label here',
};
printLabel(labelObj);

class Animal {
  public name: string;
  constructor(name: string) {
    this.name = name;
  }
  callAnimal() {
    return `Come to me ${this.name}`;
  }

  protected move(metersToMove: number = 0): void {
    console.log(`Move ${metersToMove} meters`);
  }
}

class Dog extends Animal {
  readonly color: string;
  constructor(name: string, color: string) {
    super(name);
    this.color = color;
  }

  bark() {
    console.log('Woof wooffff from ' + this.name);
    console.log(super.callAnimal());
  }
  move(metersToMove?: number): void {
    super.move(metersToMove);
  }
}

let dog = new Animal('Arthur');
console.log(dog.callAnimal());

let dogFromDog = new Dog('Kitty', 'black');
dogFromDog.bark();
dogFromDog.move(2);
console.log(dogFromDog.color);
