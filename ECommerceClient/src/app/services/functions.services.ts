import { Injectable } from "@angular/core";
import { Product, ProductUI } from "../models/models";

@Injectable({
	providedIn: 'root'
})
export class FunctionService {
	PrepareProductToUI(product: Product) {
		let productUI: ProductUI = { ...product, isFirst: false, isLastThree: false };
		return productUI;
	}
}