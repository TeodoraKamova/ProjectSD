using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace PresentationLayer_v1
{
    public partial class SicknessesForm : Form
    {
        private CRUDContext<Sickness, int> sicknessContext;
        private Sickness selectedSickness;

        public SicknessesForm(CRUDContext<Sickness, int> sicknessContext)
        {
            InitializeComponent();

            this.sicknessContext = sicknessContext;
            LoadSicknesses();

        }

        private void LoadSicknesses()
        {
            SicknessesDataGridView.DataSource = sicknessContext.ReadAll();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSickness != null)
                {
                    MessageBox.Show("You can't duplicate sicknesses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string symptoms = SymptomsTxtBox.Text;
                    int level = Convert.ToInt32(LevelNumUpDown.Value);

                    Sickness sickness = new Sickness(name, level, symptoms);

                    sicknessContext.Create(sickness);
                    MessageBox.Show("Sickness created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSicknesses();

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Name, symptoms and level are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            SymptomsTxtBox.Text = string.Empty;
            LevelNumUpDown.Value = LevelNumUpDown.Minimum;

            selectedSickness = null;
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && SymptomsTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() && selectedSickness != null)
                {
                    selectedSickness.Name = nameTxtBox.Text;
                    selectedSickness.Level = Convert.ToInt32(LevelNumUpDown.Value);
                    selectedSickness.Symptoms = SymptomsTxtBox.Text;

                    sicknessContext.Update(selectedSickness);

                    MessageBox.Show("Sickness updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSicknesses();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Name, level and symptoms are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DelteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSickness != null)
                {
                    sicknessContext.Delete(selectedSickness.Id);

                    LoadSicknesses();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select a sickness.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void SicknessesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = SicknessesDataGridView.Rows[e.RowIndex];

                    selectedSickness = row.DataBoundItem as Sickness;

                    nameTxtBox.Text = selectedSickness.Name;
                    LevelNumUpDown.Value = selectedSickness.Level;
                    SymptomsTxtBox.Text = selectedSickness.Symptoms;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
