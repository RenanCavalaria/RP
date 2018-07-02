using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Base;
using Wpf.DAL;
using Wpf.Modelo;

namespace Wpf.Controller
{
    class ControllerOcorrencia : BaseControllerCadastroOcorrencia<Ocorrencia>
    {
        ContextoOcorrencia contexto = new ContextoOcorrencia();

        public void Adicionar(Ocorrencia entity) // Criar e adiciona uma nova ocorrencia
        {
            contexto.Ocorrencias.Add(entity);
            contexto.SaveChanges();
        }

        public IList<Ocorrencia> ListarTodos()
        {
            return contexto.Ocorrencias.ToList();
        }

        public IList<Ocorrencia> ListarPorNome(string nome)
        {
            return contexto.Ocorrencias
              .Where(u => u.Natureza.ToLower() == nome.ToLower()).ToList();
        }

        public Ocorrencia BuscarPorID(int id)
        {
            return contexto.Ocorrencias.Find(id);
        }

        public bool Atualizar(Ocorrencia entity) //Atualiza Cadastro ####
        {
            bool verdade = false;
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            if(contexto.SaveChanges() >= 1)
            {
                verdade = true;
            }
             

            return verdade;
        }

        public bool Excluir(int id)
        {
            Ocorrencia u = BuscarPorID(id);

            bool var = false;

            if (u != null)
            {
                contexto.Ocorrencias.Remove(u);
                contexto.SaveChanges();

                var = true;
            }

            return var;
        }
    }
}
