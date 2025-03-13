using System;
using desafio_musicas.Models;
using DesafioMusicas;

namespace desafio_musicas.Exercicios;

public class Ex6
{
    //TODO Qual o idioma com maior número de músicas lançadas por mês?
    public static void Exec()
    {
        var meses = Program.musicas.GroupBy(musica => new { mes = musica.DataLancamento.Month, ano = musica.DataLancamento.Year, idioma = musica.Idioma })
        .OrderBy(m => m.Key.ano).ThenBy(m => m.Key.mes)
        .Select(m => new
        {
            formato = new DateTime(m.Key.ano, m.Key.mes, 1).ToString("MMMM/yyyy"),
            idiomas = m.Select(c => c.Idioma)
        });

        foreach (var mes in meses)
        {
            Console.WriteLine($"{mes.formato,-15} - {mes.idiomas.First(),-12} - {mes.idiomas.Count()}");
        }
        // Temos 5 gravadoras cadastradas em nossa base.
        // outubro/1974    - English      - 1
        // outubro/1974    - Japanese     - 1
        // abril/1975      - Spanish      - 1
        // julho/1975      - Italian      - 1
        // agosto/1975     - German       - 1
    }
}
