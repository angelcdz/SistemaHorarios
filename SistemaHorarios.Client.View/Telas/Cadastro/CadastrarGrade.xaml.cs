using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarGrade.xaml
    /// </summary>
    public partial class CadastrarGrade : UserControl
    {
        public CadastrarGrade()
        {
            this.DataContext = new CadastrarGradeViewModel();
            InitializeComponent();
        }
    }
}
