using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO_POO.models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria){
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;

    }
    public string getModelo() => Modelo;
    public string getIMEI() => IMEI;
    public int getMemoria() => Memoria;

    public void Ligar(){
        Console.WriteLine($"Ligando o smartphone {getModelo()} ....");
    }
    public void ReceberLigacao(){
        Console.WriteLine($"Recebendo uma ligação do número {Numero}....");

    }
    public abstract void InstalarAplicativo(string nomeDoApp);
    public void VisualizarSmartphone(){
        Console.WriteLine("Dados do seu Smartphone: ");
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Modelo: {getModelo()}");
        Console.WriteLine($"IMEI: {getIMEI()}");
        Console.WriteLine($"Memória disponível: {getMemoria()} GBs");
    }
    public void DesligarSmartphone(){
        Console.WriteLine($"Desligando aparelho {getModelo()}");
    }
    }
    
}