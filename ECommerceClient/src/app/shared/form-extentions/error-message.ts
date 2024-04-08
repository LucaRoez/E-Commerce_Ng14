import { Component, Host, Input, OnInit } from "@angular/core";
import { AbstractControl } from "@angular/forms";
import { errorDictionary } from "./error-dictionary";
import {	ErrorContainerComponent} from './error-container'


@Component({
	selector: 'form-error-message',
	template: `
		<p class="error-message" *ngIf="abstractControl?.hasError(validationError)">
			{{ errorMessage	}}
		</p>
	`,
	styles: [
		`
			p.error-message {
				font-size: 0.8em;
				color: rgb(248, 7, 7);
				margin-left: 12%;
			}
		`
	]
})
export class ErrorMessageComponent implements OnInit {
	constructor(@Host() private errorContainer: ErrorContainerComponent) {}

	abstractControl!: AbstractControl | null;
	@Input() validationError!: string;
	@Input() customMessage: string | null = null;

	get errorMessage(): string {
		if (this.customMessage) return this.customMessage
		else if (errorDictionary[this.validationError] !== undefined) return errorDictionary[this.validationError]
		else return `There's a field error (error code: ${this.validationError})`
	}
	
	ngOnInit(): void {
		this.abstractControl = this.errorContainer.abstractControl;
	}
}