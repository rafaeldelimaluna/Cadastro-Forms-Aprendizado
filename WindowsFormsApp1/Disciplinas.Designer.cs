﻿
namespace WindowsFormsApp1
{
    partial class Disciplinas
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
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.SiglaTbx = new System.Windows.Forms.TextBox();
            this.isAtivoChk = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Disciplinas";
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(12, 82);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(167, 20);
            this.NomeTbx.TabIndex = 1;
            this.NomeTbx.Text = "Nome";
            this.NomeTbx.TextChanged += new System.EventHandler(this.NomeTbx_TextChanged);
            this.NomeTbx.Enter += new System.EventHandler(this.NomeTbx_Enter);
            // 
            // SiglaTbx
            // 
            this.SiglaTbx.Location = new System.Drawing.Point(12, 108);
            this.SiglaTbx.Name = "SiglaTbx";
            this.SiglaTbx.Size = new System.Drawing.Size(167, 20);
            this.SiglaTbx.TabIndex = 2;
            this.SiglaTbx.Text = "Sigla";
            this.SiglaTbx.TextChanged += new System.EventHandler(this.SiglaTbx_TextChanged);
            this.SiglaTbx.Enter += new System.EventHandler(this.SiglaTbx_Enter);
            // 
            // isAtivoChk
            // 
            this.isAtivoChk.AutoSize = true;
            this.isAtivoChk.Location = new System.Drawing.Point(12, 134);
            this.isAtivoChk.Name = "isAtivoChk";
            this.isAtivoChk.Size = new System.Drawing.Size(50, 17);
            this.isAtivoChk.TabIndex = 3;
            this.isAtivoChk.Text = "Ativo";
            this.isAtivoChk.UseVisualStyleBackColor = true;
            this.isAtivoChk.CheckedChanged += new System.EventHandler(this.isAtivoChk_CheckedChanged);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 167);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(167, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 196);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(167, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // IdTbx
            // 
            this.IdTbx.Location = new System.Drawing.Point(12, 56);
            this.IdTbx.Name = "IdTbx";
            this.IdTbx.Size = new System.Drawing.Size(167, 20);
            this.IdTbx.TabIndex = 7;
            this.IdTbx.Text = "Id";
            // 
            // Disciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.IdTbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.isAtivoChk);
            this.Controls.Add(this.SiglaTbx);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.label1);
            this.Name = "Disciplinas";
            this.Text = "Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox SiglaTbx;
        private System.Windows.Forms.CheckBox isAtivoChk;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IdTbx;
    }
}