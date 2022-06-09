/*Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.WriteLine("Ingrese la cantidad de filas de la matriz");
int filas=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
int columnas=int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];

double[] promedios= new double[columnas];
//cantidad de filas
int lengthFilas=numeros.GetUpperBound(0) + 1;

//cantidad de columnas
int lengthColumnas=numeros.GetUpperBound(1) + 1;

double acumuladorColumnas = 0, prom=0;

for (int i = 0; i < lengthColumnas; i++)
{
    acumuladorColumnas = 0;
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine("Cargue el numero que contendrá la columna " + (i+1) + " de la matriz");
        numeros[j,i] = int.Parse(Console.ReadLine());
     
        acumuladorColumnas=acumuladorColumnas + numeros[j,i];
        prom = acumuladorColumnas / filas;
        promedios[i]= prom;

    }
    
    Console.WriteLine();
}
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine("El promedio de la columna " + (i + 1) + " es de: " + (promedios[i]));
}
