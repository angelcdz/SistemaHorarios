using SistemaHorarios.Client.ViewModel;
using System.Windows;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            this.DataContext = new LoginViewModel();
            InitializeComponent();
        }

        private void Flag_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            this.Hide();
            new Principal().Show();
        }
    }
}
