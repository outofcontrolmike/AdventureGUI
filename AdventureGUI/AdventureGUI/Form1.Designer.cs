namespace AdventureGUI
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.cmboBxRace = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmboBxClass = new System.Windows.Forms.ComboBox();
            this.lblAgeReq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(319, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Character Setup";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(291, 93);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(47, 20);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "Race\r\n";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(291, 163);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(17, 239);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.Location = new System.Drawing.Point(71, 92);
            this.txtbxName.MaxLength = 14;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(199, 26);
            this.txtbxName.TabIndex = 5;
            this.txtbxName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtbxAge
            // 
            this.txtbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAge.Location = new System.Drawing.Point(365, 157);
            this.txtbxAge.MaxLength = 3;
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(63, 26);
            this.txtbxAge.TabIndex = 6;
            this.txtbxAge.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(570, 92);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(356, 375);
            this.txtArea.TabIndex = 7;
            this.txtArea.Text = "This is an interaction TextArea.  Certain parts of the form will display here dep" +
    "ending on your set up.";
            // 
            // cmboBxRace
            // 
            this.cmboBxRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmboBxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxRace.FormattingEnabled = true;
            this.cmboBxRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Hobbit"});
            this.cmboBxRace.Location = new System.Drawing.Point(365, 93);
            this.cmboBxRace.Name = "cmboBxRace";
            this.cmboBxRace.Size = new System.Drawing.Size(143, 28);
            this.cmboBxRace.TabIndex = 8;
            this.cmboBxRace.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 179);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(71, 447);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 40);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(187, 447);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 40);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // cmboBxClass
            // 
            this.cmboBxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBxClass.FormattingEnabled = true;
            this.cmboBxClass.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Theif",
            "Cleric"});
            this.cmboBxClass.Location = new System.Drawing.Point(71, 236);
            this.cmboBxClass.Name = "cmboBxClass";
            this.cmboBxClass.Size = new System.Drawing.Size(199, 28);
            this.cmboBxClass.TabIndex = 10;
            this.cmboBxClass.SelectedIndexChanged += new System.EventHandler(this.CmboBxClass_SelectedIndexChanged);
            // 
            // lblAgeReq
            // 
            this.lblAgeReq.AutoSize = true;
            this.lblAgeReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeReq.Location = new System.Drawing.Point(67, 163);
            this.lblAgeReq.Name = "lblAgeReq";
            this.lblAgeReq.Size = new System.Drawing.Size(75, 20);
            this.lblAgeReq.TabIndex = 13;
            this.lblAgeReq.Text = "Age Limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.lblAgeReq);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmboBxClass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmboBxRace);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.ComboBox cmboBxRace;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmboBxClass;
        private System.Windows.Forms.Label lblAgeReq;
    }
}

