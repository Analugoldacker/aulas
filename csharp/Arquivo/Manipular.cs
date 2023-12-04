using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos
{
    class Manipular
    {
        static string path = @"C:\Users\analu.baade\Desktop\aulas\csharp\Arquivo\documento.txt";
        public List<Contato> ListaContatos = new List<Contato>();
        public void salvar(Contato ct)
        {
            ListaContatos.Add(ct);
        }

        public void salvarNoArquivo()
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Contato ct in ListaContatos)
                {
                    sw.WriteLine(ct.ToString());
                }
            }

        }
        public void carregarDoArquivo()
        {
            ListaContatos.Clear();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
