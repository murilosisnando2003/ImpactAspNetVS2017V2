﻿namespace Capitulo01.Variaveis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacoesToolStripMenuItem
            // 
            this.operacoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrementaisDecrementaisToolStripMenuItem,
            this.boleanasToolStripMenuItem,
            this.logicasToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operacoesToolStripMenuItem.Name = "operacoesToolStripMenuItem";
            this.operacoesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.operacoesToolStripMenuItem.Text = "&Operacoes";
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aritmeticasToolStripMenuItem.Text = "&Aritmeticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritmeticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
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
            this.boleanasToolStripMenuItem.Text = "&Booleanas";
            this.boleanasToolStripMenuItem.Click += new System.EventHandler(this.boleanasToolStripMenuItem_Click);
            // 
            // logicasToolStripMenuItem
            // 
            this.logicasToolStripMenuItem.Name = "logicasToolStripMenuItem";
            this.logicasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.logicasToolStripMenuItem.Text = "&Logicas";
            this.logicasToolStripMenuItem.Click += new System.EventHandler(this.logicasToolStripMenuItem_Click);
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ternariasToolStripMenuItem.Text = "&Ternarias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(449, 313);
            this.resultadoListBox.TabIndex = 1;
            this.resultadoListBox.SelectedIndexChanged += new System.EventHandler(this.resultadoListBox_SelectedIndexChanged);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 337);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variaveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

