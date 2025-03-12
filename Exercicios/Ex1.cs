using System;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex1
{
    //TODO Qual é a maior duração de uma música? 
    public static void Exec()
    {
        var maiorMusica = Program.musicas.MaxBy(music => music.Duracao);

        Console.WriteLine($"Música: {maiorMusica.Nome} - {maiorMusica.Duracao:0} minutos");

        //Música: Green - 6 minutos
    }
}
