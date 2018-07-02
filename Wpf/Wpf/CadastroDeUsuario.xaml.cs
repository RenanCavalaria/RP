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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cadastrado usu = new Cadastrado();

                usu.Senha = txtSenha.Text;
                usu.Cpf = txtCpf.Text;

                ControllerCadastrado controllerUsuario = new ControllerCadastrado();
                controllerUsuario.Adicionar(usu);

                MessageBox.Show("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
            }
        }
    }
    
}
