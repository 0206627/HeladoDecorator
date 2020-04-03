using System;
using System.Collections.Generic;
using HeladoDecorator.Models;

namespace HeladoDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipiente = menuRecipiente();

            int result = askQty();

            int[] helado = new int[result];

            for (int i=0; i<result; i++)
            {
                helado[i] = menuHelado(i);
            }

            List<int> extras = new List<int>();
            int cont = 0;

            while (cont < 3)
            {
                result = menuExtras(cont);
                if (result != 7)
                {
                    cont++;
                    extras.Add(result);
                }
                else break;
            }

            IHelado rec = construirRecipiente(recipiente);
            IngredienteDecorador aux;

            switch (helado[0])
            {
                case 1:
                    aux = new LimonDecorador(rec);
                    break;
                case 2:
                    aux = new FresaDecorador(rec);
                    break;
                case 3:
                    aux = new MangoDecorador(rec);
                    break;
                case 4:
                    aux = new ChocolateDecorador(rec);
                    break;
                case 5:
                    aux = new FresaDecorador(rec);
                    break;
                case 6:
                    aux = new ChocoChipsDecorador(rec);
                    break;
                case 7:
                    aux = new VainillaDecorador(rec);
                    break;
                default:
                    aux = new LimonDecorador(rec);
                    break;
            }

            for (int i=1; i<helado.Length; i++)
            {
                switch(helado[i])
                {
                    case 1:
                        aux = new LimonDecorador(aux);
                        break;
                    case 2:
                        aux = new FresaDecorador(aux);
                        break;
                    case 3:
                        aux = new MangoDecorador(aux);
                        break;
                    case 4:
                        aux = new ChocolateDecorador(aux);
                        break;
                    case 5:
                        aux = new ChocoChipsDecorador(aux);
                        break;
                    case 6:
                        aux = new VainillaDecorador(aux);
                        break; 

                }
            }

            for (int i = 0; i < extras.Count; i++)
            {
                switch (extras[i])
                {
                    case 1:
                        aux = new ChocolateLiquidoDecorador(aux);
                        break;
                    case 2:
                        aux = new ChocoKrispisDecorador(aux);
                        break;
                    case 3:
                        aux = new LunetasDecorador(aux);
                        break;
                    case 4:
                        aux = new ChispasColoresDecorador(aux);
                        break;
                    case 5:
                        aux = new FresasDecorador(aux);
                        break;
                    case 6:
                        aux = new PlatanoDecorador(aux);
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Pedido:");
            Console.WriteLine($"{aux.ObtenerDescripcion()} ...... ${aux.ObtenerCosto()}");

        }

        public static int menuRecipiente()
        {

            var result = -1;

            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("Elegir recipiente:");
                Console.WriteLine("1. Vaso $0.0");
                Console.WriteLine("2. Barquillo $0.50");
                Console.WriteLine("3. Canasta $1.00");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result == 1 || result == 2 || result == 3) return result;
                    else result = -1;
                }
            }

            return result;

        }

        public static int askQty()
        {

            int result = -1;

            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("¿Cuántas bolas de helado? (Máximo 5 bolas)");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result > 5 || result < 1) result = -1;
                }

            }

            return result;

        }

        public static IHelado construirRecipiente(int recipiente)
        {

            switch(recipiente)
            {
                case 1:
                    return new VasoHelado();
                case 2:
                    return new BarquilloHelado();
                case 3:
                    return new CanastaHelado();
                default:
                    return new VasoHelado();
            }

        }

        public static int menuHelado(int num)
        {

            var result = -1;

            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine($"Elegir bola de helado ({num+1}) :");
                Console.WriteLine("1. Limón $5.00");
                Console.WriteLine("2. Fresa $5.00");
                Console.WriteLine("3. Mango $6.00");
                Console.WriteLine("4. Chocolate $8.00");
                Console.WriteLine("5. ChocoChips $8.00");
                Console.WriteLine("6. Vainilla $7.00");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result > 0 && result < 7) return result;
                    else result = -1;
                }
            }

            return result;

        }

        public static int menuExtras(int num)
        {
            var result = -1;

            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine($"Elegir extra: ({num+1})");
                Console.WriteLine("1. Chocolate Líquido $0.00");
                Console.WriteLine("2. ChocoKrispis $0.50");
                Console.WriteLine("3. Lunetas $0.70");
                Console.WriteLine("4. Chispas Colores $0.20");
                Console.WriteLine("5. Fresas $7.00");
                Console.WriteLine("6. Platano $5.00");
                Console.WriteLine("7. Terminar pedido");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result > 0 && result < 8) return result;
                    else result = -1;
                }
            }

            return result;

        }
    }
}
