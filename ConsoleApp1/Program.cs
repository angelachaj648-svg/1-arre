//Solicitar al usuario la cantidad n de números, guardarlos en un arreglo y mostrarlos en pan

Console.Write("Cantidad: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
	Console.Write("Número: ");
	numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
	Console.Write(numeros[i] + " ");
}

