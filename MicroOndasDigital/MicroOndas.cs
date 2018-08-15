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

        private void InstanciaServico(int tempo, int potencia)
        {
            _servico = new ServicoMicroOndas(tempo, potencia);
        }

        private void Btn_Ligar(object sender, EventArgs e)
        {
            int tempo, potencia;

            if (!int.TryParse(txtTempo.Text, out tempo))
            {
                lblMensagem.Text = "Valor do tempo incorreto.";
                return;
            }

            if (!int.TryParse(txtPotencia.Text, out potencia))
            {
                lblMensagem.Text = "Valor da potência incorreto.";
                return;
            }

            InstanciaServico(tempo, potencia);
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
            _tempo = 0;
            lblMensagem.Text = string.Empty;
            MessageBox.Show("Cozimento cancelado!");
        }

        private void Btn_InicioRapido(object sender, EventArgs e)
        {
            InstanciaServico();
            var microOndasDigital = _servico.InicioRapido();
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
                lblMensagem.Text = "Fim";
                MessageBox.Show("Tempo Acabou");
            }
        }

        private void IniciarContagemPorTempo(int tempo)
        {
            _tempo = tempo;
            tmpTempo.Start();
        }
    }
}
