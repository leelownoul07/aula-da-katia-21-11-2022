namespace WindowsFormsApp1
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
            this.txTitular = new System.Windows.Forms.Label();
            this.txAgência = new System.Windows.Forms.Label();
            this.txNConta = new System.Windows.Forms.Label();
            this.txSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtNConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCriar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.txtDepositar = new System.Windows.Forms.Button();
            this.txtSacar = new System.Windows.Forms.Button();
            this.txtExibirSaldo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txTitular
            // 
            this.txTitular.AutoSize = true;
            this.txTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTitular.Location = new System.Drawing.Point(101, 96);
            this.txTitular.Name = "txTitular";
            this.txTitular.Size = new System.Drawing.Size(47, 16);
            this.txTitular.TabIndex = 0;
            this.txTitular.Text = "Titular:";
            this.txTitular.Click += new System.EventHandler(this.label1_Click);
            // 
            // txAgência
            // 
            this.txAgência.AutoSize = true;
            this.txAgência.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAgência.Location = new System.Drawing.Point(101, 150);
            this.txAgência.Name = "txAgência";
            this.txAgência.Size = new System.Drawing.Size(60, 16);
            this.txAgência.TabIndex = 1;
            this.txAgência.Text = "Agência:";
            // 
            // txNConta
            // 
            this.txNConta.AutoSize = true;
            this.txNConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNConta.Location = new System.Drawing.Point(97, 222);
            this.txNConta.Name = "txNConta";
            this.txNConta.Size = new System.Drawing.Size(62, 16);
            this.txNConta.TabIndex = 2;
            this.txNConta.Text = "N° Conta:";
            // 
            // txSaldo
            // 
            this.txSaldo.AutoSize = true;
            this.txSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSaldo.Location = new System.Drawing.Point(101, 289);
            this.txSaldo.Name = "txSaldo";
            this.txSaldo.Size = new System.Drawing.Size(46, 16);
            this.txSaldo.TabIndex = 3;
            this.txSaldo.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Abrir Conta";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(194, 96);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 5;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(194, 150);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 6;
            // 
            // txtNConta
            // 
            this.txtNConta.Location = new System.Drawing.Point(194, 222);
            this.txtNConta.Name = "txtNConta";
            this.txtNConta.Size = new System.Drawing.Size(100, 20);
            this.txtNConta.TabIndex = 7;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(194, 288);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtCriar
            // 
            this.txtCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriar.Location = new System.Drawing.Point(148, 340);
            this.txtCriar.Name = "txtCriar";
            this.txtCriar.Size = new System.Drawing.Size(75, 23);
            this.txtCriar.TabIndex = 9;
            this.txtCriar.Text = "Criar";
            this.txtCriar.UseVisualStyleBackColor = true;
            this.txtCriar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtExibirSaldo);
            this.panel1.Controls.Add(this.txtSacar);
            this.panel1.Controls.Add(this.txtDepositar);
            this.panel1.Controls.Add(this.textValor);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Location = new System.Drawing.Point(424, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 339);
            this.panel1.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(34, 45);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(42, 16);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "Valor:";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(82, 44);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 11;
            // 
            // txtDepositar
            // 
            this.txtDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositar.Location = new System.Drawing.Point(145, 158);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(114, 23);
            this.txtDepositar.TabIndex = 12;
            this.txtDepositar.Text = "Depositar";
            this.txtDepositar.UseVisualStyleBackColor = true;
            this.txtDepositar.Click += new System.EventHandler(this.txtDepositar_Click);
            // 
            // txtSacar
            // 
            this.txtSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSacar.Location = new System.Drawing.Point(145, 214);
            this.txtSacar.Name = "txtSacar";
            this.txtSacar.Size = new System.Drawing.Size(114, 23);
            this.txtSacar.TabIndex = 13;
            this.txtSacar.Text = "Sacar";
            this.txtSacar.UseVisualStyleBackColor = true;
            this.txtSacar.Click += new System.EventHandler(this.txtSacar_Click);
            // 
            // txtExibirSaldo
            // 
            this.txtExibirSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibirSaldo.Location = new System.Drawing.Point(145, 277);
            this.txtExibirSaldo.Name = "txtExibirSaldo";
            this.txtExibirSaldo.Size = new System.Drawing.Size(114, 23);
            this.txtExibirSaldo.TabIndex = 14;
            this.txtExibirSaldo.Text = "Exibir Saldo";
            this.txtExibirSaldo.UseVisualStyleBackColor = true;
            this.txtExibirSaldo.Click += new System.EventHandler(this.txtExibirSaldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCriar);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txSaldo);
            this.Controls.Add(this.txNConta);
            this.Controls.Add(this.txAgência);
            this.Controls.Add(this.txTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txTitular;
        private System.Windows.Forms.Label txAgência;
        private System.Windows.Forms.Label txNConta;
        private System.Windows.Forms.Label txSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtNConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button txtCriar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtExibirSaldo;
        private System.Windows.Forms.Button txtSacar;
        private System.Windows.Forms.Button txtDepositar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label txtValor;
    }
}

