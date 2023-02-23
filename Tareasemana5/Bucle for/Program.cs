
Console.WriteLine("Digita el primer numero");
String dato = Console.ReadLine();
int a = Convert.ToInt32(dato);

Console.WriteLine("Digita el segundo numero");
String dato2 = Console.ReadLine();
int datonum2 = Convert.ToInt32(dato2);

for (int i = a; i < datonum2; i++)
{
    if (i % 2 == 0)
    {
     Console.WriteLine(i);
    }
   
}