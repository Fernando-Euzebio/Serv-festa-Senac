namespace WindowsFormsAppProjetoServ_Festa
{
    partial class frmsaida
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
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_saida = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodMovimentacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodProduto.Location = new System.Drawing.Point(534, 71);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(62, 20);
            this.txtCodProduto.TabIndex = 60;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 37);
            this.label8.TabIndex = 59;
            this.label8.Text = "Movimentação de Mercadoria";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpar.Location = new System.Drawing.Point(326, 213);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(120, 24);
            this.btn_limpar.TabIndex = 58;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrada.Location = new System.Drawing.Point(24, 213);
            this.btn_entrada.Margin = new System.Windows.Forms.Padding(2);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(120, 24);
            this.btn_entrada.TabIndex = 57;
            this.btn_entrada.Text = "Entrada";
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.btn_entrada_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(473, 213);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(120, 24);
            this.btn_sair.TabIndex = 56;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(236, 139);
            this.dataTime.Margin = new System.Windows.Forms.Padding(2);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(210, 20);
            this.dataTime.TabIndex = 55;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(534, 139);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(59, 20);
            this.txtTipo.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(472, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tipo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(354, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Código Mercadoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data de movimentação :";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(142, 172);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(101, 20);
            this.txtSaldo.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Quantidade :";
            // 
            // btn_saida
            // 
            this.btn_saida.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_saida.Location = new System.Drawing.Point(175, 213);
            this.btn_saida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saida.Name = "btn_saida";
            this.btn_saida.Size = new System.Drawing.Size(120, 24);
            this.btn_saida.TabIndex = 63;
            this.btn_saida.Text = "Saída";
            this.btn_saida.UseVisualStyleBackColor = false;
            this.btn_saida.Click += new System.EventHandler(this.btn_saida_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(503, 20);
            this.txtNome.TabIndex = 64;
            // 
            // txtCodMovimentacao
            // 
            this.txtCodMovimentacao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCodMovimentacao.Location = new System.Drawing.Point(228, 71);
            this.txtCodMovimentacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodMovimentacao.Name = "txtCodMovimentacao";
            this.txtCodMovimentacao.ReadOnly = true;
            this.txtCodMovimentacao.Size = new System.Drawing.Size(62, 20);
            this.txtCodMovimentacao.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 24);
            this.label6.TabIndex = 65;
            this.label6.Text = "Código Movimentação:";
            // 
            // frmsaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(620, 266);
            this.Controls.Add(this.txtCodMovimentacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btn_saida);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_entrada);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de mercadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_saida;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodMovimentacao;
        private System.Windows.Forms.Label label6;
    }
}