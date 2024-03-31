import { Injectable } from "@angular/core";
import { Product, Image, ProductUI } from "../models/models";

@Injectable({
	providedIn: 'root'
})
export class FunctionService {
	PrepareProductToUI(product: Product) {
		let productUI: ProductUI = { ...product, isFirst: false, isLastThree: false };
		return productUI;
	}
	
	SetImagesToProducts(images: Image[], productsCalled: Product[], products: ProductUI[]): ProductUI[] {
		for (let image of images) {
			for (let product of productsCalled) {
				let pUI: ProductUI | undefined;
				if (image.id === product.presentationImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.presentationImage = image.src : undefined;
					pUI ? pUI.presentationImageAlt = image.alt : undefined;
					break;
				}
				else if (image.id === product.secondImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.secondImage = image.src : undefined;
					break;
				}
				else if (image.id === product.thirdImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.thirdImage = image.src : undefined;
					break;
				}
				else if (image.id === product.fourthImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.fourthImage = image.src : undefined;
					break;
				}
				else if (image.id === product.fifthImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.fifthImage = image.src : undefined;
					break;
				}
				else if (image.id === product.sixthImageId) {
					pUI = products.find(pUI => pUI.id === product.id)
					pUI ? pUI.sixthImage = image.src : undefined;
					break;
				}
			}
		}
		return products;
	}

	SetImageToProduct(image: Image | null, product: ProductUI): ProductUI {
		product.presentationImage = image?.src;
		product.presentationImageAlt = image?.alt;
		return product;
	}
}