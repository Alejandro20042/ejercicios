namespace ejercicios
{
    internal class Program
    {
        static void Main()
        {
            // a) Declara y crea el arreglo t de dos por tres
            int[,] t = new int[2, 3];

            // b) Filas en t
            int filas = t.GetLength(0);

            // c) Columnas en t
            int columnas = t.GetLength(1);

            // d) Total de elementos en t
            int totalElementos = filas * columnas;

            // e) Expresiones de acceso para la fila 1 de t
            int fila1Elemento0 = t[1, 0];
            int fila1Elemento1 = t[1, 1];
            int fila1Elemento2 = t[1, 2];

            // f) Expresiones de acceso para la columna 2 de t
            int columna2Elemento0 = t[0, 2];
            int columna2Elemento1 = t[1, 2];

            // g) Asignar cero al elemento de t en la fila 0 y la columna 1
            t[0, 1] = 0;

            // h) Inicializar cada elemento de t con cero sin usar repetición
            t[0, 0] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            // i) Inicializar cada elemento de t con cero usando un bucle for anidado
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    t[i, j] = 0;
                }
            }

            // j) Recibir valores de los elementos de t desde el usuario usando un bucle for anidado
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para t[{i},{j}]: ");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // k) Encontrar el valor más pequeño en t
            int minimo = t[0, 0];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (t[i, j] < minimo)
                    {
                        minimo = t[i, j];
                    }
                }
            }
            Console.WriteLine($"El valor más pequeño en t es: {minimo}");

            // l) Imprimir los elementos de la primera fila de t
            Console.WriteLine($"Elementos de la primera fila de t: {t[0, 0]}, {t[0, 1]}, {t[0, 2]}");

            // m) Totalizar los elementos de la tercera columna de t
            int totalColumna3 = t[0, 2] + t[1, 2];

            // n) Imprimir el contenido de t en formato tabular
            Console.WriteLine("Contenido de t en formato tabular:");
            Console.WriteLine("Columna 0\tColumna 1\tColumna 2");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine($"{t[i, 0]}\t\t{t[i, 1]}\t\t{t[i, 2]}");
            }
        }

    }
}