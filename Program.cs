
// declaracion de variables
string name;
string dni;
string dniAcompañante;
int age;
string dest;
int flightClass = 0;
int baggage = 0;
int handLug = 0;
int dog = 0;





// Mensaje de bienvenida
Console.WriteLine("\r\n████████████████████████████████████████████████████████████\r\n█▄─▄─▀█▄─▄█▄─▄▄─█▄─▀█▄─▄█▄─█─▄█▄─▄▄─█▄─▀█▄─▄█▄─▄█▄─▄▄▀█─▄▄─█\r\n██─▄─▀██─███─▄█▀██─█▄▀─███▄▀▄███─▄█▀██─█▄▀─███─███─██─█─██─█\r\n▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀");
Console.WriteLine("\r\n███████\r\n██▀▄─██\r\n██─▀─██\r\n▀▄▄▀▄▄▀");
Console.WriteLine("\r\n████████████████████████████████████████████████████████████████████████\r\n█─▄▄▄─█─█─█▄─▄▄─█─▄▄▄─█▄─█─▄███▀▀▀▀▀████▄─▄█▄─▀█▄─▄█▄─▀█▄─▄█▄─▄▄─█▄─▄▄▀█\r\n█─███▀█─▄─██─▄█▀█─███▀██─▄▀██████████████─███─█▄▀─███─█▄▀─███─▄█▀██─▄─▄█\r\n▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▀▀▀▀▀▀▀▀▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Presiona ENTER para empezar. . .");

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.ResetColor();
Console.ReadLine();

// Solicitud de datos inicial
Console.WriteLine("¡Hola!");
Console.WriteLine("");
Console.WriteLine("¿Cual es tu nombre?");
name=Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Perfecto!" + " name");
Console.WriteLine("¿Cual es tu DNI?");
dni= Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Muy bien!");
Console.WriteLine("¿Cuantos años tienes?");
age=int.Parse(Console.ReadLine());

Console.WriteLine("");

//validacion de edad
if (age < 18)
{
    if (age >= 2 && age < 5)
    {
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }
}
else if (age >= 5 && age<=11)
{
    int servicioMenorNoAcompañado = 0;

    Console.WriteLine("¿Deseas solicitar el servicio de menor no acompañado?");
    Console.WriteLine("Ingresa 1:Si o 2:No");
    Console.WriteLine("Muy bien!");
    servicioMenorNoAcompañado=int.Parse(Console.ReadLine());
    if (servicioMenorNoAcompañado<2)
    {
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }
    
}

//equipaje



Console.ResetColor();





