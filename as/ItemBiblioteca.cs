public abstract class ItemBiblioteca  //Criando Classe Abstrata 
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; }  //Propriedade Protegida

    public ItemBiblioteca(int id, string titulo) //Inicializando Construtor
    {
        this.Id = id;
        this.Titulo = titulo;
        this.DescricaoInterna = " - Descrição Padrão -";
    }
}