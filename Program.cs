namespace c__introduksjon;

class Program
{
    static void Main(string[] args)
    {
        // string datatype
        string helloWorld = "Hello, World!";
        // heltalls variabel
        int myNumber = 10;
        // desimaltallsvariabel
        double myDecimal = 10.25;

        // printer variablene til konsollem med Console-klassen
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber + 10.5);
        Console.WriteLine(myDecimal);


        // Skriver ut en melding til brukeren og ber om et navn.

        Console.WriteLine("Hei, hva heter du?");

        // Tar verdien brukeren skriver inn og printer den ut i en melding i konsollen.
        string? navn = Console.ReadLine();
        Console.WriteLine("Hei " + navn);

        // Char-typen: en bestemt bokstav

        char a = 'A';
        char b = 'B';
        Console.WriteLine(a + b);


    }
}
