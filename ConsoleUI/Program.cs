

using ConsoleUI;
using System.Runtime.InteropServices;

List<PersonModel> people = new List<PersonModel>();

List<AddressModel> addressList = new List<AddressModel>();

string firstName = "";

do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();

    Console.Write("What is your last name: ");
    string lastName = Console.ReadLine();

    Console.Write("What is your age: ");
    string ageText = Console.ReadLine();
    bool validAge = int.TryParse(ageText, out int age);

    Console.Write("What is your gender: ");
    string gender = Console.ReadLine();

    Console.Write("What is your email address: ");
    string email = Console.ReadLine();

    Console.Write("What is your Street Number: ");
    string streetNumberText = Console.ReadLine();
    bool isValidNumber = int.TryParse(streetNumberText, out int streetNumber);

    Console.Write("What is your Street Name: ");
    string streetName = Console.ReadLine();

    Console.Write("What is your Apartment Number: ");
    string? apartmentNumberText = Console.ReadLine();
    bool isValidAptNumber = int.TryParse(apartmentNumberText, out int apartmentNumber);

    Console.Write("What is your City: ");
    string city = Console.ReadLine();

    Console.Write("What is your State: ");
    string state = Console.ReadLine();

    Console.Write("What is your Postal Code: ");
    string postalCodeText = Console.ReadLine();
    bool isValidPC = int.TryParse(postalCodeText, out int postalCode);
    
    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        person.Age = age;
        person.Sex = gender;
        person.EmailAddress = email;
        people.Add(person);

        AddressModel address = new AddressModel();
        address.StreetNumber = streetNumber;
        address.StreetName = streetName;
        address.ApartmentNumber = apartmentNumber;
        address.City = city;
        address.State = state;
        address.PostalCode = postalCode;
        addressList.Add(address);
    }
}while (firstName.ToLower() != "exit");

foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}

Console.ReadLine();