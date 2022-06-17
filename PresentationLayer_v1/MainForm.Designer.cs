
namespace PresentationLayer_v1
{
    partial class MainForm
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
            this.DoctorsBtn = new System.Windows.Forms.Button();
            this.PatientsBtn = new System.Windows.Forms.Button();
            this.SicknessesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorsBtn
            // 
            this.DoctorsBtn.Location = new System.Drawing.Point(341, 107);
            this.DoctorsBtn.Name = "DoctorsBtn";
            this.DoctorsBtn.Size = new System.Drawing.Size(94, 29);
            this.DoctorsBtn.TabIndex = 0;
            this.DoctorsBtn.Text = "Doctors";
            this.DoctorsBtn.UseVisualStyleBackColor = true;
            this.DoctorsBtn.Click += new System.EventHandler(this.DoctorsBtn_Click);
            // 
            // PatientsBtn
            // 
            this.PatientsBtn.Location = new System.Drawing.Point(341, 185);
            this.PatientsBtn.Name = "PatientsBtn";
            this.PatientsBtn.Size = new System.Drawing.Size(94, 29);
            this.PatientsBtn.TabIndex = 1;
            this.PatientsBtn.Text = "Patients";
            this.PatientsBtn.UseVisualStyleBackColor = true;
            this.PatientsBtn.Click += new System.EventHandler(this.PatientsBtn_Click);
            // 
            // SicknessesBtn
            // 
            this.SicknessesBtn.Location = new System.Drawing.Point(341, 270);
            this.SicknessesBtn.Name = "SicknessesBtn";
            this.SicknessesBtn.Size = new System.Drawing.Size(94, 29);
            this.SicknessesBtn.TabIndex = 2;
            this.SicknessesBtn.Text = "Sicknesses";
            this.SicknessesBtn.UseVisualStyleBackColor = true;
            this.SicknessesBtn.Click += new System.EventHandler(this.SicknessesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(640, 368);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SicknessesBtn);
            this.Controls.Add(this.PatientsBtn);
            this.Controls.Add(this.DoctorsBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoctorsBtn;
        private System.Windows.Forms.Button PatientsBtn;
        private System.Windows.Forms.Button SicknessesBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}