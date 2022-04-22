// See https://aka.ms/new-console-template for more information


using LogicalPrograms;

Console.WriteLine("Welcome to Logical Programmiing!");


while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)Febinocciseries\n2)PerfectNumber");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Febinocciseries febinocci = new();
            febinocci.febinocciseries();
            break;
        case 2:
            PerfectNumber perfectNumber = new ();
            perfectNumber.perfefctnumber();
            break;
        default:
            break;
    }
}