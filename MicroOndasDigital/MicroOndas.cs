using MicroOndasDigital.Servico;
using MicroOndasDigital.Servico.Dtos;
using MicroOndasDigital.Servico.Interface;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class MicroOndas : Form
    {
        int _tempo;
        private IServico _servico;

        public MicroOndas()
        {
            InitializeComponent();
        }

        private void InstanciaServico()
        {
            _servico = new Servico.Servico();
        }

        private void MicroOndas_Load(object sender, EventArgs e)
        {
            txtPotencia.Text = Constantes.POTENCIA_PADRAO.ToString();
            PopularListBoxPrograma();
            ZerarCampos();
        }

        private void PopularListBoxPrograma()
        {
            InstanciaServico();
            var listaProgramas = _servico.ListarTiposAquecimento();

            cmbPrograma.DataSource = null;
            cmbPrograma.ValueMember = "Id";
            cmbPrograma.DisplayMember = "Nome";
            cmbPrograma.DataSource = listaProgramas;
            cmbPrograma.SelectedIndex = -1;
        }

        private void LigarMicroOndasPorPrograma(int idPrograma)
        {
            InstanciaServico();
            var microOndasDigital = _servico.RecuperarPorPrograma(idPrograma);
            IniciarContagemPorTempo(microOndasDigital.Tempo);
        }

        private void Btn_Ligar(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex != -1)
            {
                var idPrograma = (int)cmbPrograma.SelectedValue;
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
            lblPonto.Visible = true;

            var potencia = Convert.ToInt16(txtPotencia.Text);
            var ponto = new string('.', potencia);

            lblPonto.Text = lblPonto.Text + ponto;

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
            cmbPrograma.SelectedIndex = -1;
            lblPonto.Text = string.Empty;
        }

        private void IniciarContagemPorTempo(int tempo)
        {
            _tempo = tempo;
            tmpTempo.Start();
        }

        private void CmbPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex != -1)
            {
                InstanciaServico();
                var idPrograma = (int)cmbPrograma.SelectedValue;
                var programa = _servico.RecuperarPorPrograma(idPrograma);

                txtPotencia.Text = programa.Potencia.ToString();
                txtTempo.Text = programa.Tempo.ToString();
            }
        }

        private void Cmb_Programa(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex == -1)
            {
                ZerarCampos();
            }
        }

        private void BtnAdicionarPrograma_Click(object sender, EventArgs e)
        {
            var adicionarPrograma = new AdicionarPrograma();
            adicionarPrograma.FormClosing += new FormClosingEventHandler(SaindoFormAdicionarProgramas);
            adicionarPrograma.Show();
        }

        private void SaindoFormAdicionarProgramas(object sender, FormClosingEventArgs e)
        {
            PopularListBoxPrograma();
            ZerarCampos();
        }
    }
}
