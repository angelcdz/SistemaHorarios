using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarProfessor.xaml
    /// </summary>
    public partial class CadastrarProfessor : UserControl
    {
        public CadastrarProfessor()
        {
            this.DataContext = new CadastrarProfessorViewModel();
            InitializeComponent();
        }
    }
}
