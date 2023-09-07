/*
int age = 2;
if (age > 40)
{
    Console.WriteLine(" Du are middle age person");
    Console.WriteLine(" Its ok");
}
  Console.WriteLine("Its important you are learning");
*/

/*int age = 52;
string name = "Amjad";
if(age > 40 && name == "Amjad")
{
    Console.WriteLine(" you need to work hard");

}
else if (age > 40 || name == "Ali")
{
    Console.WriteLine(" you need to do your job");
}
 */

/*int num = 5;
string myName = "amjad";

if (name)

*/

/*int num = 2;
 switch (num)
{
    case 1:
        Console.WriteLine("This is one number");
     breake;
}
int age = 33;

//om <18
//  skriver man ut
// Barn/ungdom

if (age < 18)
{
    Console.WriteLine("Barn/Un´ungdum");
}

//om >18 men < 65

// skriver man ut Vuxen

else if (age > 18 && age < 65)
{
    Console.WriteLine(" Vuxan");
}

// Annars

//skriver man ut Pensionär


else
    {
    Console.WriteLine(" Pensionär");
   }

/////// my new commit for github
///

Console.WriteLine("Git hub");

int b = 10;
int h = 12;


double area = 0.5 * b * h;

Console.WriteLine(area);
*/

class Program {
    static void Main()
    {
        Person person = new Person("Amjad", 33);

        person.PrintInfo();

        Product product = new Product("Bannan", 12, 139.99);

        product.PrintInfo();

        Conditionalstatements conditionalstatement = new Conditionalstatements(10);
        conditionalstatement.CheckInput();

        Console.ReadLine();
    }

}
