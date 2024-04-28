using System;
class Estacionamento{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<String> veiculos = new();

    public Estacionamento(decimal precoInicial, decimal precoPorHora){
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(){
        string? placa = "";
        
        Console.WriteLine("Digite a placa do veiculo para estacionar: ");
        placa = Console.ReadLine().ToUpper();
        
        if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
            Console.WriteLine("Essa placa já esta registrada.");
        }else{
            veiculos.Add(placa);
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
    public void RemoverVeiculo(){
        string? placa = "";
        
        Console.WriteLine("Digite a placa do veiculo para remover: ");
        placa = Console.ReadLine().ToUpper();
        
        //verifica se existe uma placa igual na lista
        for(int i = 0; i < veiculos.Count; ++i){
            if(veiculos[i].Equals(placa)){
                int horas = 0;
                decimal valorTotal = 0;
                
                veiculos.RemoveAt(i);
                Console.WriteLine("Digite o total de horas estacionadas: ");
                
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                Console.WriteLine($"O veiculo {placa} foi removido e o preço total foi de R${valorTotal}");
            }else{
                Console.WriteLine("Desculpe, esse veiculo não esta estacionado aqui. Confira se a placa digitada esta correta");
            }
        }
        

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
    public void ListarVeiculos(){
        if(veiculos.Any()){
            foreach (var veiculo in veiculos){
                Console.WriteLine($"{veiculo}");
            }
        }
        
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}