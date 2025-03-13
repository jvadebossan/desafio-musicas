using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex4B
{
    //TODO Ranking dos 3 álbuns com mais músicas.
    public static void Exec()
    {
        var albuns = Program.musicas.GroupBy(musica => musica.Album)
        .OrderByDescending(musica => musica.Count())
        .Take(3);

        int posicao = 1;
        foreach (var musica in albuns)
        {
            Console.WriteLine($"{posicao}º Lugar: {musica.Key,-8} - {musica.Count()} músicas");
            posicao++;
        }
        // 1º Lugar: Challenge Album - 2 músicas
        // 2º Lugar: Quality Album - 2 músicas
        // 3º Lugar: Program Album - 2 músicas
    }
}
