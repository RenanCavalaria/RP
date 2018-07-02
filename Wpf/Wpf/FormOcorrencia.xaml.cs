using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf.Controller;
using Wpf.Modelo;

namespace Wpf
{
    /// <summary>
    /// Lógica interna para FormOcorrencia.xaml
    /// </summary>
    public partial class FormOcorrencia : Window
    {
        public FormOcorrencia()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(boxID.Text ) > 0)
            {
                ControllerOcorrencia controllerOcorrencia = new ControllerOcorrencia();

                Ocorrencia ocorrencia = new Ocorrencia();

                ocorrencia.Bairro = boxBairro.Text;
                ocorrencia.Natureza = boxNatureza.Text;
                ocorrencia.Hora = Convert.ToDouble( boxHora.Text);
                ocorrencia.OcorrenciaID = Convert.ToInt32( boxID.Text);

                controllerOcorrencia.Adicionar(ocorrencia);

                    boxBairro.Clear();
                    boxNatureza.Clear();
                    boxID.Clear();
                    boxHora.Clear();
            }

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e) //Atualiza Cadastro ####
        {
            ControllerOcorrencia controllerOcorrencia = new ControllerOcorrencia();

            Ocorrencia ocorrencia = new Ocorrencia();

            ocorrencia.Bairro = boxBairro.Text;
            ocorrencia.Natureza = boxNatureza.Text;
            ocorrencia.Hora = Convert.ToDouble(boxHora.Text);
            ocorrencia.OcorrenciaID = Convert.ToInt32(boxID.Text);

            bool ver;

            ver = controllerOcorrencia.Atualizar(ocorrencia);

            if( ver == true)
            {
                MessageBox.Show("Atualizado com sucesso");

                boxBairro.Clear();
                boxNatureza.Clear();
                boxID.Clear();
                boxHora.Clear();


            }
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            ControllerOcorrencia controllerOcorrencia = new ControllerOcorrencia();

            Ocorrencia ocorrencia = new Ocorrencia();

            int ID = Convert.ToInt32(box_DeletaID.Text);

            bool ver;

            ver  = controllerOcorrencia.Excluir(ID);

            if( ver == true)
            {
                MessageBox.Show("Excluido com sucesso !!!");

                boxID.Clear();
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ControllerOcorrencia controllerOcorrencia = new ControllerOcorrencia();

            Ocorrencia ocorrencia = new Ocorrencia();

            GridListar.DataContext =  controllerOcorrencia.ListarTodos();
        } 
    }
}
