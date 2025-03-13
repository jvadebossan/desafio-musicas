using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex4A
{
    //TODO Ranking dos 5 gêneros musicais com mais músicas.
    public static void Exec()
    {
        var generos = Program.musicas.GroupBy(musica => musica.Genero)
        .OrderByDescending(musica => musica.Count())
        .Take(5);

        int posicao = 1;
        foreach (var musica in generos)
        {
            Console.WriteLine($"{posicao}º Lugar: {musica.Key, -8} - {musica.Count()} músicas");
            posicao++;
        }
        // 1º Lugar: Pop      - 32 músicas
        // 2º Lugar: Reggae   - 25 músicas
        // 3º Lugar: Blues    - 21 músicas
        // 4º Lugar: Jazz     - 20 músicas
        // 5º Lugar: Country  - 18 músicas
    }
}
