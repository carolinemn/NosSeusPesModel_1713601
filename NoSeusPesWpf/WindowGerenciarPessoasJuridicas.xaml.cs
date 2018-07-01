using NosSeusPesModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace NoSeusPesWpf
{
    /// <summary>
    /// Lógica interna para WindowGerenciarPessoasJuridicas.xaml
    /// <summary>
  
    public partial class WindowGerenciarPessoasJuridicas : Window, INotifyPropertyChanged
    {
        #region "NotifyPropertyChanged"
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string Property)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(
                    Property));
            }
        }
        #endregion

        private PessoaJuridica _PessoaJuridicaSelecionada = new PessoaJuridica();
        public PessoaJuridica PessoaJuridicaSelecionada
        {
            get
            {
                return _PessoaJuridicaSelecionada;
            }
            set
            {
                _PessoaJuridicaSelecionada = value;
                this.NotifyPropertyChanged("Pessoa Juridica Selecionada");
            }
        }

        public ICollection<PessoaJuridica> PessoasJuridicas
        {
            get { return _PessoasJuridicas; }
            set
            {
                _PessoasJuridicas = value;
                this.NotifyPropertyChanged("Pessoas Juridicas");
            }
        }

        public Boolean ModoCriacaoPessoaJuridica { get; set; } = false;

        public Visibility VisibilidadeDataGrid
        {
            get
            {
                if (ModoCriacaoPessoaJuridica)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
        /// <summary>
        /// O contexto se mantem o mesmo durante toda a janela.
        /// </summary>

        private ModelPedido ctx = new ModelPedido();
        
        private ICollection<PessoaJuridica> _PessoasJuridicas;


        /// <summary>
        /// Carrega os dados.
        /// </summary>
        public WindowGerenciarPessoasJuridicas()
        {
            InitializeComponent();

            this.PessoasJuridicas = ctx.PessoasJuridicas.ToList();
            this.PessoasJuridicas = ctx.PessoasJuridicas.ToList();
            if (!ModoCriacaoPessoaJuridica)
            {
                this.PessoaJuridicaSelecionada = this.PessoasJuridicas.FirstOrDefault();
            }
            this.DataContext = this;
        }

        /// <summary>
        /// Persiste as atualizações feitas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (ModoCriacaoPessoaJuridica)
            {
                if (this.PessoaJuridicaSelecionada.Id <= 0)
                {
                    ctx.PessoasFisicas.Add(this.PessoaJuridicaSelecionada);
                }

            }
            ctx.SaveChanges();
            MessageBox.Show("Cadastro Atualizado");
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PesssoasFisicasDataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (PessoaFisica item in e.RemovedItems)
            {
                ctx.PessoasFisicas.Remove(item);
            }
        }
    }
}