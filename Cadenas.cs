namespace practico{

    class Cadenas{
        
        public static void ejercicio1()        
        {
            Console.WriteLine("C.1. Ingrese una cadena para contar las palabras:");
            string cadena = Console.ReadLine()!;
            int cantidad = ContarPalabras(cadena);
            Console.WriteLine("La cantidad de palabras en la cadena es: " + cantidad);
            Console.WriteLine();
        }
        static int ContarPalabras(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            return palabras.Length;
        }
        // ---------------------------------------------

        public static void ejercicio2()  
        {
            Console.WriteLine("C.2. Ingrese una cadena para eliminar las vocales:");
            string cadena = Console.ReadLine()!;
            string resultado = EliminarVocales(cadena);
            Console.WriteLine("La cadena sin vocales es: " + resultado);
            Console.WriteLine();
        }
        static string EliminarVocales(string cadena)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char vocal in vocales)
            {
                cadena = cadena.Replace(vocal.ToString(), "");
            }
            return cadena;
        }
        // --------------------------------------------------------------------

        public static void ejercicio3()
        {
            Console.WriteLine("C.3. Ingrese una cadena para encontrar la palabra más larga:");
            string cadena = Console.ReadLine()!;
            string palabraMasLarga = EncontrarPalabraMasLarga(cadena);
            Console.WriteLine("La palabra más larga en la cadena es: " + palabraMasLarga);
            Console.WriteLine();
        }
        static string EncontrarPalabraMasLarga(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            string palabraMasLarga = "";
            foreach (string palabra in palabras)
            {
                if (palabra.Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra;
                }
            }
            return palabraMasLarga;
        }
        // ----------------------------------------------------

        public static void ejercicio4()
        {
            Console.WriteLine("Ingrese una cadena para eliminar la primera letra de cada palabra:");
            string cadena = Console.ReadLine()!;
            string resultado = EliminarPrimerLetra(cadena);
            Console.WriteLine("La cadena con la primera letra de cada palabra eliminada es: " + resultado);
            Console.WriteLine();
        }
        static string EliminarPrimerLetra(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 1)
                {
                    palabras[i] = palabras[i].Substring(1);
                }
                else
                {
                    palabras[i] = "";
                }
            }
            return string.Join(" ", palabras);
        }
        // -----------------------------------------

        public static void ejercicio5()
        {
            Console.WriteLine("Ingrese una cadena para intervenir las palabras:");
            string cadena = Console.ReadLine()!;
            string resultado = IntervenirPalabras(cadena);
            Console.WriteLine("La cadena con las palabras intervenidas es: " + resultado);
            Console.WriteLine();
        }
        static string IntervenirPalabras(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = InvertirPalabra(palabras[i]);
            }
            return string.Join(" ", palabras);
        }
        static string InvertirPalabra(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            return new string(letras);
        }
    }
}