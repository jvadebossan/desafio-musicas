using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex4C
{
    //TODO Ranking dos 5 países que mais lançaram músicas.
    public static void Exec()
    {
        var paises = Program.musicas.GroupBy(musica => musica.Pais)
        .OrderByDescending(musica => musica.Count())
        .Take(5);

        int posicao = 1;
        foreach (var musica in paises)
        {
            Console.WriteLine($"{posicao}º Lugar: {musica.Key,-9} - {musica.Count()} músicas");
            posicao++;
        }
        // 1º Lugar: France    - 26 músicas
        // 2º Lugar: Canada    - 24 músicas
        // 3º Lugar: Germany   - 23 músicas
        // 4º Lugar: Australia - 22 músicas
        // 5º Lugar: Italy     - 21 músicas
    }
}
