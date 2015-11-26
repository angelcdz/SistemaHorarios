using SistemaHorarios.Client.View.Telas;
using SistemaHorarios.Client.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            this.DataContext = new PrincipalViewModel();
            InitializeComponent();
        }

        private void ItemSair_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void ItemSobre_Click(object sender, RoutedEventArgs e)
        {
            new Sobre().Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TabbedPanel.Items.Add(new TabItem() { Header = "Consultas", Content = new SeletorConsultas() });
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TabbedPanel.Items.Add(new TabItem() { Header = "Cadastros", Content = new SeletorCadastros() });
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            TabbedPanel.Items.Add(new TabItem() { Header = "Alterações", Content = new SeletorAlteracoes() });
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void ItemUsuarios_Click(object sender, RoutedEventArgs e)
        {
            TabbedPanel.Items.Add(new TabItem() { Header = "Usuários", Content = new SeletorUsuarios() });
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void ItemNiveisAcesso_Click(object sender, RoutedEventArgs e)
        {
            TabbedPanel.Items.Add(new TabItem() { Header = "Níveis de Acesso", Content = new SeletorNiveis() });
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }
    }
}
