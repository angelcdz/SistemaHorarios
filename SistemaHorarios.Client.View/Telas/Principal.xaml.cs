using SistemaHorarios.Client.ViewModel;
using System.Windows;

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
    }
}
