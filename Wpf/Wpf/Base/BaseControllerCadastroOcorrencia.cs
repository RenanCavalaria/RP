using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Base
{
    interface BaseControllerCadastroOcorrencia<T> where T : class
    {
        void Adicionar(T entity);
        IList<T> ListarTodos();
        IList<T> ListarPorNome(string nome);
        T BuscarPorID(int id);
        bool Atualizar(T entity);
        bool Excluir(int id);
    }
}
