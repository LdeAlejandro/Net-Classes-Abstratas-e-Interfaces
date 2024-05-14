
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstract_exercise.Models;

namespace Abstract_exercise.Models
{
    public class Diretor: Professor
    {

        //só é possivel mudar o comportamento ou sobreescrever o metodo se nao tiver sealed no pai da classe em este caso Professor (nao seria possivel ja que o metodo no pai esta como sealed)
         public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }

    }
}