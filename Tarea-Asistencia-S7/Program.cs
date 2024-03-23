static void ejem1()
{
    //Delcaracion de un arreglo
    int[] calificaciones;

    float c = 0;

    //Creacion de un arreglo con valores inciales
    calificaciones = new int[] { 85, 92, 77, 68, 94, 45, 62, 84, 12, 36 };

    //Acceso a un elemento del arreglo 
    Console.WriteLine(calificaciones[2]); //Imprime 77

    foreach (int i in calificaciones)
    {
        Console.WriteLine(i);
        c = i + c;
    }
    c = c / calificaciones.Length;
    Console.WriteLine("\nEl promedio es: " + c + "\n");

    float p = 0, j = 0;
    for (int ñ = 0; ñ < calificaciones.Length; ñ++)
    {
        p = calificaciones[ñ];
        j = j + p;
        Console.WriteLine(calificaciones[ñ] + "");
    }
    j = j / calificaciones.Length;
    Console.WriteLine("\nEl promedio es de: " + j);
    Console.ReadKey();
}
static void ejem2()
{
    int[] melones = new int[] { 50, 20, 80, 90, 60, };
    Console.WriteLine("Original:\n");
    despliegue(melones);
    Array.Sort(melones);
    Console.WriteLine("\nOrdenados:\n");
    despliegue(melones);
    Array.Reverse(melones);
    Console.WriteLine("\nReverso:\n");
    despliegue(melones);

    //Buscar 90 y 105

    int papel = Array.IndexOf(melones, 90);
    Console.WriteLine("\n90 Se encuentra en la posicion: " + papel);
    papel = Array.IndexOf(melones, 105);
    Console.WriteLine("105 Se encuentra en la posicion: " + papel);

    bool pandepan = Array.Exists(melones, pan => pan >= 60);
    if (pandepan)
    {
        Console.WriteLine("\nSi hay aprobados");
    }
    Console.ReadKey();
}
static void despliegue(int[] arreglo)
{
    foreach (int i in arreglo)
    {
        Console.WriteLine(i);
    }
}

static void nombre()
{
    Console.Write("Ingrese los nombres separados por coma:");
    string sise = Console.ReadLine();
    string[] nombres = sise.Split(',');
    for (int i = 0; i < nombres.Length; i++)
    {
        nombres[i] = nombres[i].Trim();
    }
    Array.Sort(nombres);
    Console.WriteLine("Nombres ordenados:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
    Console.ReadKey();
}
static void orden()
{
    Console.Write("Ingrese una lista de números enteros separados por espacio:");
    string num = Console.ReadLine();
    string[] number = num.Split(' ');
    int[] numeros = new int[number.Length];
    for (int i = 0; i < number.Length; i++)
    {
        numeros[i] = int.Parse(number[i]);
    }
    int maximo = int.MinValue;
    int minimo = int.MaxValue;
    foreach (int numero in numeros)
    {
        if (numero > maximo)
        {
            maximo = numero;
        }
        if (numero < minimo)
        {
            minimo = numero;
        }
    }
    Console.WriteLine("El valor máximo es: " + maximo);
    Console.WriteLine("El valor mínimo es: " + minimo);
    Console.ReadKey();
}
static void pais()
{
    string[] p = { "ARGENTINA", "BRASIL", "GUATEMALA", "COLOMBIA", "PERU", "BOLIVIA" };
    Console.Write("Ingrese el nombre de un país:");
    string pb = Console.ReadLine().ToUpper();
    int ind = Array.IndexOf(p, pb);
    if (ind != -1)
    {
        Console.WriteLine("El país {0} fue encontrado en la posición {1} del arreglo.",pb,ind);
    }
    else
    {
        Console.WriteLine("El país {0} no fue encontrado en el arreglo.",pb);
    }
    Console.ReadKey();
}
static void numi()
{
    int[] numeros = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Arreglo original:");
    alrevez(numeros);
    Array.Reverse(numeros);
    Console.WriteLine("\nArreglo invertido:");
    alrevez(numeros);
    Console.ReadKey();
}
static void alrevez(int[] arreglo)
{
    foreach (int num in arreglo)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
static void calif()
{
    Console.Write("Ingrese una lista de calificaciones numéricas separadas por espacio:");
    string cali = Console.ReadLine();
    string[] calis = cali.Split(' ');
    int[] califica = new int[calis.Length];
    for (int i = 0; i < calis.Length; i++)
    {
        califica[i] = int.Parse(calis[i]);
    }
    bool gano = Array.Exists(califica, califi => califi >= 90);
    if (gano)
    {
        Console.WriteLine("Hay calificaciones sobresalientes (>= 90).");
    }
    else
    {
        Console.WriteLine("No hay calificaciones sobresalientes (>= 90).");
    }
    Console.ReadKey();
}
try
{
    int op = 7;
    do
    {
        Console.Clear();
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Ejemplo 1");
        Console.WriteLine("2. Ejemplo 2");
        Console.WriteLine("3. Mostrar nombre");
        Console.WriteLine("4. Encontrar países");
        Console.WriteLine("5. Encontrar menor y mayor");
        Console.WriteLine("6. Numeros invertirdos");
        Console.WriteLine("7. Verificar calificaciones");
        Console.WriteLine("8. Salir");
        Console.WriteLine();
        Console.Write("> ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op != 8)
        {
            switch (op)
            {
                case 1:
                    ejem1();
                    break;
                case 2:
                    ejem2();
                    break;
                case 3:
                    nombre();
                    break;
                case 4:
                    pais();
                    break;
                case 5:
                    orden();
                    break;
                case 6:
                    numi();
                    break;
                case 7:
                    calif();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
            Console.WriteLine();
        }
    } while (op != 8);
    Console.Clear();
    Console.WriteLine("Gracias por usar el programa :3");
}
catch (Exception error)
{
    Console.WriteLine();
    Console.WriteLine(error);
}

