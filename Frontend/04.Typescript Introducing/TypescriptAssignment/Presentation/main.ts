// import { Buyer } from '../Domain/Roles/Buyer';
// import { BuyerRepository } from '../Infrastructure/BuyerRepository';

let buyers = [
  {
    Email: 'email1@gmail.com',
    FirstName: 'Eugen',
    LastName: 'Popescu',
    Gender: 'M',
    Password: '123',
  },
  {
    Email: 'alexandra.ionescu@gmail.com',
    FirstName: 'Alexandra',
    LastName: 'Ionescu',
    Gender: 'F',
    Password: '12334',
  },
  {
    Email: 'maria.ariana@gmail.com',
    FirstName: 'Maria',
    LastName: 'Ionescu',
    Gender: 'F',
    Password: '12364',
  },
  {
    Email: 'claudiu.ion@gmail.com',
    FirstName: 'Claudiu',
    LastName: 'Ion',
    Gender: 'M',
    Password: '1234',
  },
] as Buyer[];

interface IBuyer {
  Email: string;
  Password: string;
  FirstName: string;
  LastName: string;
  PhoneNumber?: string;
  Gender?: string;
  Confirmed?: boolean;
  Balance?: number;
}

class Buyer implements IBuyer {
  Email: string;
  Password: string;
  FirstName: string;
  LastName: string;
  PhoneNumber: string;
  Gender: string;
  Confirmed: boolean = false;
  Balance: number = 0.0;
}

interface IBuyerRepository {
  createBuyer(buyer: Buyer): void;
  deleteBuyer(buyer: Buyer): void;
  loginBuyer(Email: string, Password: string): string;
}

class BuyerRepository implements IBuyerRepository {
  private Buyers: IBuyer[];
  constructor() {
    this.Buyers = new Array();
  }
  public readonly GetBuyers = () => this.Buyers;

  createBuyer(buyer: IBuyer) {
    if (buyer as IBuyer) {
      this.Buyers.push(buyer);
      console.log(`${buyer.FirstName} welcome in club!`);
    } else {
      console.log('Complete all required properties');
    }
  }

  deleteBuyer(buyer: Buyer) {
    let index: number = this.Buyers.indexOf(buyer, 0);
    if (index > -1) {
      this.Buyers.splice(index, 1);
      console.log('Buyer was added successfully');
    } else {
      console.log("This buyer doesn't exists!");
    }
  }

  loginBuyer(Email: string, Password: string) {
    let returnResult: string = '';
    this.Buyers.forEach((e) => {
      if (e.Email === Email && e.Password === Password) {
        returnResult = `Hello, ${e.FirstName}`;
        return;
      } else {
        returnResult = `Email or Password incorrect!`;
      }
    });

    return returnResult;
  }
}

let buyerRepo: BuyerRepository = new BuyerRepository();
buyers.forEach((e) => {
  buyerRepo.createBuyer(e);
});

console.log(buyerRepo.loginBuyer('claudiu.ion@gmail.com', '1234'));
