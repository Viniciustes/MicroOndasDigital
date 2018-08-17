namespace MicroOndasDigital
{
    partial class MicroOndas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_ligar = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.button_pausar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tmpTempo = new System.Windows.Forms.Timer(this.components);
            this.lblPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ligar
            // 
            this.button_ligar.Location = new System.Drawing.Point(167, 265);
            this.button_ligar.Name = "button_ligar";
            this.button_ligar.Size = new System.Drawing.Size(75, 23);
            this.button_ligar.TabIndex = 0;
            this.button_ligar.Text = "Ligar";
            this.button_ligar.UseVisualStyleBackColor = true;
            this.button_ligar.Click += new System.EventHandler(this.Btn_Ligar);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(244, 135);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(235, 166);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 3;
            this.lblPotencia.Text = "Potência";
            // 
            // button_pausar
            // 
            this.button_pausar.Location = new System.Drawing.Point(248, 265);
            this.button_pausar.Name = "button_pausar";
            this.button_pausar.Size = new System.Drawing.Size(75, 23);
            this.button_pausar.TabIndex = 5;
            this.button_pausar.Text = "Pausar";
            this.button_pausar.UseVisualStyleBackColor = true;
            this.button_pausar.Click += new System.EventHandler(this.Btn_Pausar);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(329, 265);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.Btn_Cancelar);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(291, 132);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(121, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTempo_KeyPress);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(291, 163);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(121, 20);
            this.txtPotencia.TabIndex = 8;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPotencia_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Início Rápido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_InicioRapido);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMensagem.Location = new System.Drawing.Point(311, 38);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(219, 36);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "Retirar Depois";
            // 
            // tmpTempo
            // 
            this.tmpTempo.Interval = 1000;
            this.tmpTempo.Tick += new System.EventHandler(this.TmpTempo_Tick);
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(235, 201);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(52, 13);
            this.lblPrograma.TabIndex = 12;
            this.lblPrograma.Text = "Programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Segundos";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Location = new System.Drawing.Point(291, 198);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(121, 21);
            this.cmbPrograma.TabIndex = 16;
            this.cmbPrograma.SelectedIndexChanged += new System.EventHandler(this.CmbPrograma_SelectedIndexChanged);
            this.cmbPrograma.Leave += new System.EventHandler(this.Cmb_Programa);
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.Location = new System.Drawing.Point(288, 74);
            this.lblPonto.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(35, 13);
            this.lblPonto.TabIndex = 17;
            this.lblPonto.Text = "label2";
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(421, 198);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(136, 23);
            this.btnAdicionarPrograma.TabIndex = 18;
            this.btnAdicionarPrograma.Text = "Adicionar Programa";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.BtnAdicionarPrograma_Click);
            // 
            // MicroOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.btnAdicionarPrograma);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.cmbPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_pausar);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.button_ligar);
            this.Name = "MicroOndas";
            this.Text = "Micro Ondas Digital";
            this.Load += new System.EventHandler(this.MicroOndas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ligar;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Button button_pausar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer tmpTempo;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrograma;
        private System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Button btnAdicionarPrograma;
    }
}

