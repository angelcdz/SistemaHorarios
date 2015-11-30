using SistemaHorarios.Client.ViewModel.Autenticacao;
using SistemaHorarios.Contracts.ConsultarGrade;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for ExibirGrade.xaml
    /// </summary>
    public partial class ExibirGrade : Window
    {
        public ExibirGrade()
        {
            this.Show();
            InitializeComponent();

            if (Context.Grade != null)
                MostrarGrade();
        }

        private void MostrarGrade()
        {
            TxtCurso.Text = Context.Grade.NomeCurso;
            TxtDia.Text = Context.Grade.NomeDia;
            TxtSemestre.Text = Context.Grade.NumeroSemestre.ToString();

            for (int i = 0; i < Context.Grade.Horarios.Count; i++)
            {
                if (i > 0 && Context.Grade.Horarios[i].HorarioInicial != Context.Grade.Horarios[i - 1].HorarioFinal)
                {
                    Tabela.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(30) });
                    var intervalo = new TextBlock()
                    {
                        Text = "Intervalo",
                        TextAlignment = System.Windows.TextAlignment.Center,
                        Background = Brushes.LightGray,
                        Width = Tabela.Width,
                        VerticalAlignment = System.Windows.VerticalAlignment.Center,
                        HorizontalAlignment = System.Windows.HorizontalAlignment.Center
                    };
                    intervalo.SetValue(Grid.ColumnSpanProperty, 2);
                    intervalo.SetValue(Grid.RowProperty, Tabela.RowDefinitions.Count - 1);
                    Tabela.Children.Add(intervalo);
                }

                Tabela.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50) });
                var horario = new TextBlock()
                {
                    Text = string.Concat(Context.Grade.Horarios[i].HorarioInicial, " - ", Context.Grade.Horarios[i].HorarioFinal),
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                horario.SetValue(Grid.ColumnProperty, 0);
                horario.SetValue(Grid.RowProperty, Tabela.RowDefinitions.Count - 1);

                var materia = new StackPanel()
                {
                    Orientation = Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                if (Context.Grade.Horarios[i].Materia != null)
                {
                    materia.Children.Add(new TextBlock() { Text = Context.Grade.Horarios[i].Materia.Materia, FontWeight = FontWeight.FromOpenTypeWeight(600) });
                    materia.Children.Add(new TextBlock() { Text = Context.Grade.Horarios[i].Materia.Professor });
                }
                materia.SetValue(Grid.ColumnProperty, 1);
                materia.SetValue(Grid.RowProperty, Tabela.RowDefinitions.Count - 1);

                Tabela.Children.Add(horario);
                Tabela.Children.Add(materia);
            }
        }
    }
}
