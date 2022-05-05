import { IBuyer } from '../Application/Contracts/IBuyer';
import { IBuyerRepository } from '../Application/Contracts/IBuyerRepository';
import { Buyer } from '../Domain/Roles/Buyer';

export class BuyerRepository implements IBuyerRepository {
  private Buyers: Buyer[];
  constructor() {
    this.Buyers = new Array();
  }

  public readonly GetBuyers = () => this.Buyers;

  createBuyer(buyer: Buyer) {
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

  loginBuyer: (Email: string, Password: string) => string;
}
