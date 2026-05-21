using ProjetoReceitasC_.Models;

namespace GerenciadorReceitas.Models
{
    public class Receita : EntidadeBase
    {
        public string Nome { get; set; }
        public string ModoPreparo { get; set; }
        public int TempoPreparo { get; set; }

        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }

        public string CategoriaNome { get; set; }
        public string UsuarioNome { get; set; }

        public List<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();

        public override string ToString()
        {
            return $"{Nome} - {CategoriaNome} - {TempoPreparo} min";
        }
    }
}