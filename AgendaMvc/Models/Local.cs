namespace AgendaMvc.Models
{
    public class Local
    {
        /*Local deve ter: Id, nome, rua, numero, bairro, cidade, cep e uf.*/
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set;}
        public string Bairro { get; set;}
        public string Cidade { get; set;}
        public string CEP { get; set;}
        public string UF { get; set;}
    }
}
