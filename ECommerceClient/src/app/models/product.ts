
export interface Product {
  id?: null | number;
  categoryId?: null | number;
  creationDate?: string;
  currencyId?: null | number;
  description: string;
  discount?: null | number;
  genderId?: null | number;
  name: string;
  price?: null | number;
  quantityAvailable?: null | number;
  rate?: null | number;
  visits?: number;
  presentationImage?: null | string;
  secondImage?: null | string;
  thirdImage?: null | string;
  fourthImage?: null | string;
  fifthImage?: null | string;
  sixthImage?: null | string;
}

export interface ProductUI extends Product {
  isFirst: false | true;
  isLastThree: false | true;
}