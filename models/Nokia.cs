using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO_POO.models
{
   public class Nokia : Smartphone
    {
         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeDoApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeDoApp} em seu Nokia.");
        }
    }
}