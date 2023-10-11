class Program
{
    static void Main()
    {
        // Paso 1: Crea una lista de objetos
        List<object> mixedList = new List<object>();

        // Paso 2: Agrega valores a la lista
        mixedList.Add(7);
        mixedList.Add(28);
        mixedList.Add(-1);
        mixedList.Add(true);
        mixedList.Add("chair");

        // Paso 3: Imprime todos los valores de la lista
        Console.WriteLine("Valores en la lista:");
        foreach (var item in mixedList)
        {
            Console.WriteLine(item);
        }

        // Paso 4: Suma los valores que son de tipo int
        int sum = SumarValoresInt(mixedList);
        Console.WriteLine($"La suma de los valores tipo int es: {sum}");
    }
    static int SumarValoresInt(List<object> lista)
    {
        int suma = 0;
        foreach (var item in lista)
        {
            if (item is int)
            {
                suma += (int)item;
            }
        }
        return suma;
    }
}