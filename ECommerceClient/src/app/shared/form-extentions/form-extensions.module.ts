import { NgIf } from "@angular/common";
import { NgModule } from "@angular/core";
import { ErrorContainerComponent } from "./error-container";
import { ErrorMessageComponent } from "./error-message";


@NgModule({
	declarations: [
		ErrorContainerComponent,
		ErrorMessageComponent
	],
	imports: [
		NgIf
	],
	exports: [
		ErrorContainerComponent,
		ErrorMessageComponent
	]
})
export class FormExtensionsModule {

}