using System.ComponentModel;

// this code parses name for badge

// Console.Write("Please enter first and last name for badge: ");
// string fullName = Console.ReadLine();

// fullName = fullName.Trim();

// int spacePosition = fullName.IndexOf(" ");
// string firstName = fullName.Substring(0, spacePosition);
// string lastName = fullName.Substring(spacePosition);

// string firstInitial = firstName.Substring(0, 1);
// string lastInitial = lastName.Substring(spacePosition, 1);
// string userName = firstInitial + lastName.Trim();

// string initials = firstInitial + "." + lastInitial + ".";

// int lettersInLastName = lastName.Trim().Length;

// Console.WriteLine("Name on badge: " + fullName.ToUpper());
// Console.WriteLine("Username: " + userName.ToLower());
// Console.WriteLine("Initials: " + initials.ToUpper());
// Console.WriteLine("Letters in last name: " + lettersInLastName);


// this code assigns ID and locker number

Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(0, 600);

Console.WriteLine("Student ID: " + studentId);
Console.WriteLine("Locker: " + lockerNumber);

// this code calculates the walk time

Console.Write("Input dorm 'x' value: ");
int dormX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input dorm 'Y' value: ");
int dormY1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input class 'X' value: ");
int classX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input class 'Y' value: ");
int classY2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input walking speed in feet per second: ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow((classX2 - dormX1),2) + Math.Pow((classY2 - dormY1),2)), 1);

double tripInSeconds = Math.Round((distance / walkingSpeed), 0);

int tripInMinutes = Convert.ToInt32(Math.Round((tripInSeconds / 60), 0));
int tripSeconds = Convert.ToInt32(Math.Round((tripInSeconds % 60), 0));

Console.WriteLine("Distance: " + distance);
Console.WriteLine("Walk Time: " + tripInMinutes + " minutes and " + tripSeconds + " seconds" );










