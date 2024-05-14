using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstract_exercise.Models;

namespace Abstract_exercise.Interfaces
{
    //em vez de class deve colocar interface
    public interface ICalculadora
    {
        // /Metodos sem corpo são obrigatorios na implementação como os seguintes:
        int Somar(int num1, int num2);
        int Subtrair (int num1, int num2);
        int Multiplicar (int num1, int num2);
        int Dividir (int num1, int num2);

        //Metodos com corpo são opcionais na implementação
        int Dividir (int num1, int num2)
        {
            return num1, num2;
        }



    }
}