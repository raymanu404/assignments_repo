export class Greater {
  greeting: string;
  constructor(message: string) {
    this.greeting = message;
  }
  greet() {
    console.log('Hello , ' + this.greeting);
  }
}
