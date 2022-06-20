<<<<<<< HEAD
﻿using System;
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
    public partial class PatientsForm : Form
    {
        private Patient selectedPatient;
        private CRUDContext<Patient, int> patientsContext;

        public PatientsForm(CRUDContext<Patient, int> patientsContext)
        {
            InitializeComponent();
            
            this.patientsContext = patientsContext;
            bloodTypesComboBox.DataSource = Enum.GetValues(typeof(BloodTypes));

            LoadPatients();
        }

        private void LoadPatients()
        {
            patientsDataGridView.DataSource = patientsContext.ReadAll();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPatient != null)
                {
                    MessageBox.Show("You can't duplicate patients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string surname = surnameTxtBox.Text;
                    int age = Convert.ToInt32(ageNumUpDown.Value);
                    BloodTypes bloodtype = (BloodTypes)bloodTypesComboBox.SelectedItem;

                    //dobavih null za da testvam dali raboti testvaneto 
                    Patient patient = new Patient(name, surname, age, bloodtype,null);

                    patientsContext.Create(patient);
                    MessageBox.Show("Patient created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatients();

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and blood type are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bloodTypesComboBox.ResetText();
            selectedPatient = null;
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
                if (ValidateData() && selectedPatient != null)
                {
                    selectedPatient.Name = nameTxtBox.Text;
                    selectedPatient.Surname = surnameTxtBox.Text;
                    selectedPatient.Age = Convert.ToInt32(ageNumUpDown.Value);
                    selectedPatient.BloodType = (BloodTypes)bloodTypesComboBox.SelectedItem;

                    patientsContext.Update(selectedPatient);

                    MessageBox.Show("Patient updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatients();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and blood type are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedPatient != null)
                {
                    patientsContext.Delete(selectedPatient.Id);

                    LoadPatients();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select a patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = patientsDataGridView.Rows[e.RowIndex];

                    selectedPatient = row.DataBoundItem as Patient;

                    nameTxtBox.Text = selectedPatient.Name;
                    surnameTxtBox.Text = selectedPatient.Surname;
                    ageNumUpDown.Value = selectedPatient.Age;
                    bloodTypesComboBox.SelectedItem = selectedPatient.BloodType;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
=======
﻿using System;
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
    public partial class PatientsForm : Form
    {
        private Patient selectedPatient;
        private CRUDContext<Patient, int> patientsContext;

        public PatientsForm(CRUDContext<Patient, int> patientsContext)
        {
            InitializeComponent();
            
            this.patientsContext = patientsContext;
            bloodTypesComboBox.DataSource = Enum.GetValues(typeof(BloodTypes));

            LoadPatients();
        }

        private void LoadPatients()
        {
            patientsDataGridView.DataSource = patientsContext.ReadAll();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPatient != null)
                {
                    MessageBox.Show("You can't duplicate patients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string surname = surnameTxtBox.Text;
                    int age = Convert.ToInt32(ageNumUpDown.Value);
                    BloodTypes bloodtype = (BloodTypes)bloodTypesComboBox.SelectedItem;

                    Patient patient = new Patient(name, surname, age, bloodtype);

                    patientsContext.Create(patient);
                    MessageBox.Show("Patient created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatients();

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and blood type are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bloodTypesComboBox.ResetText();
            selectedPatient = null;
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
                if (ValidateData() && selectedPatient != null)
                {
                    selectedPatient.Name = nameTxtBox.Text;
                    selectedPatient.Surname = surnameTxtBox.Text;
                    selectedPatient.Age = Convert.ToInt32(ageNumUpDown.Value);
                    selectedPatient.BloodType = (BloodTypes)bloodTypesComboBox.SelectedItem;

                    patientsContext.Update(selectedPatient);

                    MessageBox.Show("Patient updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatients();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Name, surname, age and blood type are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedPatient != null)
                {
                    patientsContext.Delete(selectedPatient.Id);

                    LoadPatients();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select a patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = patientsDataGridView.Rows[e.RowIndex];

                    selectedPatient = row.DataBoundItem as Patient;

                    nameTxtBox.Text = selectedPatient.Name;
                    surnameTxtBox.Text = selectedPatient.Surname;
                    ageNumUpDown.Value = selectedPatient.Age;
                    bloodTypesComboBox.SelectedItem = selectedPatient.BloodType;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
>>>>>>> 27c455cba0b6453d12f993f6b90e7ce0eb83dea1
