﻿namespace MicroOndasDigital
{
    partial class AdicionarPrograma
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
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(103, 170);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(136, 23);
            this.btnAdicionarPrograma.TabIndex = 26;
            this.btnAdicionarPrograma.Text = "Gravar Programa";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.btnAdicionarPrograma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Segundos";
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(47, 133);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(52, 13);
            this.lblPrograma.TabIndex = 23;
            this.lblPrograma.Text = "Programa";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(103, 95);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(121, 20);
            this.txtPotencia.TabIndex = 22;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPotencia_KeyPress);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(103, 64);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(121, 20);
            this.txtTempo.TabIndex = 21;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTempo_KeyPress);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(47, 98);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 20;
            this.lblPotencia.Text = "Potência";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(56, 67);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 19;
            this.lblTempo.Text = "Tempo";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMensagem.Location = new System.Drawing.Point(44, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 36);
            this.lblMensagem.TabIndex = 27;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(103, 130);
            this.txtPrograma.MaxLength = 15;
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(121, 20);
            this.txtPrograma.TabIndex = 28;
            // 
            // AdicionarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 208);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnAdicionarPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblTempo);
            this.Name = "AdicionarPrograma";
            this.Text = "AdicionarPrograma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtPrograma;
    }
}