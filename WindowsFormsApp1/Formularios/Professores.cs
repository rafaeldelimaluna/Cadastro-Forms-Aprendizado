﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model.Entitidades;
using WindowsFormsApp1.DAO;


namespace WindowsFormsApp1
{
    public partial class Professores : Form
    {
        DataTable data;
        private ProfessorDAO conn;
        int LinhaSelecionada;

        public Professores()
        {
            InitializeComponent();
            conn = new ProfessorDAO();
            DtGridProfessores.DataSource = conn.Get();
        }
        string NomePlaceholder="Nome ";
        string ApelidoPlaceholder = "Apelido";
        private void Placeholder(TextBox textBox, String placeholder_value)
        {
            String textBox_text = textBox.Text;

            if (textBox_text == placeholder_value)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox_text == "")
            {
                textBox.Text = placeholder_value;
                textBox.ForeColor = Color.Gray;
            }
        }
        private void ClearFields()
        {
            NomeEbx.Text = NomePlaceholder;
            NomeEbx.ForeColor = Color.Gray;
            ApelidoTbxx.Text = ApelidoPlaceholder;
            ApelidoTbxx.ForeColor = Color.Gray;
        }
        private bool DataIsCorrectly()
        {
            if (NomeEbx.Text == NomePlaceholder || NomeEbx.Text == "")
            {
                MessageBox.Show("Preencha o campo corretamente");
                return false;
            }

            if (ApelidoTbxx.Text == ApelidoPlaceholder || ApelidoTbxx.Text == "") {
                MessageBox.Show("Preencha o campo apelido corretamente");
                return false;
            }
            return true;
        }
        private ProfessoresEntidade Cadastro{
            get{
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Nome = NomeEbx.Text;
            professor.Apelido = ApelidoTbxx.Text;
            return professor;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!DataIsCorrectly()) {
                MessageBox.Show("Dados não preenchidos");
                return;
            }
            ProfessoresEntidade professor = Cadastro;
            conn.Inserir(professor);
            DtGridProfessores.DataSource = conn.Get();
            ClearFields();

        }
        private void SetFields(ProfessoresEntidade professor)
        {
            NomeEbx.Text = professor.Nome;
            ApelidoTbxx.Text = professor.Apelido;
        }
        private void NomeEbx_Enter(object sender, EventArgs e)
        {
            Placeholder(NomeEbx, NomePlaceholder);
        }

        private void ApelidoTbx(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);
        }

        private void ApelidoTbx_Enter(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);

        }

        private void NomeEb_Leave(object sender, EventArgs e)
        {
            Placeholder(NomeEbx, NomePlaceholder);

        }

        private void ApelidoTbxx_Leave(object sender, EventArgs e)
        {
            Placeholder(ApelidoTbxx, ApelidoPlaceholder);
        }

        private void ApelidoTbxx_Enter(object sender, EventArgs e)
        {
            Placeholder(ApelidoTbxx, ApelidoPlaceholder);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            DtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = DtGridProfessores.Rows[LinhaSelecionada].Cells;
            cells[1].Value=NomeEbx.Text;
            cells[2].Value = ApelidoTbxx.Text;
            return;
        }

        private void DtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DeleteRowBtn.Text = $"Deletar linha {LinhaSelecionada + 1}";
            EditBtn.Text = $"Editar linha {LinhaSelecionada + 1}";
            DataGridViewCellCollection cells = DtGridProfessores.Rows[LinhaSelecionada].Cells;
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(cells[0].Value);
            professor.Nome=cells[1].Value.ToString();
            professor.Apelido=cells[2].Value.ToString();
            SetFields(professor);
        }
    }
}
