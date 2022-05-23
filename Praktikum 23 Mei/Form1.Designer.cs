namespace Praktikum_23_Mei
{
    partial class FormWeek13
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
            this.btnPrevv = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextt = new System.Windows.Forms.Button();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.tBoxPlayerId = new System.Windows.Forms.TextBox();
            this.tBoxPlayerName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.nupTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.cBoxNationality = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevv
            // 
            this.btnPrevv.Location = new System.Drawing.Point(77, 30);
            this.btnPrevv.Name = "btnPrevv";
            this.btnPrevv.Size = new System.Drawing.Size(75, 59);
            this.btnPrevv.TabIndex = 0;
            this.btnPrevv.Text = "<<";
            this.btnPrevv.UseVisualStyleBackColor = true;
            this.btnPrevv.Click += new System.EventHandler(this.btnPrevv_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(202, 30);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 59);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(327, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 59);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNextt
            // 
            this.btnNextt.Location = new System.Drawing.Point(448, 30);
            this.btnNextt.Name = "btnNextt";
            this.btnNextt.Size = new System.Drawing.Size(75, 59);
            this.btnNextt.TabIndex = 3;
            this.btnNextt.Text = ">>";
            this.btnNextt.UseVisualStyleBackColor = true;
            this.btnNextt.Click += new System.EventHandler(this.btnNextt_Click);
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerId.Location = new System.Drawing.Point(25, 146);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(78, 20);
            this.lblPlayerId.TabIndex = 4;
            this.lblPlayerId.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(25, 189);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(105, 20);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(25, 228);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(81, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "BirthDate";
            this.lblBirthDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(25, 269);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(87, 20);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(25, 310);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(51, 20);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNumber.Location = new System.Drawing.Point(25, 349);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(115, 20);
            this.lblTeamNumber.TabIndex = 9;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // tBoxPlayerId
            // 
            this.tBoxPlayerId.Location = new System.Drawing.Point(202, 143);
            this.tBoxPlayerId.Name = "tBoxPlayerId";
            this.tBoxPlayerId.Size = new System.Drawing.Size(167, 22);
            this.tBoxPlayerId.TabIndex = 10;
            // 
            // tBoxPlayerName
            // 
            this.tBoxPlayerName.Location = new System.Drawing.Point(202, 189);
            this.tBoxPlayerName.Name = "tBoxPlayerName";
            this.tBoxPlayerName.Size = new System.Drawing.Size(281, 22);
            this.tBoxPlayerName.TabIndex = 11;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dddd,  MMMM dd, yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(202, 228);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(266, 22);
            this.dtpBirthDate.TabIndex = 13;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(202, 310);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(215, 24);
            this.cBoxTeam.TabIndex = 14;
            // 
            // nupTeamNumber
            // 
            this.nupTeamNumber.Location = new System.Drawing.Point(202, 347);
            this.nupTeamNumber.Name = "nupTeamNumber";
            this.nupTeamNumber.Size = new System.Drawing.Size(127, 22);
            this.nupTeamNumber.TabIndex = 15;
            this.nupTeamNumber.ValueChanged += new System.EventHandler(this.nupTeamNumber_ValueChanged);
            // 
            // cBoxNationality
            // 
            this.cBoxNationality.FormattingEnabled = true;
            this.cBoxNationality.Location = new System.Drawing.Point(202, 269);
            this.cBoxNationality.Name = "cBoxNationality";
            this.cBoxNationality.Size = new System.Drawing.Size(215, 24);
            this.cBoxNationality.TabIndex = 16;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(357, 347);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(64, 16);
            this.lblAvailable.TabIndex = 17;
            this.lblAvailable.Text = "Available";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 35);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormWeek13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cBoxNationality);
            this.Controls.Add(this.nupTeamNumber);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tBoxPlayerName);
            this.Controls.Add(this.tBoxPlayerId);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerId);
            this.Controls.Add(this.btnNextt);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnPrevv);
            this.Name = "FormWeek13";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormWeek13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevv;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextt;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.TextBox tBoxPlayerId;
        private System.Windows.Forms.TextBox tBoxPlayerName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.NumericUpDown nupTeamNumber;
        private System.Windows.Forms.ComboBox cBoxNationality;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}

