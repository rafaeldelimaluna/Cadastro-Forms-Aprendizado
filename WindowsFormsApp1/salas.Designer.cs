﻿
namespace WindowsFormsApp1
{
    partial class salas
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
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.PCsNumberEntry = new System.Windows.Forms.TextBox();
            this.EmailEntry = new System.Windows.Forms.TextBox();
            this.BuildingEntry = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.IsLabChk = new System.Windows.Forms.CheckBox();
            this.RegisterRoomHeaderLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RegisterRoomHeaderPanel = new System.Windows.Forms.Panel();
            this.RegisterRoomHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(60, 178);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(218, 20);
            this.NameEntry.TabIndex = 0;
            this.NameEntry.Text = "Nome da Sala";
            this.NameEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NameEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            // 
            // PCsNumberEntry
            // 
            this.PCsNumberEntry.Location = new System.Drawing.Point(60, 204);
            this.PCsNumberEntry.Name = "PCsNumberEntry";
            this.PCsNumberEntry.Size = new System.Drawing.Size(218, 20);
            this.PCsNumberEntry.TabIndex = 1;
            this.PCsNumberEntry.Text = "Numero de Pcs";
            this.PCsNumberEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            // 
            // EmailEntry
            // 
            this.EmailEntry.Location = new System.Drawing.Point(60, 230);
            this.EmailEntry.Name = "EmailEntry";
            this.EmailEntry.Size = new System.Drawing.Size(218, 20);
            this.EmailEntry.TabIndex = 2;
            this.EmailEntry.Text = "Número de Cadeiras";
            this.EmailEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            // 
            // BuildingEntry
            // 
            this.BuildingEntry.Location = new System.Drawing.Point(60, 256);
            this.BuildingEntry.Name = "BuildingEntry";
            this.BuildingEntry.Size = new System.Drawing.Size(218, 20);
            this.BuildingEntry.TabIndex = 3;
            this.BuildingEntry.Text = "Prédio";
            this.BuildingEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(104, 305);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 50);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsLabChk
            // 
            this.IsLabChk.AutoSize = true;
            this.IsLabChk.Location = new System.Drawing.Point(60, 282);
            this.IsLabChk.Name = "IsLabChk";
            this.IsLabChk.Size = new System.Drawing.Size(79, 17);
            this.IsLabChk.TabIndex = 5;
            this.IsLabChk.Text = "Laboratório";
            this.IsLabChk.UseVisualStyleBackColor = true;
            // 
            // RegisterRoomHeaderLabel
            // 
            this.RegisterRoomHeaderLabel.AutoSize = true;
            this.RegisterRoomHeaderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 24F);
            this.RegisterRoomHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.RegisterRoomHeaderLabel.Location = new System.Drawing.Point(14, 18);
            this.RegisterRoomHeaderLabel.Name = "RegisterRoomHeaderLabel";
            this.RegisterRoomHeaderLabel.Size = new System.Drawing.Size(288, 41);
            this.RegisterRoomHeaderLabel.TabIndex = 6;
            this.RegisterRoomHeaderLabel.Text = "Cadastro de Salas";
            this.RegisterRoomHeaderLabel.Click += new System.EventHandler(this.SalasCadastroHeaderLabel_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(104, 361);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 25);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterRoomHeaderPanel
            // 
            this.RegisterRoomHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegisterRoomHeaderPanel.Controls.Add(this.RegisterRoomHeaderLabel);
            this.RegisterRoomHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterRoomHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RegisterRoomHeaderPanel.Name = "RegisterRoomHeaderPanel";
            this.RegisterRoomHeaderPanel.Size = new System.Drawing.Size(327, 73);
            this.RegisterRoomHeaderPanel.TabIndex = 8;
            // 
            // salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.RegisterRoomHeaderPanel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.IsLabChk);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.BuildingEntry);
            this.Controls.Add(this.EmailEntry);
            this.Controls.Add(this.PCsNumberEntry);
            this.Controls.Add(this.NameEntry);
            this.Name = "salas";
            this.Text = "salas";
            this.RegisterRoomHeaderPanel.ResumeLayout(false);
            this.RegisterRoomHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.TextBox PCsNumberEntry;
        private System.Windows.Forms.TextBox EmailEntry;
        private System.Windows.Forms.TextBox BuildingEntry;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.CheckBox IsLabChk;
        private System.Windows.Forms.Label RegisterRoomHeaderLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel RegisterRoomHeaderPanel;
    }
}