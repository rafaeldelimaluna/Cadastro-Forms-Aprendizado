﻿
namespace WindowsFormsApp1
{
    partial class Cursos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.AreaTbx = new System.Windows.Forms.TextBox();
            this.HorarioInicioTbx = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.HorarioFimTbx = new System.Windows.Forms.TextBox();
            this.DuracaoTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(12, 8);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(165, 20);
            this.NomeTbx.TabIndex = 1;
            // 
            // AreaTbx
            // 
            this.AreaTbx.Location = new System.Drawing.Point(12, 34);
            this.AreaTbx.Name = "AreaTbx";
            this.AreaTbx.Size = new System.Drawing.Size(165, 20);
            this.AreaTbx.TabIndex = 2;
            // 
            // HorarioInicioTbx
            // 
            this.HorarioInicioTbx.Location = new System.Drawing.Point(12, 60);
            this.HorarioInicioTbx.Name = "HorarioInicioTbx";
            this.HorarioInicioTbx.Size = new System.Drawing.Size(165, 20);
            this.HorarioInicioTbx.TabIndex = 3;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 189);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(165, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 218);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(165, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // HorarioFimTbx
            // 
            this.HorarioFimTbx.Location = new System.Drawing.Point(12, 86);
            this.HorarioFimTbx.Name = "HorarioFimTbx";
            this.HorarioFimTbx.Size = new System.Drawing.Size(165, 20);
            this.HorarioFimTbx.TabIndex = 9;
            // 
            // DuracaoTbx
            // 
            this.DuracaoTbx.Location = new System.Drawing.Point(12, 112);
            this.DuracaoTbx.Name = "DuracaoTbx";
            this.DuracaoTbx.Size = new System.Drawing.Size(165, 20);
            this.DuracaoTbx.TabIndex = 10;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 341);
            this.Controls.Add(this.DuracaoTbx);
            this.Controls.Add(this.HorarioFimTbx);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.HorarioInicioTbx);
            this.Controls.Add(this.AreaTbx);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox AreaTbx;
        private System.Windows.Forms.TextBox HorarioInicioTbx;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox HorarioFimTbx;
        private System.Windows.Forms.TextBox DuracaoTbx;
    }
}