﻿namespace AspNet.Cap001.Troco {
    partial class TrocoForm {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 0);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.trocoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasimageList = new System.Windows.Forms.ImageList(this.components);
            this.moedasListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.trocoTextBox);
            this.groupBox1.Controls.Add(this.valorPagoTextBox);
            this.groupBox1.Controls.Add(this.valorCompraTextBox);
            this.groupBox1.Controls.Add(this.calcularButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da &Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor da &Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor da &Troco";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(12, 232);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(230, 115);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "C&alcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(100, 13);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(142, 20);
            this.valorCompraTextBox.TabIndex = 1;
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.Location = new System.Drawing.Point(100, 85);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(142, 20);
            this.valorPagoTextBox.TabIndex = 3;
            // 
            // trocoTextBox
            // 
            this.trocoTextBox.Enabled = false;
            this.trocoTextBox.Location = new System.Drawing.Point(100, 157);
            this.trocoTextBox.Name = "trocoTextBox";
            this.trocoTextBox.ReadOnly = true;
            this.trocoTextBox.Size = new System.Drawing.Size(142, 20);
            this.trocoTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.moedasListView);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moedas";
            // 
            // moedasimageList
            // 
            this.moedasimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasimageList.ImageStream")));
            this.moedasimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasimageList.Images.SetKeyName(0, "1.png");
            this.moedasimageList.Images.SetKeyName(1, "5.png");
            this.moedasimageList.Images.SetKeyName(2, "10.png");
            this.moedasimageList.Images.SetKeyName(3, "25.png");
            this.moedasimageList.Images.SetKeyName(4, "50.png");
            this.moedasimageList.Images.SetKeyName(5, "100.png");
            // 
            // moedasListView
            // 
            this.moedasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.moedasListView.LargeImageList = this.moedasimageList;
            this.moedasListView.Location = new System.Drawing.Point(3, 16);
            this.moedasListView.Name = "moedasListView";
            this.moedasListView.Size = new System.Drawing.Size(593, 407);
            this.moedasListView.TabIndex = 2;
            this.moedasListView.UseCompatibleStateImageBehavior = false;
            this.moedasListView.SelectedIndexChanged += new System.EventHandler(this.moedasListView_SelectedIndexChanged);
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.Text = "Calculadora de Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox trocoTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView moedasListView;
        private System.Windows.Forms.ImageList moedasimageList;
    }
}

