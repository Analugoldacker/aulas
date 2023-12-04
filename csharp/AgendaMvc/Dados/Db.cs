namespace AgendaMvc.Dados
{
    public class Db
    {
        public static List<Models.Contato> contatos = new() 
        {
            new Models.Contato()
            {   Id= 1,
                Nome="Analú",
                Email="Analu@gmail.com",
                Telefone="(47)9231-4893"
            }
        };

        public static List<Models.Compromisso> compromissos = new()
        {
            new Models.Compromisso()
            {
               Id= 1, Data=DateTime.Now, Descricao="jogar bocha",
                Contato= new Models.Contato()
                {    
                    Id= 1,
                    Nome="Analú",
                    Email="Analu@gmail.com",
                    Telefone="(47)9231-4893"
                },
                Local= new Models.Local()
                {
                    Id = 1,
                    Nome = "Casa",
                    Rua = "Carlos Krueger",
                    Numero = "309",
                    Bairro = "Itoupava Central",
                    Cidade = "Blumenau",
                    CEP = "89069-350",
                    UF = "SC"
                }
            }
        };
      
        public static List<Models.Local> locais = new()
        {
            new Models.Local()
            {   
                Id = 1,
                Nome = "Casa",
                Rua = "Carlos Krueger",
                Numero = "309",
                Bairro = "Itoupava Central",
                Cidade = "Blumenau",
                CEP = "89069-350",
                UF = "SC"
            }
        };
       
    }
}
