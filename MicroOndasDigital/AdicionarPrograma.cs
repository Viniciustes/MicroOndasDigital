using MicroOndasDigital.Servico;
using MicroOndasDigital.Servico.Dtos;
using MicroOndasDigital.Servico.Interface;
using System;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class AdicionarPrograma : Form
    {
        private IServico _servico;

        public AdicionarPrograma()
        {
            InitializeComponent();
        }

        private void btnAdicionarPrograma_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtPrograma.Text))
            {
                lblMensagem.Text = Constantes.VALOR_PROGRAMA_INCORRETO;
                return;
            }

            var tipoAquecimento = new DtoTipoAquecimento
            {
                Potencia = Convert.ToInt16(txtPotencia.Text),
                Tempo = Convert.ToInt16(txtTempo.Text),
                Nome = txtPrograma.Text
            };

            _servico = new Servico.Servico();
            var programa = _servico.AdicionarPrograma(tipoAquecimento);
            if (programa.EhValido)
            {
                Close();
            }
            else
            {
                lblMensagem.Text = programa.Mensagem;
            }
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
