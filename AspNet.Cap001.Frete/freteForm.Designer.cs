namespace AspNet.Cap001.Frete
{
    partial class freteForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.calculaButton = new System.Windows.Forms.Button();
            this.freteGroupBox = new System.Windows.Forms.GroupBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.freteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Frete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Total";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(72, 20);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(299, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(72, 60);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(72, 157);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.ReadOnly = true;
            this.freteTextBox.Size = new System.Drawing.Size(121, 20);
            this.freteTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(72, 215);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // ufComboBox
            // 
            this.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(72, 102);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            // 
            // calculaButton
            // 
            this.calculaButton.Location = new System.Drawing.Point(28, 286);
            this.calculaButton.Name = "calculaButton";
            this.calculaButton.Size = new System.Drawing.Size(203, 77);
            this.calculaButton.TabIndex = 10;
            this.calculaButton.Text = "C&alcular";
            this.calculaButton.UseVisualStyleBackColor = true;
            this.calculaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // freteGroupBox
            // 
            this.freteGroupBox.Controls.Add(this.limparButton);
            this.freteGroupBox.Controls.Add(this.calculaButton);
            this.freteGroupBox.Controls.Add(this.ufComboBox);
            this.freteGroupBox.Controls.Add(this.totalTextBox);
            this.freteGroupBox.Controls.Add(this.freteTextBox);
            this.freteGroupBox.Controls.Add(this.valorTextBox);
            this.freteGroupBox.Controls.Add(this.clienteTextBox);
            this.freteGroupBox.Controls.Add(this.label5);
            this.freteGroupBox.Controls.Add(this.label4);
            this.freteGroupBox.Controls.Add(this.label3);
            this.freteGroupBox.Controls.Add(this.label2);
            this.freteGroupBox.Controls.Add(this.label1);
            this.freteGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freteGroupBox.Location = new System.Drawing.Point(0, 0);
            this.freteGroupBox.Name = "freteGroupBox";
            this.freteGroupBox.Size = new System.Drawing.Size(800, 450);
            this.freteGroupBox.TabIndex = 0;
            this.freteGroupBox.TabStop = false;
            this.freteGroupBox.Text = "Calcula Frete";
            // 
            // limparButton
            // 
            this.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparButton.Location = new System.Drawing.Point(258, 286);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(203, 77);
            this.limparButton.TabIndex = 11;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // freteForm
            // 
            this.AcceptButton = this.calculaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.freteGroupBox);
            this.Name = "freteForm";
            this.Text = "Calculo de Frete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.freteGroupBox.ResumeLayout(false);
            this.freteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.Button calculaButton;
        private System.Windows.Forms.GroupBox freteGroupBox;
        private System.Windows.Forms.Button limparButton;
    }
}

