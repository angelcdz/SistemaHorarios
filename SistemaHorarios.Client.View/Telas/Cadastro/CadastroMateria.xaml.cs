using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastroMateria.xaml
    /// </summary>
    public partial class CadastroMateria : UserControl
    {
        public CadastroMateria()
        {
            this.DataContext = new CadastroMateriaViewModel();
            InitializeComponent();
        }
    }
}
