class Carro
{

    public string Nome { get; set; }

    public int Ano { get; set; }

    public string Cor { get; set; }

    public string DescricaoCompleta => $"Nome do carro: {Nome}\nAno: {Ano}\nCor: {Cor}\n";

    public void ExibirInfos() {

        Console.WriteLine(DescricaoCompleta);
    
    }

}