using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    internal class Coin
    {

        public string Lado { get; set; }
        public string LadoSorteado { get; set; }


        public Coin()
        {
        }


        public String Jogar()
        {
            //operador Ternario (?) basicamnete um if resumido (sempre devolve valor)//
            return (new Random().Next(0, 2) == 0) ? "Cara" : "Coroa";
        }




    }
}
