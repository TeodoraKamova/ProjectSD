
namespace PresentationLayer_v1
{
    partial class SicknessesForm
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
            this.DelteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SymptomsTxtBox = new System.Windows.Forms.TextBox();
            this.SicknessesDataGridView = new System.Windows.Forms.DataGridView();
            this.LevelNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SicknessesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DelteBtn
            // 
            this.DelteBtn.Location = new System.Drawing.Point(280, 392);
            this.DelteBtn.Name = "DelteBtn";
            this.DelteBtn.Size = new System.Drawing.Size(94, 29);
            this.DelteBtn.TabIndex = 1;
            this.DelteBtn.Text = "Delete";
            this.DelteBtn.UseVisualStyleBackColor = true;
            this.DelteBtn.Click += new System.EventHandler(this.DelteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(150, 392);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(683, 392);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(15, 392);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(94, 29);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(128, 79);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.nameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Symptoms";
            // 
            // SymptomsTxtBox
            // 
            this.SymptomsTxtBox.Location = new System.Drawing.Point(128, 203);
            this.SymptomsTxtBox.Name = "SymptomsTxtBox";
            this.SymptomsTxtBox.Size = new System.Drawing.Size(125, 27);
            this.SymptomsTxtBox.TabIndex = 9;
            // 
            // SicknessesDataGridView
            // 
            this.SicknessesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SicknessesDataGridView.Location = new System.Drawing.Point(373, 79);
            this.SicknessesDataGridView.Name = "SicknessesDataGridView";
            this.SicknessesDataGridView.RowHeadersWidth = 51;
            this.SicknessesDataGridView.RowTemplate.Height = 29;
            this.SicknessesDataGridView.Size = new System.Drawing.Size(404, 240);
            this.SicknessesDataGridView.TabIndex = 11;
            this.SicknessesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SicknessesDataGridView_CellContentClick);
            // 
            // LevelNumUpDown
            // 
            this.LevelNumUpDown.Location = new System.Drawing.Point(128, 140);
            this.LevelNumUpDown.Name = "LevelNumUpDown";
            this.LevelNumUpDown.Size = new System.Drawing.Size(125, 27);
            this.LevelNumUpDown.TabIndex = 12;
            // 
            // SicknessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LevelNumUpDown);
            this.Controls.Add(this.SicknessesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SymptomsTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DelteBtn);
            this.Name = "SicknessesForm";
            this.Text = "SicknessesForm";
            ((System.ComponentModel.ISupportInitialize)(this.SicknessesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DelteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SymptomsTxtBox;
        private System.Windows.Forms.DataGridView SicknessesDataGridView;
        private System.Windows.Forms.NumericUpDown LevelNumUpDown;
    }
}