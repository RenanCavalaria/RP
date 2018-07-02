using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Base
{
    public interface IBaseControllerCadastrado<T> where T : class
    {
        void Adicionar(T entity);

        T Validar(int cpf);

    }
}
