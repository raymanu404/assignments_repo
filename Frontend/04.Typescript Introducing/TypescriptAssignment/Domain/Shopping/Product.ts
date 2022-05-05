import { Categories } from '../Enums/Categories';

export class Product {
  Category: Categories;
  Title: string;
  Description: string;
  Price: Float32Array;
  DateCreated: Date;
  DateUpdated: Date;
  IsInStock: boolean;
}
