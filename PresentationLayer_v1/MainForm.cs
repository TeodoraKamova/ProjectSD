using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer_v1
{
    public partial class MainForm : Form
    {
        private CRUDContext<Doctor, int> doctorContext;
        private CRUDContext<Patient, int> patientContext;
        private CRUDContext<Sickness, int> sicknessContext;

        public MainForm()
        {
            InitializeComponent();
            HospitalDBContext context = new HospitalDBContext();

            doctorContext = new CRUDContext<Doctor, int>(context.Doctors, context);
            patientContext = new CRUDContext<Patient, int>(context.Patients, context);
            sicknessContext = new CRUDContext<Sickness, int>(context.Sicknesses, context);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorsBtn_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm(doctorContext);
            doctorsForm.ShowDialog();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm(patientContext, doctorContext, sicknessContext);
            patientsForm.ShowDialog();
        }

        private void SicknessesBtn_Click(object sender, EventArgs e)
        {
            SicknessesForm sicknessesForm = new SicknessesForm(sicknessContext);
            sicknessesForm.ShowDialog();
        }
    }
}
