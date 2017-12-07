Bool IsNumber (string str) {
	int result;
	return Int32.TryParse(str, out result);
}