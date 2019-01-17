using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            Calculadora calc=new Calculadora();
            do{                
                Console.WriteLine("");
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicacion");
                Console.WriteLine("4- Division");
                Console.WriteLine("5- Salir ");
                Console.WriteLine("");
                Console.Write("Que operacion deseas realizar: ");
                int opc=int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if(opc!=5){
                    Console.WriteLine("Ingresa el primer numero: ");
                    double num1=double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero: ");
                    double num2=double.Parse(Console.ReadLine());
                    //int opc=int.Parse(Console.ReadLine());
                    switch(opc){
                        case 1:                        
                            Console.WriteLine("La suma de tus numero es: "+calc.sumarNum(num1,num2));
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        break;
                        case 2:                        
                            Console.WriteLine("La resta de tus numero es: "+calc.restarNum(num1,num2));
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        break;
                        case 3:                        
                            Console.WriteLine("La multiplicacion de tus numero es: "+calc.multiNum(num1,num2));
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        break;
                        case 4:                        
                            Console.WriteLine("La division de tus numero es: "+calc.divNum(num1,num2));
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        break;
                        case 5:
                            
                            flag=false;
                        break;
                        default:
                            Console.WriteLine("Cerrando aplicacion...");
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            flag=false;
                        break;
                    }
                }else{
                    flag=false;
                    Console.WriteLine("Cerrando aplicacion...");
                    Console.WriteLine("");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                
            }while(flag!=false);                                                            
        }
    }
    class Calculadora
    {
        public double sumarNum(double num1, double num2){
            double suma=num1+num2;
            return suma;
        }
        public double restarNum(double num1, double num2){
            double resta=num1-num2;
            return resta;
        }
        public double multiNum(double num1, double num2){
            double multi=num1*num2;
            return multi;
        }
        public double divNum(double num1, double num2){
            double div=num1/num2;
            return div;
        }
    }
}
