
namespace Aula04AppBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.BtnExtrato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeposito = new System.Windows.Forms.Button();
            this.LblOperação = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnSaque = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConraditO\'s Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seu saldo atual:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(58, 88);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(39, 16);
            this.LblSaldo.TabIndex = 2;
            this.LblSaldo.Text = "R$ 0";
            this.LblSaldo.Click += new System.EventHandler(this.LblSaldo_Click);
            // 
            // BtnExtrato
            // 
            this.BtnExtrato.Location = new System.Drawing.Point(202, 59);
            this.BtnExtrato.Name = "BtnExtrato";
            this.BtnExtrato.Size = new System.Drawing.Size(75, 23);
            this.BtnExtrato.TabIndex = 3;
            this.BtnExtrato.Text = "Ver extrato";
            this.BtnExtrato.UseVisualStyleBackColor = true;
            this.BtnExtrato.Click += new System.EventHandler(this.BtnExtrato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BtnDeposito);
            this.groupBox1.Controls.Add(this.BtnSaque);
            this.groupBox1.Location = new System.Drawing.Point(61, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações disponíveis";
            // 
            // BtnDeposito
            // 
            this.BtnDeposito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDeposito.ForeColor = System.Drawing.Color.Blue;
            this.BtnDeposito.Location = new System.Drawing.Point(6, 21);
            this.BtnDeposito.Name = "BtnDeposito";
            this.BtnDeposito.Size = new System.Drawing.Size(85, 32);
            this.BtnDeposito.TabIndex = 6;
            this.BtnDeposito.Text = "Deposítar";
            this.BtnDeposito.UseVisualStyleBackColor = false;
            this.BtnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // LblOperação
            // 
            this.LblOperação.AutoSize = true;
            this.LblOperação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperação.Location = new System.Drawing.Point(15, 16);
            this.LblOperação.Name = "LblOperação";
            this.LblOperação.Size = new System.Drawing.Size(70, 13);
            this.LblOperação.TabIndex = 6;
            this.LblOperação.Text = "DEPÓSITO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Informe o valor.";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(6, 55);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(155, 20);
            this.TxtValor.TabIndex = 6;
            this.TxtValor.Text = "5000";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(6, 81);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(155, 23);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnSaque
            // 
            this.BtnSaque.Location = new System.Drawing.Point(107, 21);
            this.BtnSaque.Name = "BtnSaque";
            this.BtnSaque.Size = new System.Drawing.Size(93, 32);
            this.BtnSaque.TabIndex = 6;
            this.BtnSaque.Text = "Sacar";
            this.BtnSaque.UseVisualStyleBackColor = true;
            this.BtnSaque.Click += new System.EventHandler(this.BtnSaque_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSalvar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtValor);
            this.groupBox2.Controls.Add(this.LblOperação);
            this.groupBox2.Location = new System.Drawing.Point(6, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 120);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExtrato);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Button BtnExtrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label LblOperação;
        private System.Windows.Forms.Button BtnDeposito;
        private System.Windows.Forms.Button BtnSaque;
    }
}

