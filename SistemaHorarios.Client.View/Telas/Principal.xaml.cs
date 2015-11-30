using SistemaHorarios.Client.View.Telas;
using SistemaHorarios.Client.ViewModel;
using System.Windows;
using System.Windows.Controls;
using SistemaHorarios.Client.View.Resources;

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
            
            var item = new CloseableTabItem() { Content = new BoasVindas() };
            item.SetHeader(new TextBlock() { Text = "Bem-vindo! " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
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
            foreach (var child in TabbedPanel.Items)
            {
                var tab = child as CloseableTabItem;

                if (tab != null)
                    if (string.Equals(tab.Name, "Consultas"))
                    {
                        TabbedPanel.SelectedItem = tab;
                        return;
                    }
            }
            var item = new CloseableTabItem() { Content = new SeletorConsultas(), Name = "Consultas" };
            item.SetHeader(new TextBlock() { Text = "Consultas " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var child in TabbedPanel.Items)
            {
                var tab = child as CloseableTabItem;

                if (tab != null)
                    if (string.Equals(tab.Name, "Cadastros"))
                    {
                        TabbedPanel.SelectedItem = tab;
                        return;
                    }
            }
            var item = new CloseableTabItem() { Content = new SeletorCadastros(), Name = "Cadastros" };
            item.SetHeader(new TextBlock() { Text = "Cadastros " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var child in TabbedPanel.Items)
            {
                var tab = child as CloseableTabItem;

                if (tab != null)
                    if (string.Equals(tab.Name, "Alteracoes"))
                    {
                        TabbedPanel.SelectedItem = tab;
                        return;
                    }
            }
            var item = new CloseableTabItem() { Content = new SeletorAlteracoes(), Name = "Alteracoes" };
            item.SetHeader(new TextBlock() { Text = "Alterações " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void ItemUsuarios_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in TabbedPanel.Items)
            {
                var tab = child as CloseableTabItem;

                if (tab != null)
                    if (string.Equals(tab.Name, "Usuarios"))
                    {
                        TabbedPanel.SelectedItem = tab;
                        return;
                    }
            }
            var item = new CloseableTabItem() { Content = new SeletorUsuarios(), Name = "Usuarios" };
            item.SetHeader(new TextBlock() { Text = "Usuários " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }

        private void ItemNiveisAcesso_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in TabbedPanel.Items)
            {
                var tab = child as CloseableTabItem;

                if (tab != null)
                    if (string.Equals(tab.Name, "Niveis"))
                    {
                        TabbedPanel.SelectedItem = tab;
                        return;
                    }
            }
            var item = new CloseableTabItem() { Content = new SeletorNiveis(), Name = "Niveis" };
            item.SetHeader(new TextBlock() { Text = "Níveis de Acesso " });
            TabbedPanel.Items.Add(item);
            TabbedPanel.SelectedIndex = TabbedPanel.Items.Count - 1;
        }
    }
}
