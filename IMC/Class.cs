using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    public class Classimc
    {

        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }
        String Estado = "";
        Char Opcion = ' ';
        public const string mens = "¡IMC cuida tu salud!";


        public string prueba()
        {
           
         
            //Se piden los datos de la persona y se pasan a la clase persona por medio del objeto persona

            Console.WriteLine("Introduce el nombre de la persona.");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su peso");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su sexo");
            sexo = char.Parse(Console.ReadLine());


            //Realizar Calculo
           
            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            imc = pesoKG / altu;
            
            
            //Determinar estado de la persona

            if (edad >= 18)
            {

                if (imc < 18.5)
                {
                    Estado = "BAJO PESO , DEBERIAS CONSULTAR CON UN MEDICO DE CONFIANZA.";
                }

                if ((imc >= 18.5) && (imc < 25))
                {
                    Estado = "EXCELENTE TE ENCUENTRAS EN UN PESO NORMAL";
                }

                if ((imc >= 25) && (imc < 30))
                {
                    Estado = "SOBREPESO";
                }
                if ((imc >= 30) && (imc < 40))
                {
                    Estado = "DEBERIAS CUIDARTE, TE ENCUENTRAS EN PESO OBESO";
                }
                if (imc >= 40)
                {
                    Estado = "VISITA TU MEDICO DE CONFIANZA TU PESO ES OBESO MORBIDO, PUEDE TRAER SERIOS DAÑOS. ";

                }//fin de ifs
            }
            else
            {
                if (imc < 14.4)
                {
                    Estado = "Niñ@_Bajo Peso, Deberias consultar con un medico de confianza. ";
                }

                if ((imc >= 14.5) && (imc < 17))
                {
                    Estado = "Niñ@_ Normal, excelente sigue asi...";
                }

                if ((imc >= 18) && (imc < 19))
                {
                    Estado = "Niñ@_sObrepeso,";
                }
                if ((imc >= 19.1) && (imc < 40))
                {
                    Estado = "Niñ@_Obeso , Deberias consultar con un medico, puesto que no te encuentras con el mejor resultado.";
                }
                if (imc >= 40)
                {
                    Estado = "Niñ@_Obeso Morbido, demasiado arriesgozo.";

                }
            }



            Console.WriteLine("Su IMC es de :" + imc);
            Console.WriteLine("Su estado es :" + Estado);



            return mens.ToString();


        }

       
    }
}






