interface LabelValue {
  label: string;
}

function printLabel(labelValueObj: LabelValue) {
  console.log(labelValueObj);
}

let labelObj1 = {
  size: 10,
  label: 'Some label here',
};

printLabel(labelObj1);

//optional properties

interface CarConfig {
  color?: string;
  brandName: string;
  maxSpeed: number;
}

function createCar(config: CarConfig) {
  console.log(config.maxSpeed + ' ' + config.brandName);
  if (config.color !== undefined) {
    console.log(config.color);
  }
}

let car = createCar({ maxSpeed: 300, brandName: 'Mercedes', color: 'black' });

interface ICarProperties {
  color?: string;
  brandName: string;
  horsePower: number;
  setColor(color: string): void;
  setBrandName?(brandName: string): void;
}

class Car implements ICarProperties {
  color?: string;
  brandName: string;
  horsePower: number;

  constructor(brandName: string, horsePower: number) {
    this.brandName = brandName;
    this.horsePower = horsePower;
  }

  setColor(color: string): void {
    this.color = color;
  }

  printDetails(): void {
    console.log(
      `${this.brandName} : ${this.horsePower} HP: ${
        this.color ? this.color : ''
      }`
    );
  }

  setBrandName(brandName: string): void {
    this.brandName = brandName;
  }

  someToPrint(a: number, optionalDetails?: string): void {
    console.log(`${a}  ${optionalDetails ? optionalDetails : ''}`);
  }
}

let myAudiCar = new Car('Audi', 280);
myAudiCar.setColor('Black');
myAudiCar.printDetails();
myAudiCar.someToPrint(2);
