int[] numeros = new int[10];
int n;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el numero: {i+1}");

    n= int.Parse(Console.ReadLine());
    numeros[i]=n;
}
Console.WriteLine("Los valores son: ");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(numeros[i]);
}

int max = numeros[0], min = numeros[0], suma=0;
double promedio = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma+=numeros[i];
    promedio = suma / numeros.Length;
    if (numeros[i] > max)

        max = numeros[i];


    else if (numeros[i] < min)

        min = numeros[i];
}
Console.WriteLine();
Console.WriteLine($"El valor de la suma de los números ingresados es: {suma}");
Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
Console.WriteLine($"El mayor número es: {max}");
Console.WriteLine($"El menor número es:  {min}");
