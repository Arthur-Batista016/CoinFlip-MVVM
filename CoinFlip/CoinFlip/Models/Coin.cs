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
            LadoSorteado = new Random().Next(2) == 0 ? "cara" : "coroa";
            return (LadoSorteado);
        }




    }
}
