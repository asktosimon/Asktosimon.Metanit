string firstName = "Andrey";
string secondName = "Simanovich";
double price = 2.7;

string fullName = string.Format("firstName: {0}, secondName: {1}, price: {2:C2}", firstName, secondName, price);

Console.WriteLine(fullName);