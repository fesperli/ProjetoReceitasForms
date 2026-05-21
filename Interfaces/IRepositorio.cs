using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoReceitasC_.Interfaces
{
    public interface IRepositorio<T>
    {
        void Inserir(T entidade);
        void Editar(T entidade);
        void Deletar(int id);
        List<T> Listar();
        T BuscarPorId(int id);
    }
}
