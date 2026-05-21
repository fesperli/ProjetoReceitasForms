using ProjetoReceitasC_.Models;

namespace GerenciadorReceitas.Models
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}