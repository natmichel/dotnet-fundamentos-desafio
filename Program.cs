using System;
using System.Collections.Generic;
class Program{
    static void Main(string[] args){
        decimal precoInicial = 0;
        decimal precoPorHora = 0;
        bool exibirMenu = true;
        
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial: ");
        precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Agora digite o preço por hora");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamento = new(precoInicial, precoPorHora);
        
        while(exibirMenu){
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Adicinar veiculo");
            Console.WriteLine("2 - Remover veiculo");
            Console.WriteLine("3 - Listar veiculos");
            Console.WriteLine("4 - Encerrar programa");
            switch(Console.ReadLine()){
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    exibirMenu = false;
                    break;
            }
        }
        Console.WriteLine("O programa se encerrou");
    }
}