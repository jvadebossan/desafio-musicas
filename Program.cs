using desafio_musicas.Exercicios;
using desafio_musicas.Models;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;

namespace DesafioMusicas;

class Program
{

    static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "musicas.xlsx");
    public static List<Musica> musicas = [];

    public static void Main(string[] args)
    {
        ImportarExcel();
        //Ex1.Exec();
        //Ex2.Exec();
        Ex3.Exec();
        //Ex4A.Exec();
        //Ex4B.Exec();
        //Ex4C.Exec();
        //Ex5.Exec();
        //Ex6.Exec();
    }

    public static void ImportarExcel()
    {
        IWorkbook pastaTrabalho = WorkbookFactory.Create(caminhoArquivo);

        ISheet planilha = pastaTrabalho.GetSheetAt(0);

        for (int i = 1; i < planilha.PhysicalNumberOfRows; i++)
        {
            IRow linha = planilha.GetRow(i);

            int codigo = (int)linha.GetCell(0).NumericCellValue;
            DateTime dataLancamento = linha.GetCell(1).DateCellValue ?? DateTime.Now;
            string nome = linha.GetCell(2).StringCellValue;
            string artista = linha.GetCell(3).StringCellValue;
            string album = linha.GetCell(4).StringCellValue;
            string genero = linha.GetCell(5).StringCellValue;
            double duracao = linha.GetCell(6).NumericCellValue;
            string gravadora = linha.GetCell(7).StringCellValue;
            string pais = linha.GetCell(8).StringCellValue;
            string idioma = linha.GetCell(9).StringCellValue;

            var musica = new Musica(codigo, dataLancamento, nome, artista, album, genero, duracao, gravadora, pais, idioma);

            musicas.Add(musica);
        }
    }


}