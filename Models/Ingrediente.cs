using ProjetoReceitasC_.Models;

namespace GerenciadorReceitas.Models
{
    public class Ingrediente : EntidadeBase
    {
        public string Nome { get; set; }
        public string UnidadeMedida { get; set; }

        public override string ToString()
        {
            return $"{Nome} ({UnidadeMedida})";
        }
    }
}