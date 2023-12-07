public class Biblioteca
{
    public List<ItemBiblioteca> colecaoDaBiblioteca = new List<ItemBiblioteca>(); //Criando Coleção

    public void AdicionarItem() // Criando metodo de adição de Livro a Biblioteca
    {
        int id = colecaoDaBiblioteca.Count() + 1;

        Console.WriteLine("Digite o titulo do livro o qual você quer adcionar a biblioteca:");
        string titulo = Console.ReadLine().ToLower();

        Console.WriteLine("Agora insira qual o autor do livro que você adicionou:");
        string autor = Console.ReadLine();

        Livro livro = new(id, titulo, autor);
        Console.WriteLine("Livro Adicionado Com Sucesso!!");
        Console.WriteLine("Digite qualquer tecla para continuar.");
        Console.ReadKey();
        colecaoDaBiblioteca.Add(livro);

    }

    public void RemoverItem() //Metodo de Remoção de Item pelo ID
    {
        foreach (Livro livro in colecaoDaBiblioteca)
        {
            Console.WriteLine($"Id: {livro.Id}\nTitulo: {livro.Titulo}");
        }
        Console.WriteLine($"Digite o ID do livro o qual deseja remover: ");

        int remove = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Livro removido com sucesso!");
        Console.WriteLine("Digite qualquer tecla para continuar.");
        Console.ReadKey();

        colecaoDaBiblioteca.RemoveAt(remove - 1);
        foreach (Livro element in colecaoDaBiblioteca)
        {
            if (element.Id > remove)
            {
                element.Id--;
            }
        } 
        
    }
    public void BuscarItemPorTitulo() //Metodo para Buscar Livro por seu titulo
    {
        Console.WriteLine($"Digite o titulo do livro o qual deseja ver as informações: ");
        string nomeLivro = Console.ReadLine().ToLower();
        bool achado = false;

        foreach (Livro element in colecaoDaBiblioteca)
        {
            if (element.Titulo.Contains(nomeLivro))
            {   
                Console.WriteLine("------------------- \n");
                Console.WriteLine($"\nId - {element.Id}\nTitulo - {element.Titulo}\nAutor - {element.Autor} \nDescrição interna:\n {element.ExibirDescricaoInterna()}");
                Console.WriteLine("\n -------------------");
                achado = true;
                break;
            }
        }
        if (achado == false)
        {
            Console.WriteLine("\nLivro não encontrado.");
        }
    }
    public void BuscarItemPorTitulo(string titulo) //Mesmo metodo de cima porem com sobrecarga
    {
        bool achado = false;

        foreach (Livro element in colecaoDaBiblioteca)
        {
            if (element.Titulo.Contains(titulo))
            {
                Console.WriteLine("------------------- \n");
                Console.WriteLine($"\nId - {element.Id}\nTitulo - {element.Titulo}\nAutor - {element.Autor} \nDescrição interna:\n {element.ExibirDescricaoInterna()}");
                Console.WriteLine("\n -------------------");
                achado = true;
                break;
            }
        }
        if (achado == false)
        {
            Console.WriteLine("\nLivro não encontrado.");
        }
        
        Console.WriteLine("Aqui estão as informações do Livro encontrado.");
        Console.WriteLine("Digite qualquer tecla para continuar.");
        Console.ReadKey();
        Console.Clear();

    }
    public void BuscarItemPorId() //Metodo para buscar o Livro por seu ID
    {
        foreach (Livro livro in colecaoDaBiblioteca)
        {
            Console.WriteLine($"Id: {livro.Id}\nTitulo: {livro.Titulo}");
        }
        Console.WriteLine($"Digite o ID do livro que voce quer ver as informações: ");
        int info = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (Livro item in colecaoDaBiblioteca)
        {
            if (info == item.Id)
            {
                Console.WriteLine("------------------- \n");
                Console.WriteLine($"\nTitulo: {item.Titulo}\nAutor: {item.Autor} \nDescrição interna: {item.ExibirDescricaoInterna()} \n");
                Console.WriteLine("\n -------------------");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.Write("\nLivro não encontrado.");
        }
        Console.WriteLine("Aqui estão as informações do Livro encontrado.");
        Console.WriteLine("Digite qualquer tecla para continuar.");
        Console.ReadKey();
        Console.Clear();
    }
    public void BuscarItemPorId(int id) // Mesmo metodo de busca por ID porem com sobrecarga 
    {
        bool encontrado = false;
        foreach (Livro item in colecaoDaBiblioteca)
        {
            if (id == item.Id)
            {
                Console.WriteLine($"\nId: {item.Id}\nTitulo: {item.Titulo}\nAutor: {item.Autor} \nDescrição interna: {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.Write("\nLivro não encontrado.");
        }
    }

}