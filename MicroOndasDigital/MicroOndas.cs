using MicroOndasDigital.Servico;
using MicroOndasDigital.Servico.Interface;
using System;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class MicroOndas : Form
    {
        private IServicoMicroOndas _servico;

        public MicroOndas()
        {
            InitializeComponent();
        }

        private void InstanciaServico()
        {
            _servico = new ServicoMicroOndas();
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

            InstanciaServico();
            _servico.Ligar(tempo, potencia);
        }

        private void Btn_Pausar(object sender, EventArgs e)
        {
            InstanciaServico();
            _servico.Pausar();
        }

        private void Btn_Cancelar(object sender, EventArgs e)
        {
            InstanciaServico();
            _servico.Cancelar();
        }

        private void Btn_InicioRapido(object sender, EventArgs e)
        {
            InstanciaServico();
            _servico.InicioRapido();
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
    }
}
