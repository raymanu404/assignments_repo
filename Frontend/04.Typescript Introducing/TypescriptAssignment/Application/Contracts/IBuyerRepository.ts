import { Buyer } from '../../Domain/Roles/Buyer';

export interface IBuyerRepository {
  createBuyer(buyer: Buyer): void;
  deleteBuyer(buyer: Buyer): void;
  loginBuyer(Email: string, Password: string): string;
}
