﻿namespace ImpactaAspNet.Capitulo001.Variaveis
{
    partial class VariaveisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariaveisForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.ternarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(378, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem,
            this.incrementaisDecrementaisToolStripMenuItem,
            this.boleanasToolStripMenuItem,
            this.logicasToolStripMenuItem,
            this.ternarioToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            this.operaçõesToolStripMenuItem.Click += new System.EventHandler(this.operaçõesToolStripMenuItem_Click);
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduzidasToolStripMenuItem});
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aritmeticasToolStripMenuItem.Text = "&Aritméticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritmeticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrementaisDecrementaisToolStripMenuItem
            // 
            this.incrementaisDecrementaisToolStripMenuItem.Name = "incrementaisDecrementaisToolStripMenuItem";
            this.incrementaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.incrementaisDecrementaisToolStripMenuItem.Text = "Incrementais/Decrementais";
            this.incrementaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrementaisDecrementaisToolStripMenuItem_Click);
            // 
            // boleanasToolStripMenuItem
            // 
            this.boleanasToolStripMenuItem.Name = "boleanasToolStripMenuItem";
            this.boleanasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.boleanasToolStripMenuItem.Text = "&Boleanas";
            this.boleanasToolStripMenuItem.Click += new System.EventHandler(this.boleanasToolStripMenuItem_Click);
            // 
            // logicasToolStripMenuItem
            // 
            this.logicasToolStripMenuItem.Name = "logicasToolStripMenuItem";
            this.logicasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.logicasToolStripMenuItem.Text = "&Lógicas";
            this.logicasToolStripMenuItem.Click += new System.EventHandler(this.logicasToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(378, 426);
            this.resultadoListBox.TabIndex = 2;
            // 
            // ternarioToolStripMenuItem
            // 
            this.ternarioToolStripMenuItem.Name = "ternarioToolStripMenuItem";
            this.ternarioToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ternarioToolStripMenuItem.Text = "&Ternário";
            this.ternarioToolStripMenuItem.Click += new System.EventHandler(this.ternarioToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VariaveisForm";
            this.Text = "Variáveis";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternarioToolStripMenuItem;
    }
}

