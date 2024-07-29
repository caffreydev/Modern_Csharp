var numbers = new List<int>() { 1, 2, 3, 4, 5 };
var bigNumbers = new List<BigInteger>() { 1, 2, 3, 4, 5 };

var evenNumbers = numbers.Evens();
var bigEvenNumbers = bigNumbers.Evens();

var page = await new HttpClient().GetAsync("http://google.com");

WriteLine(string.Join(" ", evenNumbers));
WriteLine(string.Join(" ", bigEvenNumbers));
WriteLine(page);