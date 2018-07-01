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
    /// Lógica interna para WindowGerenciarPessoasFisicas.xaml
    /// </summary>
    public partial class WindowGerenciarPessoasFisicas : Window, INotifyPropertyChanged
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

        private PessoaFisica _PessoaFisicaSelecionada = new PessoaFisica();
        public PessoaFisica PessoaFisicaSelecionada
        {
            get {
                return _PessoaFisicaSelecionada;
            }
            set
            {
                _PessoaFisicaSelecionada = value;
                this.NotifyPropertyChanged("Pessoa Fisica Selecionada");
            }
        }

        public ICollection<PessoaFisica> PessoasFisicas
        {
            get { return _PessoasFisicas; }
            set
            {
                _PessoasFisicas = value;
                this.NotifyPropertyChanged("Pessoas Fisicas");
            }
        }

        public Boolean ModoCriacaoPessoaFisica { get; set; } = false;

        public Visibility VisibilidadeDataGrid
        {
            get
            {
                if (ModoCriacaoPessoaFisica)
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
        //private PessoaFisica _PessoaFisicaSelecionada;
        private ICollection<PessoaFisica> _PessoasFisicas;
        

        /// <summary>
        /// Carrega os dados.
        /// </summary>
        public WindowGerenciarPessoasFisicas()
        {
            InitializeComponent();

            this.PessoasFisicas = ctx.PessoasFisicas.ToList();
            this.PessoasFisicas = ctx.PessoasFisicas.ToList();
            if (!ModoCriacaoPessoaFisica)
            {
                this.PessoaFisicaSelecionada = this.PessoasFisicas.FirstOrDefault();
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
            if (ModoCriacaoPessoaFisica)
            {
                if (this.PessoaFisicaSelecionada.Id <= 0)
                {
                    ctx.PessoasFisicas.Add(this.PessoaFisicaSelecionada);
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

