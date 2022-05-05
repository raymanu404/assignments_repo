export interface IBuyer {
  Email: string;
  Password: string;
  FirstName: string;
  LastName: string;
  PhoneNumber: string;
  Gender: string;
  Confirmed?: boolean;
  Balance?: Float32Array;
}
