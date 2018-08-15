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
        }

        private void Btn_Ligar(object sender, EventArgs e)
        {
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

            InstanciaServico();
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
            InstanciaServico();
            _servico.Pausar();
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
    }
}
