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
            this.button_ligar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_pausar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ligar
            // 
            this.button_ligar.Location = new System.Drawing.Point(179, 166);
            this.button_ligar.Name = "button_ligar";
            this.button_ligar.Size = new System.Drawing.Size(75, 23);
            this.button_ligar.TabIndex = 0;
            this.button_ligar.Text = "Ligar";
            this.button_ligar.UseVisualStyleBackColor = true;
            this.button_ligar.Click += new System.EventHandler(this.Btn_Ligar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Potência";
            // 
            // button_pausar
            // 
            this.button_pausar.Location = new System.Drawing.Point(260, 166);
            this.button_pausar.Name = "button_pausar";
            this.button_pausar.Size = new System.Drawing.Size(75, 23);
            this.button_pausar.TabIndex = 5;
            this.button_pausar.Text = "Pausar";
            this.button_pausar.UseVisualStyleBackColor = true;
            this.button_pausar.Click += new System.EventHandler(this.Btn_Pausar);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(341, 166);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.Btn_Cancelar);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(293, 85);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTempo_KeyPress);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(293, 116);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 8;
            this.txtPotencia.Text = "10";
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPotencia_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Início Rápido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(422, 101);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 10;
            // 
            // MicroOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_pausar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ligar);
            this.Name = "MicroOndas";
            this.Text = "Micro Ondas Digital";
            this.Click += new System.EventHandler(this.Btn_InicioRapido);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ligar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_pausar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensagem;
    }
}

