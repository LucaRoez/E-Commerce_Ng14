import { Component, Input } from "@angular/core";
import { AbstractControl } from "@angular/forms";


@Component({
	selector: 'form-error-container',
	template: `
		<ng-container class="error-container" *ngIf="abstractControl?.invalid && (abstractControl?.touched || abstractControl?.dirty)">
			<ng-content />
		</ng-container>
	`,
	styles: [
		`
			ng-container.error-container {
				margin-bottom: .5rem;
			}
		`
	]
})
export class ErrorContainerComponent {
	@Input() abstractControl!: AbstractControl | null;
}