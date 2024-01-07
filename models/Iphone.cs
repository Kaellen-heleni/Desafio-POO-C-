using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_DIO_POO.models;

namespace Projeto_DIO_POO.models
{
    public class Iphone : Smartphone
    {
         public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeDoApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeDoApp} em seu Iphone.");
        }
    }
}