﻿
namespace WindowsFormsApp1
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeCompletoTbx = new System.Windows.Forms.TextBox();
            this.SenhaTbx = new System.Windows.Forms.TextBox();
            this.CursoTbx = new System.Windows.Forms.TextBox();
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Usuarios";
            // 
            // NomeCompletoTbx
            // 
            this.NomeCompletoTbx.Location = new System.Drawing.Point(3, 48);
            this.NomeCompletoTbx.Name = "NomeCompletoTbx";
            this.NomeCompletoTbx.Size = new System.Drawing.Size(139, 20);
            this.NomeCompletoTbx.TabIndex = 1;
            this.NomeCompletoTbx.Text = "Nome Completo";
            this.NomeCompletoTbx.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // SenhaTbx
            // 
            this.SenhaTbx.Location = new System.Drawing.Point(3, 126);
            this.SenhaTbx.Name = "SenhaTbx";
            this.SenhaTbx.PasswordChar = '*';
            this.SenhaTbx.Size = new System.Drawing.Size(139, 20);
            this.SenhaTbx.TabIndex = 3;
            this.SenhaTbx.Text = "Senha";
            this.SenhaTbx.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // CursoTbx
            // 
            this.CursoTbx.Location = new System.Drawing.Point(3, 100);
            this.CursoTbx.Name = "CursoTbx";
            this.CursoTbx.Size = new System.Drawing.Size(139, 20);
            this.CursoTbx.TabIndex = 4;
            this.CursoTbx.Text = "Curso";
            this.CursoTbx.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // EmailTbx
            // 
            this.EmailTbx.Location = new System.Drawing.Point(3, 74);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(139, 20);
            this.EmailTbx.TabIndex = 5;
            this.EmailTbx.Text = "Email";
            this.EmailTbx.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(3, 152);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(139, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(3, 181);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(139, 23);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 236);
            this.dataGridView1.TabIndex = 8;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 289);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.CursoTbx);
            this.Controls.Add(this.SenhaTbx);
            this.Controls.Add(this.NomeCompletoTbx);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeCompletoTbx;
        private System.Windows.Forms.TextBox SenhaTbx;
        private System.Windows.Forms.TextBox CursoTbx;
        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}