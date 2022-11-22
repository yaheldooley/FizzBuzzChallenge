public static string FizzBuzz(int number)
{
	string valueString = "";
	if (number % 3 == 0) valueString += "fizz";
	if (number % 5 == 0) valueString += "buzz";
	return valueString;

}