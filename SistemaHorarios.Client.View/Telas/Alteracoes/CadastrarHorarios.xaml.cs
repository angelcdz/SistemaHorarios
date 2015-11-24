using SistemaHorarios.WPF.Proxy;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace SistemaHorarios.WPF.Telas.Cadastro
{
    public partial class CadastrarHorarios : UserControl
    {
        ModoDeTela modo = ModoDeTela.Cancelar;

        //Muda modo da tela
        private void mudarModo(ModoDeTela modo)
        {
            switch (modo)
            {
                case ModoDeTela.Novo:
                    TextBoxCodigo.Text = "";
                    TimeInicial.IsEnabled = true;
                    TimeFinal.IsEnabled = true;
                    ComboDia.IsEnabled = true;
                    ComboDia.SelectedIndex = 0;

                    BotaoConfirmar.IsEnabled = true;
                    BotaoCancelar.IsEnabled = true;

                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Editar:
                    TimeInicial.IsEnabled = true;
                    TimeFinal.IsEnabled = true;
                    ComboDia.IsEnabled = true;

                    BotaoConfirmar.IsEnabled = true;
                    BotaoCancelar.IsEnabled = true;

                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Cancelar:
                    TextBoxCodigo.Text = "";
                    TimeInicial.IsEnabled = false;
                    TimeFinal.IsEnabled = false;
                    TimeInicial.Value = null;
                    TimeFinal.Value = null;

                    ComboDia.IsEnabled = false;
                    ComboDia.SelectedIndex = 0;

                    BotaoConfirmar.IsEnabled = false;
                    BotaoCancelar.IsEnabled = false;

                    BotaoNovo.IsEnabled = true;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Selecionado:
                    //verifica se há algum item selecionado na lista
                    if (Lista.SelectedItems.Count != 1)
                    {
                        System.Windows.MessageBox.Show("Selecione apenas um elemento da lista!");
                        return;
                    }

                    //Aloca o objeto selecionado
                    var item = Lista.Items.GetItemAt(Lista.SelectedIndex) as Horario;

                    TextBoxCodigo.Text = item.Codigo.ToString();
                    TextBoxCodigo.IsEnabled = false;
                    TimeInicial.IsEnabled = false;
                    TimeFinal.IsEnabled = false;
                    DateTime? hora = new DateTime(DateTime.Now.Year, 
                                                  DateTime.Now.Month, 
                                                  DateTime.Now.Day, 
                                                  item.HoraInicial.Hours, 
                                                  item.HoraInicial.Minutes, 
                                                  item.HoraInicial.Seconds);
                    TimeInicial.Value = hora;
                    hora = new DateTime(DateTime.Now.Year, 
                                                  DateTime.Now.Month, 
                                                  DateTime.Now.Day, 
                                                  item.HoraFinal.Hours,
                                                  item.HoraFinal.Minutes,
                                                  item.HoraFinal.Seconds);
                    TimeFinal.Value = hora;
                    ComboDia.SelectedItem = item.DiaDaSemana.Descricao;

                    BotaoConfirmar.IsEnabled = false;
                    BotaoCancelar.IsEnabled = true;

                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = true;
                    BotaoExcluir.IsEnabled = true;
                    break;

                default:
                    break;
            }
            //Atribui o modo recebido à variável da tela
            this.modo = modo;
        }

        private void Lista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mudarModo(ModoDeTela.Selecionado);
        }

        private void BotaoConfirmar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Verifica o modo atual da tela
                switch (modo)
                {
                    case ModoDeTela.Novo:
                        using (var context = new Proxy.SistemaHorariosServiceClient())
                        {   
                            var hoje = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var inicialTemp = (TimeSpan)(TimeInicial.Value - hoje);
                            var finalTemp = (TimeSpan)(TimeFinal.Value - hoje);

                            var inicial = new TimeSpan(inicialTemp.Hours, inicialTemp.Minutes, 0);
                            var final = new TimeSpan(finalTemp.Hours, finalTemp.Minutes, 0);

                            var item = new Horario()
                            {
                                HoraInicial = inicial,
                                HoraFinal = final
                            };
                            item.CodigoDia = context.GetDiasDaSemana().Where(p => p.Descricao == ComboDia.SelectedItem as string).First().Codigo;
                            context.AddHorario(item);
                        }
                        break;

                    case ModoDeTela.Editar:
                        using (var context = new Proxy.SistemaHorariosServiceClient())
                        {
                            var hoje = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var inicialTemp = (TimeSpan)(TimeInicial.Value - hoje);
                            var finalTemp = (TimeSpan)(TimeFinal.Value - hoje);

                            var inicial = new TimeSpan(inicialTemp.Hours, inicialTemp.Minutes, 0);
                            var final = new TimeSpan(finalTemp.Hours, finalTemp.Minutes, 0);

                            var item = new Horario()
                            {
                                Codigo = Convert.ToInt16(TextBoxCodigo.Text),
                                HoraInicial = inicial,
                                HoraFinal = final
                            };
                            item.CodigoDia = context.GetDiasDaSemana().Where(p => p.Descricao == ComboDia.SelectedItem as string).First().Codigo;
                            context.UpdateHorario(item);
                        }
                        break;

                    default:
                        System.Windows.MessageBox.Show("Modo de tela inválido!");
                        break;
                }

                System.Windows.MessageBox.Show("Registro atualizado/cadastrado com sucesso! =)");

                AtualizarLista();

                //Seta o modo da tela para o modo standard
                mudarModo(ModoDeTela.Cancelar);
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Erro ao criar/atualizar registro");
            }
        }

        private void BotaoCancelar_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Cancelar);
        }

        private void BotaoNovo_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Novo);
            //TextBoxInicial.Focus();
        }

        private void BotaoEditar_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Editar);
        }

        private void BotaoExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Tem certeza que deseja excluir este registro?", "Aviso", System.Windows.MessageBoxButton.YesNo) == System.Windows.MessageBoxResult.Yes)
            {

                try
                {
                    //Tenta deletar o registro
                    using (var context = new Proxy.SistemaHorariosServiceClient())
                    {
                        var item = new Horario()
                        {
                            Codigo = Convert.ToInt16(TextBoxCodigo.Text),
                        };
                        context.DeleteHorario(item);
                    }

                    System.Windows.MessageBox.Show("Registro deletado com sucesso! =)");

                    AtualizarLista();

                    //Seta o modo da tela para o modo standard
                    mudarModo(ModoDeTela.Cancelar);
                }
                catch (Exception)
                {
                    System.Windows.MessageBox.Show("Erro ao deletar o registro");
                }
            }
        }

        private async void BotaoAtualizar_Click(object sender, RoutedEventArgs e)
        {
            AtualizarLista();
        }

        private async void AtualizarLista()
        {
            await Task.Delay(0);

            if (ComboFiltro.SelectedIndex == 0)
            {
                foreach (var item in Lista.Items)
                {
                    ComboFiltro.Items.Remove(item);
                }
            }

            try
            {
                using (var context = new Proxy.SistemaHorariosServiceClient())
                {
                    var lista = await context.GetHorariosAsync();
                    Lista.ItemsSource = lista.Where(p => p.DiaDaSemana.Descricao == ComboFiltro.SelectedItem as string).OrderBy(p => p.HoraInicial);
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Erro ao atualizar a lista","Aviso",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private async void ComboDia_Loaded(object sender, RoutedEventArgs e)
        {
            ComboDia.Items.Add("");

            await Task.Delay(1);

            using (var context = new Proxy.SistemaHorariosServiceClient())
            {
                var lista = await context.GetDiasDaSemanaAsync();
                foreach (var item in lista)
                {
                    ComboDia.Items.Add(item.Descricao);
                }
            }
        }

        private async void ComboFiltro_Loaded(object sender, RoutedEventArgs e)
        {
            ComboFiltro.Items.Add("");

            await Task.Delay(1);

            using (var context = new Proxy.SistemaHorariosServiceClient())
            {
                var lista = await context.GetDiasDaSemanaAsync();
                foreach (var item in lista)
                {
                    ComboFiltro.Items.Add(item.Descricao);
                }
            }
        }

        public CadastrarHorarios()
        {
            InitializeComponent();
        }
    }
}
