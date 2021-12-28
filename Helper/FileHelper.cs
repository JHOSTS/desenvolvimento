using System;
using System.IO;



namespace POO.Helper;

public class FileHelper
{
    public void ListarDiretorios(string caminho)
    {
        var retornoCaminho = Directory.GetDirectories(caminho);

        foreach (var retorno in retornoCaminho)
        {
        Console.WriteLine(retorno);
        }
    }
    
    public void ListarArquivosDiretorios(string caminho)
    {
        var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

        foreach (var retorno in retornoArquivos)
        {
        Console.WriteLine(retorno);
        }
    }
}
