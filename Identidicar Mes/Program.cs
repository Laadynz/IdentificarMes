IndentificarMes(5);
static void IndentificarMes(int mes)
{
    string[] meses = { "Enero", "Febrero", "Marzo", "Abri", "Mayo", "Junio", "Julio", "Agosto",
    "Septiembre","Octubre", "Noviembre", "Diciembre"};
    Console.WriteLine(meses[mes - 1]);
    Console.WriteLine($"El mes con el número {mes} es: {meses[(mes - 1)]}");


}
Console.WriteLine("Introduce el mes");
int mesRecibido = int.Parse(Console.ReadLine());
IndentificarMes(mesRecibido);

