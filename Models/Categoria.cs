using ProjetoReceitasC_.Models;

namespace GerenciadorReceitas.Models
{
    public class Categoria : EntidadeBase
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}