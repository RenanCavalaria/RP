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

namespace Wpf.CadastroUsuario
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        private void SingIn_Click(object sender, RoutedEventArgs e)
        {
            string CPF = (Cpf.Text);
            string SENHA = (Senha.Text);

            bool v;


            ControllerCadastrado controllerUsuario = new ControllerCadastrado();

            v = Convert.ToBoolean(mostra.Content = controllerUsuario.Consulta(CPF, SENHA));

            if (v == true)
            {
                MessageBox.Show("Clique Ok para continuar !");

                FormOcorrencia formOcorrencia = new FormOcorrencia();

                Close();

                formOcorrencia.ShowDialog();
            }

        }

        private void Cadastrar_se_Click(object sender, RoutedEventArgs e)
        {
            string CPF = (Cpf.Text);
            string SENHA = (Senha.Text);

            Cadastrado cadastrado = new Cadastrado();

            cadastrado.Cpf = CPF;
            cadastrado.Senha = SENHA;

            ControllerCadastrado controllerUsuario = new ControllerCadastrado();           

            controllerUsuario.Adicionar(cadastrado);

        }
    }
}
