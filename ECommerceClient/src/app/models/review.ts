export interface Review {
    id?: null | number,
    author: string,
    authorId: number,
    body: string,
    rate: number,
    product: string,
    productId: number
}