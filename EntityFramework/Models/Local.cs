using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EntityFramework.Models
{
    public class Local
    {
        public int Id { get; set; }
        [MinLength(4, ErrorMessage =" No minimo 5 caracters"),MaxLength(30)]
        public string Nome { get; set; }
        public string Rua { get; set; }
        [AllowNull]
        public string? Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        [MaxLength(2 , ErrorMessage ="Somente dois digitos"),MinLength(2, ErrorMessage = "Somente dois digitos")]
        public string UF { get; set; }
        
        [MaxLength(10)]
        public string CEP { get; set; }

        public ICollection<Compromisso> Compromisso { get; set; }
    }
    
}
