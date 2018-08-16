using MicroOndasDigital.Servico;
using MicroOndasDigital.Servico.Interface;
using System;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class MicroOndas : Form
    {
        int _tempo;
        private IServicoMicroOndas _servico;

        //TODO: Parar de instanciar servico para toda ação
        // Verificar listBox opçao em branco

        public MicroOndas()
        {
            InitializeComponent();
        }

        private void InstanciaServico()
        {
            _servico = new ServicoMicroOndas();
        }

        private void MicroOndas_Load(object sender, EventArgs e)
        {
            txtPotencia.Text = Constantes.POTENCIA_PADRAO.ToString();
            PopularListBoxPrograma();
        }

        private void PopularListBoxPrograma()
        {
            listPrograma.ValueMember = "Id";
            listPrograma.DisplayMember = "Nome";

            InstanciaServico();
            var listaProgramas = _servico.ListarTiposAquecimento();
            listPrograma.DataSource = listaProgramas;
            listPrograma.SelectedIndex = -1;
        }

        private void LigarMicroOndasPorPrograma(int idPrograma)
        {
            InstanciaServico();
            var microOndasDigital = _servico.RecuperarPorPrograma(idPrograma);
            IniciarContagemPorTempo(microOndasDigital.Tempo);
        }

        private void Btn_Ligar(object sender, EventArgs e)
        {
            if (listPrograma.SelectedIndex != -1)
            {
                var idPrograma = (int)listPrograma.SelectedValue;
                LigarMicroOndasPorPrograma(idPrograma);
                return;
            }

            int tempo, potencia;
            if (!int.TryParse(txtTempo.Text, out tempo))
            {
                lblMensagem.Text = Constantes.VALOR_TEMPO_INCORRETO;
                return;
            }

            if (!int.TryParse(txtPotencia.Text, out potencia))
            {
                lblMensagem.Text = Constantes.VALOR_POTENCIA_INCORRETO;
                return;
            }

            var microOndasDigital = _servico.Ligar(tempo, potencia);

            if (microOndasDigital.EhValido)
            {
                IniciarContagemPorTempo(microOndasDigital.Tempo);
            }
            else
            {
                lblMensagem.Text = microOndasDigital.Mensagem;
            }
        }

        private void Btn_Pausar(object sender, EventArgs e)
        {
            if (button_pausar.Text == "Pausar")
            {
                tmpTempo.Stop();
                button_pausar.Text = "Continuar";
            }
            else
            {
                tmpTempo.Start();
                button_pausar.Text = "Pausar";
            }
        }

        private void Btn_Cancelar(object sender, EventArgs e)
        {
            tmpTempo.Stop();
            MessageBox.Show(Constantes.COMIDA_CANCELADA);
            ZerarCampos();
        }

        private void Btn_InicioRapido(object sender, EventArgs e)
        {
            InstanciaServico();
            var microOndasDigital = _servico.InicioRapido();

            txtTempo.Text = microOndasDigital.Tempo.ToString();
            txtPotencia.Text = microOndasDigital.Potencia.ToString();

            IniciarContagemPorTempo(microOndasDigital.Tempo);
        }

        private void TxtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumeros(e);
        }

        private void TxtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumeros(e);
        }

        private void PermitirApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TmpTempo_Tick(object sender, EventArgs e)
        {
            _tempo--;

            lblMensagem.Text = Convert.ToString(_tempo);

            if (_tempo == 0)
            {
                tmpTempo.Stop();
                lblMensagem.Text = Constantes.COMIDA_AQUECIDA;
                MessageBox.Show(Constantes.COMIDA_PRONTA);
                ZerarCampos();
            }
        }

        private void ZerarCampos()
        {
            lblMensagem.Text = string.Empty;
            txtTempo.Text = string.Empty;
            txtPotencia.Text = Constantes.POTENCIA_PADRAO.ToString();
            _tempo = 0;
        }

        private void IniciarContagemPorTempo(int tempo)
        {
            _tempo = tempo;
            tmpTempo.Start();
        }

        private void ListPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listPrograma.SelectedIndex != -1)
            {
                InstanciaServico();
                var idPrograma = (int)listPrograma.SelectedValue;
                var programa = _servico.RecuperarPorPrograma(idPrograma);

                txtPotencia.Text = programa.Potencia.ToString();
                txtTempo.Text = programa.Tempo.ToString();
            }
        }
    }
}
