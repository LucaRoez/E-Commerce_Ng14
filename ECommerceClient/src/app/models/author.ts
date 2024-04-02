import { Product } from "./product";
import { Review } from "./review";

export interface Author {
    id?: null | number,
    authorName: string,
    presentation?: null | string,
    email: string,
    password?: null | string,
    linkedProducts?: null | Product[],
    linkedReviews?: null | Review[]
}