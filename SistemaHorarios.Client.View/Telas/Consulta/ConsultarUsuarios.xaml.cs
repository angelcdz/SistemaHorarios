using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarUsuarios.xaml
    /// </summary>
    public partial class ConsultarUsuarios : UserControl
    {
        public ConsultarUsuarios()
        {
            this.DataContext = new ConsultarUsuariosViewModel();
            InitializeComponent();
        }
    }
}
