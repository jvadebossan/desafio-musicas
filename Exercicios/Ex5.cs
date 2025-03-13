using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex5
{
    //TODO Em relação às gravadoras, quantas temos em nossa base? Crie um ranking das 5 gravadoras com mais músicas lançadas. 
    public static void Exec()
    {
        var totalGravadoras = Program.musicas.DistinctBy(musica => musica.Gravadora).Count();
        var gravadoras = Program.musicas.GroupBy(musica => musica.Gravadora)
        .OrderByDescending(musica => musica.Count())
        .Take(5);


        Console.WriteLine($"Temos {totalGravadoras} gravadoras cadastradas em nossa base.");
        int posicao = 1;
        foreach (var musica in gravadoras)
        {
            Console.WriteLine($"{posicao}º Lugar: {musica.Key,-15} - {musica.Count()} músicas");
            posicao++;
        }
        // Temos 5 gravadoras cadastradas em nossa base.
        // 1º Lugar: Warner Music    - 45 músicas
        // 2º Lugar: Capitol Records - 43 músicas
        // 3º Lugar: EMI             - 39 músicas
        // 4º Lugar: Universal Music - 37 músicas
        // 5º Lugar: Sony Music      - 36 músicas
    }
}
