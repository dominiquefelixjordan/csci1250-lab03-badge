using System.ComponentModel;

Console.Write("Please enter first and last name for badge: ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition);

string firstInitial = firstName.Substring(0, 1);
string lastInitial = lastName.Substring(spacePosition, 1);
string userName = firstInitial + lastName.Trim();

string initials = firstInitial + "." + lastInitial + ".";

int lettersInLastName = lastName.Trim().Length;

Console.WriteLine("Name on badge: " + fullName.ToUpper());
Console.WriteLine("Username: " + userName.ToLower());
Console.WriteLine("Initials: " + initials.ToUpper());
Console.WriteLine("Letters in last name: " + lettersInLastName);






