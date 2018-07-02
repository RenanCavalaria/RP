using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Base;
using Wpf.DAL;
using Wpf.Modelo;

namespace Wpf.Controller
{
    public class ControllerCadastrado : IBaseControllerCadastrado<Cadastrado>
    {
        private ContextoCadastrado contexto = new ContextoCadastrado();

        public void Adicionar(Cadastrado entity)
        {
            contexto.Cadastrados.Add(entity);
            contexto.SaveChanges();
        }
        
        public Cadastrado Validar(int cpf)
        {
             return  contexto.Cadastrados.Find(cpf);
            
        }

        public bool Consulta(string cpf, string senha)
        {
            return contexto.Cadastrados.Where(c => c.Cpf == cpf && c.Senha == senha).Count() > 0;
        }
       
    }
}
