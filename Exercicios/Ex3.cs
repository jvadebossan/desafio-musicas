using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex3
{
    //TODO Quantos álbuns foram lançados mensalmente? Faça uma lista ordenada ascendente dos meses e as respectivas quantidades.
    public static void Exec()
    {
        var meses = Program.musicas.GroupBy(musica => new { mes = musica.DataLancamento.Month, ano = musica.DataLancamento.Year })
        .OrderBy(m => m.Key.ano).ThenBy(m => m.Key.mes)
        .Select(m => new
        {
            formato = new DateTime(m.Key.ano, m.Key.mes, 1).ToString("MMMM/yyyy"),
            albuns = m.Select(c => c.Album)
        });

        foreach (var mes in meses)
        {
            Console.WriteLine($"{mes.formato} - {mes.albuns.Count()}");
        }
        // outubro/1974 - 2
        // abril/1975 - 1
        // julho/1975 - 1
    }
}
