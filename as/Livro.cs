public class Livro : ItemBiblioteca  // Classe com herança
{
    public string Autor { get; set; }

    public Livro(int id, string titulo, string autor) : base(id,titulo)
    {
        this.Autor = autor;
        Console.WriteLine("Digite aqui uma descrição para seu Livro"); //Colhendo Descrição do livro quando ele é instanciado
        this.DescricaoInterna = Console.ReadLine();
    }
    public string ExibirDescricaoInterna()  //Acessando propriedade protegida por meio de um metodo
    {
        return DescricaoInterna;
    }
}