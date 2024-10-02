public class Carro : Veiculo
{
    private int numeroDePortas;

    public Carro(int numDePortas, string marca, string modelo, int ano)
    :base(marca,modelo,ano)
    {
        numeroDePortas = numDePortas;

    }
    public void AbrirMalas(){
        Console.WriteLine("Porta malas Aberto");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"{Marca},{Modelo},{Ano}, {numeroDePortas}");
    }
}
