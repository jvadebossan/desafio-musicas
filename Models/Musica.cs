using System;

namespace desafio_musicas.Models;

public class Musica
{
    public Musica(int codigo, DateTime dataLancamento, string nome, string artista, string album, string genero, double duracao, string gravadora, string pais, string idioma)
    {
        Codigo = codigo;
        DataLancamento = dataLancamento;
        Nome = nome;
        Artista = artista;
        Album = album;
        Genero = genero;
        Duracao = duracao;
        Gravadora = gravadora;
        Pais = pais;
        Idioma = idioma;
    }

    public int Codigo { get; protected set; }
    public DateTime DataLancamento { get; protected set; }
    public string Nome { get; protected set; }
    public string Artista { get; protected set; }
    public string Album { get; protected set; }
    public string Genero { get; protected set; }
    public double Duracao { get; protected set; }
    public string Gravadora { get; protected set; }
    public string Pais { get; protected set; }
    public string Idioma { get; protected set; }

    public void SetIdioma(string idioma)
    {
        if (string.IsNullOrWhiteSpace(idioma))
            throw new Exception("O Idioma deve ser informado.");
        Idioma = idioma;
    }
    public void SetPais(string pais)
    {
        if (string.IsNullOrWhiteSpace(pais))
            throw new Exception("O país deve ser informado.");
        Pais = pais;
    }
    public void SetGravadora(string gravadora)
    {
        if (string.IsNullOrWhiteSpace(gravadora))
            throw new Exception("A gravadora deve ser informada.");
        Gravadora = gravadora;
    }
    public void SetDuracao(double duracao)
    {
        if (duracao <= 0)
            throw new Exception("A duração deve ser maior que 0.");
        Duracao = duracao;
    }
    public void SetGenero(string genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("O gênero deve ser informado.");
        Genero = genero;
    }
    public void SetAlbum(string album)
    {
        if (string.IsNullOrWhiteSpace(album))
            throw new Exception("O álbum deve ser informado.");
        Album = album;
    }
    public void SetArtista(string artista)
    {
        if (string.IsNullOrWhiteSpace(artista))
            throw new Exception("O artista deve ser informado.");
        Artista = artista;
    }
    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("O nome deve ser informado.");
        Nome = nome;
    }

    public void SetDataLancamento(DateTime dataLancamento)
    {
        if (dataLancamento == DateTime.MinValue)
            throw new Exception("A data de lançamento está incorreta.");
        DataLancamento = dataLancamento;
    }

    public void SetCodigo(int codigo)
    {
        if (codigo <= 0)
            throw new Exception("O codigo deve ser maior que 0.");
        Codigo = codigo;
    }
}
