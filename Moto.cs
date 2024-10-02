public class Moto : Veiculo
{
    private bool TemBagageiro;

    public Moto(bool bagage, string marca, string modelo, int ano)
    :base(marca,modelo,ano)
    {
        TemBagageiro = bagage;
    }

    public void DarGrau(){
        Console.WriteLine("Randandandan");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {Marca}, Modelo:{Modelo}, Ano:{Ano}, Tem Bagageiro:{TemBagageiro}");
    }
}