namespace workshop_registration
{
    partial class FormBitSecondRegMain
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
            this.radioButtonHandleStress = new System.Windows.Forms.RadioButton();
            this.radioButtonTimeMgmt = new System.Windows.Forms.RadioButton();
            this.radioButtonSupSkills = new System.Windows.Forms.RadioButton();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelLodging = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxWorkshop = new System.Windows.Forms.GroupBox();
            this.groupBoxWorkshop.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonHandleStress
            // 
            this.radioButtonHandleStress.AutoSize = true;
            this.radioButtonHandleStress.Location = new System.Drawing.Point(6, 12);
            this.radioButtonHandleStress.Name = "radioButtonHandleStress";
            this.radioButtonHandleStress.Size = new System.Drawing.Size(99, 17);
            this.radioButtonHandleStress.TabIndex = 1;
            this.radioButtonHandleStress.TabStop = true;
            this.radioButtonHandleStress.Text = "Handling Stress";
            this.radioButtonHandleStress.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimeMgmt
            // 
            this.radioButtonTimeMgmt.AutoSize = true;
            this.radioButtonTimeMgmt.Location = new System.Drawing.Point(6, 35);
            this.radioButtonTimeMgmt.Name = "radioButtonTimeMgmt";
            this.radioButtonTimeMgmt.Size = new System.Drawing.Size(113, 17);
            this.radioButtonTimeMgmt.TabIndex = 2;
            this.radioButtonTimeMgmt.TabStop = true;
            this.radioButtonTimeMgmt.Text = "Time Management";
            this.radioButtonTimeMgmt.UseVisualStyleBackColor = true;
            // 
            // radioButtonSupSkills
            // 
            this.radioButtonSupSkills.AutoSize = true;
            this.radioButtonSupSkills.Location = new System.Drawing.Point(6, 58);
            this.radioButtonSupSkills.Name = "radioButtonSupSkills";
            this.radioButtonSupSkills.Size = new System.Drawing.Size(107, 17);
            this.radioButtonSupSkills.TabIndex = 3;
            this.radioButtonSupSkills.TabStop = true;
            this.radioButtonSupSkills.Text = "Supervision Skills";
            this.radioButtonSupSkills.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(348, 168);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(429, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(250, 54);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(120, 95);
            this.listBoxLocations.TabIndex = 6;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Location = new System.Drawing.Point(408, 54);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(96, 13);
            this.labelRegistration.TabIndex = 7;
            this.labelRegistration.Text = "Registration: $0.00";
            // 
            // labelLodging
            // 
            this.labelLodging.AutoSize = true;
            this.labelLodging.Location = new System.Drawing.Point(408, 77);
            this.labelLodging.Name = "labelLodging";
            this.labelLodging.Size = new System.Drawing.Size(78, 13);
            this.labelLodging.TabIndex = 8;
            this.labelLodging.Text = "Lodging: $0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(408, 100);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(64, 13);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total: $0.00";
            // 
            // groupBoxWorkshop
            // 
            this.groupBoxWorkshop.Controls.Add(this.radioButtonSupSkills);
            this.groupBoxWorkshop.Controls.Add(this.radioButtonHandleStress);
            this.groupBoxWorkshop.Controls.Add(this.radioButtonTimeMgmt);
            this.groupBoxWorkshop.Location = new System.Drawing.Point(11, 54);
            this.groupBoxWorkshop.Name = "groupBoxWorkshop";
            this.groupBoxWorkshop.Size = new System.Drawing.Size(200, 100);
            this.groupBoxWorkshop.TabIndex = 10;
            this.groupBoxWorkshop.TabStop = false;
            this.groupBoxWorkshop.Text = "Workshops";
            // 
            // FormBitSecondRegMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 233);
            this.Controls.Add(this.groupBoxWorkshop);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelLodging);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "FormBitSecondRegMain";
            this.Text = "Bit Second Workshop Registration";
            this.Load += new System.EventHandler(this.FormBitSecondRegMain_Load);
            this.groupBoxWorkshop.ResumeLayout(false);
            this.groupBoxWorkshop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonHandleStress;
        private System.Windows.Forms.RadioButton radioButtonTimeMgmt;
        private System.Windows.Forms.RadioButton radioButtonSupSkills;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelLodging;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBoxWorkshop;
    }
}

