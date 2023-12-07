Console.Clear();
Biblioteca b1 = new();// Instanciando Biblioteca


Console.WriteLine("---------Bem Vindo ao seu sistema de gerenciamento de Biblioteca--------- \n");
Console.WriteLine("-----Vamos começar adcionando alguns livros------ \n ");

b1.AdicionarItem();
Console.Clear();
b1.AdicionarItem();
Console.Clear();     //Adcionando Livros a Biblioteca
b1.AdicionarItem();
Console.Clear();
b1.AdicionarItem();
Console.Clear();

Console.WriteLine("Não gostou de alguma das escolhas? Tente remover algum!");

b1.RemoverItem(); //Chamando metodo de exclusão de algum Livro
Console.WriteLine("Livro Removido com sucesso!"); 
Console.Clear();

Console.WriteLine("Tente buscar por alguns deles.");

b1.BuscarItemPorId();  //Chamando Metodos de Busca

 Console.WriteLine($"Digite o titulo do livro o qual deseja ver as informações: ");
b1.BuscarItemPorTitulo(Console.ReadLine()); //Usando Metodo com sobrecarga

Console.WriteLine("\n ------Simulação Finalizada com Sucesso-------- \n");


