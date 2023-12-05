#Documentação da Atividade de Programação em C# sobre POO

Título: Sistema de Gerenciamento de Biblioteca

Descrição:

Este documento descreve a atividade de programação em C#, que consiste no desenvolvimento de um sistema de gerenciamento de biblioteca. O sistema deve ser capaz de adicionar, buscar e remover livros, e deve implementar classes com herança, métodos com sobrecarga e uma propriedade protegida.

Requisitos:

A classe ItemBiblioteca deve ser uma classe abstrata que representa um item de biblioteca. Ela deve possuir duas propriedades públicas, Id e Titulo, e uma propriedade protegida, DescricaoInterna. O construtor da classe inicializa Id e Titulo e define um valor padrão para DescricaoInterna.
A classe Livro deve ser uma classe derivada de ItemBiblioteca. Ela deve possuir uma propriedade adicional, Autor, e um método para exibir a DescricaoInterna.
A classe Biblioteca deve gerenciar uma coleção de ItemBiblioteca. Ela deve possuir os seguintes métodos:
AdicionarItem: adiciona um item à coleção.
RemoverItem: remove um item da coleção.
BuscarItemPorTitulo: busca um item por título.
BuscarItemPorId: busca um item por ID.
A classe Program deve ser o ponto de entrada do sistema. Ela deve criar instâncias de Biblioteca e Livro, e demonstrar a adição, busca e remoção de livros.

Classe ItemBiblioteca:

A classe ItemBiblioteca é uma classe abstrata que representa um item de biblioteca. Ela possui as seguintes propriedades:

Id: identifica o item de biblioteca
Titulo: título do item de biblioteca
DescricaoInterna: descrição interna do item de biblioteca

Classe Livro:

A classe Livro é uma classe derivada de ItemBiblioteca. Ela possui uma propriedade adicional, Autor, e um método para exibir a DescricaoInterna.

Classe Biblioteca:

A classe Biblioteca gerencia uma coleção de ItemBiblioteca. Ela possui os seguintes métodos:

AdicionarItem: adiciona um item à coleção.
RemoverItem: remove um item da coleção.
BuscarItemPorTitulo: busca um item por título.
BuscarItemPorId: busca um item por ID.

Na atividade é utilizado os 4 Principais Pilares da programação, são eles:

                                       Abstração

A abstração permite que você se concentre nos aspectos essenciais de um objeto, ocultando detalhes desnecessários.

                                    Encapsulamento

O encapsulamento é o agrupamento de dados e comportamentos relacionados em um objeto.

                                      Herança

A herança permite que você crie novos objetos a partir de objetos existentes, reutilizando código e reduzindo a complexidade.

                                   Polimorfismo

O polimorfismo permite que você trate objetos diferentes da mesma forma, mesmo que eles tenham comportamentos diferentes.

Em resumo, os quatro pilares da POO são:

Abstração: esconder detalhes desnecessários
Encapsulamento: agrupar dados e comportamentos
Herança: reutilizar código
Polimorfismo: tratar objetos diferentes da mesma forma
Esses pilares permitem que você crie software mais organizado, eficiente e flexível.
