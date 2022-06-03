// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

Console.Clear();
int n = 0;
int numeroIngresado = 0;
do
{
    Console.WriteLine("Ingrese un número intentando adivinar el número secreto " +
    "elegido por la computadora (Num comprendido entre 1 -21) ");
    numeroIngresado = int.Parse(Console.ReadLine());

    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es muy grande");
        n++;
    }
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es menor al numero secreto");
        n++;
    }
    if (numeroIngresado == numeroSecreto)
    {
        Console.WriteLine($"FELICIDADES, has adivinado el número secreto que era:  {numeroSecreto}, Lo has logrado en {n} intentos!!");
    }
} while (numeroIngresado != numeroSecreto);

