// See https://aka.ms/new-console-template for more information


using LogicalPrograms;

Console.WriteLine("Welcome to Logical Programmiing!");


while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)Febinocciseries\n2)PerfectNumber\n3)PrimeNumber\n4)ReverseNumber");
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
        case 3:
            PrimeNumber primeNumber = new ();
            primeNumber.primenumber();
            break;
        case 4:
            ReverseNumber reverseNumber = new ();
            reverseNumber.reversenumber();
            break;
        default:
            break;
    }
}