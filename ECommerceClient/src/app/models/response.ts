import { Product, Gender, Category, Currency } from "./models";

export interface Response {
    isSuccessful: boolean;
    statusCode: number;
    message: string;
    product?: Product;
    products?: Product[];
    genders?: Gender[];
    categories?: Category[];
    currencies?: Currency[];
}