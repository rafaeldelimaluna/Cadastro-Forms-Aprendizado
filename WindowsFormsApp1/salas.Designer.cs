﻿
namespace WindowsFormsApp1
{
    partial class Salas
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
            this.ChairEntry = new System.Windows.Forms.TextBox();
            this.BuildingEntry = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.IsLabChk = new System.Windows.Forms.CheckBox();
            this.RegisterRoomHeaderLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RegisterRoomHeaderPanel = new System.Windows.Forms.Panel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.RegistersHeaderCadastroSalas = new System.Windows.Forms.Label();
            this.SaveRegisterButton = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.RegisterRoomHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(60, 178);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(218, 20);
            this.NameEntry.TabIndex = 0;
            this.NameEntry.Text = "Nome da Sala";
            this.NameEntry.Enter += new System.EventHandler(this.NameEntry_Enter);
            this.NameEntry.Leave += new System.EventHandler(this.NameEntry_Enter);
            // 
            // PCsNumberEntry
            // 
            this.PCsNumberEntry.Location = new System.Drawing.Point(60, 204);
            this.PCsNumberEntry.Name = "PCsNumberEntry";
            this.PCsNumberEntry.Size = new System.Drawing.Size(218, 20);
            this.PCsNumberEntry.TabIndex = 1;
            this.PCsNumberEntry.Text = "Número de PCs";
            this.PCsNumberEntry.Enter += new System.EventHandler(this.PCsNumber_Enter);
            this.PCsNumberEntry.Leave += new System.EventHandler(this.PCsNumber_Enter);
            // 
            // ChairEntry
            // 
            this.ChairEntry.Location = new System.Drawing.Point(60, 230);
            this.ChairEntry.Name = "ChairEntry";
            this.ChairEntry.Size = new System.Drawing.Size(218, 20);
            this.ChairEntry.TabIndex = 2;
            this.ChairEntry.Text = "Número de Cadeiras";
            this.ChairEntry.Enter += new System.EventHandler(this.ChairEntry_Enter);
            this.ChairEntry.Leave += new System.EventHandler(this.ChairEntry_Enter);
            // 
            // BuildingEntry
            // 
            this.BuildingEntry.Location = new System.Drawing.Point(60, 256);
            this.BuildingEntry.Name = "BuildingEntry";
            this.BuildingEntry.Size = new System.Drawing.Size(218, 20);
            this.BuildingEntry.TabIndex = 3;
            this.BuildingEntry.Text = "Prédio";
            this.BuildingEntry.Enter += new System.EventHandler(this.BuildingEntry_Enter);
            this.BuildingEntry.Leave += new System.EventHandler(this.BuildingEntry_Enter);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(104, 305);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 50);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
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
            this.RegisterRoomHeaderLabel.Location = new System.Drawing.Point(275, 9);
            this.RegisterRoomHeaderLabel.Name = "RegisterRoomHeaderLabel";
            this.RegisterRoomHeaderLabel.Size = new System.Drawing.Size(288, 41);
            this.RegisterRoomHeaderLabel.TabIndex = 6;
            this.RegisterRoomHeaderLabel.Text = "Cadastro de Salas";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(104, 361);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 25);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RegisterRoomHeaderPanel
            // 
            this.RegisterRoomHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegisterRoomHeaderPanel.Controls.Add(this.RegisterRoomHeaderLabel);
            this.RegisterRoomHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterRoomHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RegisterRoomHeaderPanel.Name = "RegisterRoomHeaderPanel";
            this.RegisterRoomHeaderPanel.Size = new System.Drawing.Size(995, 73);
            this.RegisterRoomHeaderPanel.TabIndex = 8;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WarningLabel.Location = new System.Drawing.Point(59, 128);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 21);
            this.WarningLabel.TabIndex = 9;
            // 
            // RegistersHeaderCadastroSalas
            // 
            this.RegistersHeaderCadastroSalas.AutoSize = true;
            this.RegistersHeaderCadastroSalas.Location = new System.Drawing.Point(670, 128);
            this.RegistersHeaderCadastroSalas.Name = "RegistersHeaderCadastroSalas";
            this.RegistersHeaderCadastroSalas.Size = new System.Drawing.Size(54, 13);
            this.RegistersHeaderCadastroSalas.TabIndex = 11;
            this.RegistersHeaderCadastroSalas.Text = "Cadastros";
            // 
            // SaveRegisterButton
            // 
            this.SaveRegisterButton.Location = new System.Drawing.Point(424, 392);
            this.SaveRegisterButton.Name = "SaveRegisterButton";
            this.SaveRegisterButton.Size = new System.Drawing.Size(548, 23);
            this.SaveRegisterButton.TabIndex = 12;
            this.SaveRegisterButton.Text = "Salvar";
            this.SaveRegisterButton.UseVisualStyleBackColor = true;
            this.SaveRegisterButton.Click += new System.EventHandler(this.SaveRegisterButton_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(849, 415);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(123, 23);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Location = new System.Drawing.Point(424, 415);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(419, 23);
            this.DeleteRowBtn.TabIndex = 14;
            this.DeleteRowBtn.Text = "Excluir linha focada";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(424, 149);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(548, 237);
            this.Table.TabIndex = 15;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveRegisterButton);
            this.Controls.Add(this.RegistersHeaderCadastroSalas);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.RegisterRoomHeaderPanel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.IsLabChk);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.BuildingEntry);
            this.Controls.Add(this.ChairEntry);
            this.Controls.Add(this.PCsNumberEntry);
            this.Controls.Add(this.NameEntry);
            this.Name = "Salas";
            this.Text = "salas";
            this.RegisterRoomHeaderPanel.ResumeLayout(false);
            this.RegisterRoomHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.TextBox PCsNumberEntry;
        private System.Windows.Forms.TextBox ChairEntry;
        private System.Windows.Forms.TextBox BuildingEntry;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.CheckBox IsLabChk;
        private System.Windows.Forms.Label RegisterRoomHeaderLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel RegisterRoomHeaderPanel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label RegistersHeaderCadastroSalas;
        private System.Windows.Forms.Button SaveRegisterButton;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.DataGridView Table;
    }
}