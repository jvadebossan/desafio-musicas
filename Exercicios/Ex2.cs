using System;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex2
{
    //TODO Quantos artistas únicos temos na nossa base de dados?
    public static void Exec()
    {
        var artistasUnicos = Program.musicas.DistinctBy(musica => musica.Artista);

        Console.WriteLine($"Temos {artistasUnicos.Count()} artistas diferentes cadastrados em nossa base.");
        //Temos 10 artistas diferentes cadastrados em nossa base.
    }
}
