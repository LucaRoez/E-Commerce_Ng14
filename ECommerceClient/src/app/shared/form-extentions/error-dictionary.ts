interface ErrorDictionary {
	[key: string]: string
}

export const errorDictionary: ErrorDictionary = {
	required: 'This is a mandatory field',
	minlength: "You haven't yet reached the minimum character length",
	maxlength: "You have surpassed the maximum character length available",
	email: 'Email field has to have an email format',
	pattern: 'Has to have at least one special character, one decimal and one uppercase letter',
	passMustBeEqual: "Confirmation password doesn't match original password"
}