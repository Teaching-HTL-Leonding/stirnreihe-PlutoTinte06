using Stirnreihe.Data;

Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
Console.WriteLine("1) Add a person to the line");
Console.WriteLine("2) Print the line");
Console.WriteLine("3) Clear the line");
Console.WriteLine("4) Exit");
LineOfPeople line = new LineOfPeople();
int choice;

do
{
    Console.Write("Your choice: ");
    choice = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            Console.Write("First name: ");
            var firstName = Console.ReadLine()!;
            Console.Write("Last name: ");
            var lastName = Console.ReadLine()!;
            Console.Write("Height in cm: ");
            var height = int.Parse(Console.ReadLine()!);

            var person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Height = height
            };

            line.AddToFront(person);
            Console.WriteLine();
            break;
        case 2:
            if (line.First == null)
            {
                Console.WriteLine("The line is empty.");
                Console.WriteLine();
            }
            else
            {
                var currentPerson = line.First;
                while (currentPerson != null)
                {
                    Console.WriteLine(currentPerson.Person.ToString());
                    currentPerson = currentPerson.Next;
                }
                Console.WriteLine();
            }
            break;
        case 3:
            line.Clear();
            Console.WriteLine("The line has been cleared.");
            Console.WriteLine();
            break;
        case 4:
            break;
    }

} while (choice != 4);
