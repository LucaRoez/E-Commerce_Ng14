import { AbstractControl, FormControl, ValidationErrors, ValidatorFn } from "@angular/forms";


export const passMustBeEqual: ValidatorFn = (group: AbstractControl): ValidationErrors | null => {
	const newPass = group.get('password') as FormControl;
	const passConfirm = group.get('confirmpass') as FormControl;

	return newPass.value === passConfirm.value ? null : {	passMustBeEqual: true }
}