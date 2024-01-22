using System.Text.Json.Serialization;

namespace ApiCadastrarCrud.Entidades
{
    public class Produto
    {/*crud*/
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public Categoria? Categoria { get; set; }
        [JsonIgnore]
        public int CategoriaId { get; set; }
    }
}
