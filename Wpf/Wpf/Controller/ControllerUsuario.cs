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
    public class ControllerUsuario : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();
        
        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }
       
       public void Atualizar(Usuario entity)
       {
           contexto.Entry(entity).State =
               System.Data.Entity.EntityState.Modified;

           contexto.SaveChanges();
       }
           
       public Usuario BuscarPorID(int id)
       {
           return contexto.Usuarios.Find(id);
       }

       public void Excluir(int id)
       {
           Usuario u = BuscarPorID(id);

           if (u != null)
           {
               contexto.Usuarios.Remove(u);
               contexto.SaveChanges();
           }
       }

       public IList<Usuario> ListarPorNome(string nome)
       {
           return contexto.Usuarios
               .Where(u => u.Nome.ToLower() == nome.ToLower()).ToList();
       }
       
       public IList<Usuario> ListarTodos()
       {
          return contexto.Usuarios.ToList();
       }
    }
}
