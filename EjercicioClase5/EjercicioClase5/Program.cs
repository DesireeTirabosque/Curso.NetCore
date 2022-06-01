var respuesta = "S";

while (respuesta.ToUpper() == "S")

{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola : {nombre}!");
    Console.WriteLine("Desea continuar ? (S/N)");
    respuesta = Console.ReadLine();
}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine(" Opción no válida");
}

