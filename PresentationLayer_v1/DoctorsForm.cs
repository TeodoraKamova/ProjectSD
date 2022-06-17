using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer_v1
{
    public partial class DoctorsForm : Form
    {
        private CRUDContext<Doctor, int> doctorsContext;
        private Doctor selectedDoctor;

        public DoctorsForm(CRUDContext<Doctor, int> doctorsContext)
        {
            InitializeComponent();

            this.doctorsContext = doctorsContext;
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            doctorsDataGridView.DataSource = doctorsContext.ReadAll();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedDoctor != null)
                {
                    MessageBox.Show("You can't duplicate doctors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string surname = surnameTxtBox.Text;
                    int age = Convert.ToInt32(ageNumUpDown.Value);
                    int exp = Convert.ToInt32(expNumUpDown.Value);

                    Doctor doctor = new Doctor(name, surname, age, exp);

                    doctorsContext.Create(doctor);
                    MessageBox.Show("Doctor created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDoctors();

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and experience are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            surnameTxtBox.Text = string.Empty;
            ageNumUpDown.Value = ageNumUpDown.Minimum;
            expNumUpDown.Value = expNumUpDown.Minimum;

            selectedDoctor = null;
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && surnameTxtBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() && selectedDoctor != null)
                {
                    selectedDoctor.Name = nameTxtBox.Text;
                    selectedDoctor.Surname = surnameTxtBox.Text;
                    selectedDoctor.Age = Convert.ToInt32(ageNumUpDown.Value);
                    selectedDoctor.Experiennce = Convert.ToInt32(expNumUpDown.Value);

                    doctorsContext.Update(selectedDoctor);

                    MessageBox.Show("Doctor updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDoctors();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and experience are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedDoctor != null)
                {
                    doctorsContext.Delete(selectedDoctor.Id);

                    LoadDoctors();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = doctorsDataGridView.Rows[e.RowIndex];

                    selectedDoctor = row.DataBoundItem as Doctor;

                    nameTxtBox.Text = selectedDoctor.Name;
                    surnameTxtBox.Text = selectedDoctor.Surname;
                    ageNumUpDown.Value = selectedDoctor.Age;
                    expNumUpDown.Value = selectedDoctor.Experiennce;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
