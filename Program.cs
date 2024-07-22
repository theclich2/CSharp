using System;
using System.Collections.Generic;

namespace HelloWorld {
    class HelloWorld {
        static void Main(string[] args) {
            Console.WriteLine("Hola, C#");
            /* Comentarios 
               de 
               diferentes
               lineas
            */
            // De diferentes tipos.

            string frase1 = "Esto es una cadena de texto";
            frase1 = "Cambio del valor de la cadena de texto";
            Console.WriteLine(frase1);

            int n1 = 2;
            int n2 = 5;
            n1 += 2;
            Console.WriteLine(n1);

            double n3 = 6.5;
            Console.WriteLine(n3);

            Console.WriteLine(n1 + n2 + n3);

            dynamic mydynamic = 6;
            mydynamic = "Mi dato dinámico";
            Console.WriteLine(mydynamic + n1);

            var frase2 = "Mi nueva cadena de texto";
            Console.WriteLine(frase2);

            bool boleano = true;
            Console.WriteLine(boleano);

            var myvar = "Mi variable de tipo inferido";
            // myvar = 6; // Error: cannot implicitly convert type 'int' to 'string'
            Console.WriteLine(myvar);

            Console.WriteLine($"El valor de mi entero es: {n1} y el de mi bool es: {boleano}");

            const string const1 = "Mi constante";
            Console.WriteLine(const1);

            // Estructuras

            var myArray = new string[] { "Diego", "Benito", "19" };
            for (int i = 0; i < myArray.Length; i++) {
                Console.WriteLine(myArray[i]);
            }

            var mydictionary = new Dictionary<string, int> {
                { "Diego", 19 },
                { "Mon", 21 },
                { "Alejandra", 18 },
                { "Edgar", 21 }
            };
            Console.WriteLine(mydictionary["Mon"]);

            var mySet = new HashSet<string> { "Diego", "Benito", "Diego", "19" };

            var mytuple = ("Diego", "Benito", "Martinez");
            Console.WriteLine(mytuple);

            for (int i = 0; i < 11; i++) {
                Console.WriteLine(i);
            }

            foreach (var myItem in mySet) {
                Console.WriteLine(myItem);
            }

            if (n1 < n2) {
                Console.WriteLine("N1 es menor que n2");
            } else {
                Console.WriteLine("No es menor que n2");
            }

            Console.WriteLine(MyFunction(5));

            // Clases
            var myclass1 = new MyClass("Diego");
            Console.WriteLine(myclass1.MyName);
        }

        static int MyFunction(int n1) {
            Console.WriteLine("Mi función");
            return 10 + n1;
        }
    }

    class MyClass {
        public string MyName { get; set; }
        
        public MyClass(string myname) {
            MyName = myname;
        }
    }
}
