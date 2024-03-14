import { Product, Image, Gender, Category, Currency } from "./models";

export interface Response {
    isSuccessful: boolean;
    statusCode: number;
    message: string;
    product?: Product;
    products?: Product[];
    images?: Image[]
    genders?: Gender[];
    categories?: Category[];
    currencies?: Currency[];
}