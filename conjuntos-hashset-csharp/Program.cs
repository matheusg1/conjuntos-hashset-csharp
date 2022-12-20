using System;
using System.Collections.Generic;
using System.IO;

namespace conjuntos_hashset_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\matheus.silva\Documents\ProjetosPessoais\CSharp\conjuntos-hashset-csharp\conjuntos-hashset-csharp\doc1.csv";
                using (StreamReader sr = File.OpenText(path))
                {

                    HashSet<RegistroLogin> listaDeRegistos = new HashSet<RegistroLogin>();

                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        RegistroLogin reg = new RegistroLogin(linha);
                        listaDeRegistos.Add(reg);
                    }

                    Console.WriteLine(listaDeRegistos.Count);
                    /*
                    var contador = 0;
                    foreach (var registro in listaDeRegistos)
                    {
                        if (listaDeRegistos.Contains(registro))
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine(contador);
                    */
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
