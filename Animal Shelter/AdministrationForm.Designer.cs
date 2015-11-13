namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAddAnimal = new System.Windows.Forms.GroupBox();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDateYear = new System.Windows.Forms.NumericUpDown();
            this.nudDateMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDateDay = new System.Windows.Forms.NumericUpDown();
            this.nudBirthYear = new System.Windows.Forms.NumericUpDown();
            this.nudBirthMonth = new System.Windows.Forms.NumericUpDown();
            this.nudBirthDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBadHabit = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbChange = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFoundAnimal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbReserved = new System.Windows.Forms.GroupBox();
            this.lbReserverd = new System.Windows.Forms.ListBox();
            this.gbNotReserved = new System.Windows.Forms.GroupBox();
            this.lbNotReserverd = new System.Windows.Forms.ListBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTestData = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.gbAddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthDay)).BeginInit();
            this.gbChange.SuspendLayout();
            this.gbReserved.SuspendLayout();
            this.gbNotReserved.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // gbAddAnimal
            // 
            this.gbAddAnimal.Controls.Add(this.rbCat);
            this.gbAddAnimal.Controls.Add(this.rbDog);
            this.gbAddAnimal.Controls.Add(this.label7);
            this.gbAddAnimal.Controls.Add(this.cbReserved);
            this.gbAddAnimal.Controls.Add(this.label5);
            this.gbAddAnimal.Controls.Add(this.label4);
            this.gbAddAnimal.Controls.Add(this.nudDateYear);
            this.gbAddAnimal.Controls.Add(this.nudDateMonth);
            this.gbAddAnimal.Controls.Add(this.nudDateDay);
            this.gbAddAnimal.Controls.Add(this.nudBirthYear);
            this.gbAddAnimal.Controls.Add(this.nudBirthMonth);
            this.gbAddAnimal.Controls.Add(this.nudBirthDay);
            this.gbAddAnimal.Controls.Add(this.label3);
            this.gbAddAnimal.Controls.Add(this.label2);
            this.gbAddAnimal.Controls.Add(this.label1);
            this.gbAddAnimal.Controls.Add(this.tbBadHabit);
            this.gbAddAnimal.Controls.Add(this.btnAdd);
            this.gbAddAnimal.Controls.Add(this.tbNumber);
            this.gbAddAnimal.Controls.Add(this.tbName);
            this.gbAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.gbAddAnimal.Name = "gbAddAnimal";
            this.gbAddAnimal.Size = new System.Drawing.Size(282, 266);
            this.gbAddAnimal.TabIndex = 3;
            this.gbAddAnimal.TabStop = false;
            this.gbAddAnimal.Text = "Dier toevoegen";
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(227, 22);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(41, 17);
            this.rbCat.TabIndex = 19;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Kat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(124, 22);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(51, 17);
            this.rbDog.TabIndex = 18;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Hond";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Diersoort:";
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.Location = new System.Drawing.Point(9, 233);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(90, 17);
            this.cbReserved.TabIndex = 16;
            this.cbReserved.Text = "Gereserveerd";
            this.cbReserved.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Slechte eigenschap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Uitgelaten:";
            // 
            // nudDateYear
            // 
            this.nudDateYear.Location = new System.Drawing.Point(211, 157);
            this.nudDateYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudDateYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudDateYear.Name = "nudDateYear";
            this.nudDateYear.Size = new System.Drawing.Size(57, 20);
            this.nudDateYear.TabIndex = 12;
            this.nudDateYear.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // nudDateMonth
            // 
            this.nudDateMonth.Location = new System.Drawing.Point(168, 157);
            this.nudDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDateMonth.Name = "nudDateMonth";
            this.nudDateMonth.Size = new System.Drawing.Size(37, 20);
            this.nudDateMonth.TabIndex = 11;
            this.nudDateMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDateDay
            // 
            this.nudDateDay.Location = new System.Drawing.Point(124, 157);
            this.nudDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDateDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDateDay.Name = "nudDateDay";
            this.nudDateDay.Size = new System.Drawing.Size(37, 20);
            this.nudDateDay.TabIndex = 10;
            this.nudDateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBirthYear
            // 
            this.nudBirthYear.Location = new System.Drawing.Point(211, 105);
            this.nudBirthYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudBirthYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudBirthYear.Name = "nudBirthYear";
            this.nudBirthYear.Size = new System.Drawing.Size(57, 20);
            this.nudBirthYear.TabIndex = 9;
            this.nudBirthYear.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // nudBirthMonth
            // 
            this.nudBirthMonth.Location = new System.Drawing.Point(168, 105);
            this.nudBirthMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBirthMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthMonth.Name = "nudBirthMonth";
            this.nudBirthMonth.Size = new System.Drawing.Size(37, 20);
            this.nudBirthMonth.TabIndex = 8;
            this.nudBirthMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBirthDay
            // 
            this.nudBirthDay.Location = new System.Drawing.Point(124, 105);
            this.nudBirthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudBirthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthDay.Name = "nudBirthDay";
            this.nudBirthDay.Size = new System.Drawing.Size(37, 20);
            this.nudBirthDay.TabIndex = 7;
            this.nudBirthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geboorte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam:";
            // 
            // tbBadHabit
            // 
            this.tbBadHabit.Location = new System.Drawing.Point(124, 183);
            this.tbBadHabit.Name = "tbBadHabit";
            this.tbBadHabit.Size = new System.Drawing.Size(144, 20);
            this.tbBadHabit.TabIndex = 2;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(124, 77);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(144, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 20);
            this.tbName.TabIndex = 0;
            // 
            // gbChange
            // 
            this.gbChange.Controls.Add(this.label6);
            this.gbChange.Controls.Add(this.lblFoundAnimal);
            this.gbChange.Controls.Add(this.btnDelete);
            this.gbChange.Controls.Add(this.btnSearch);
            this.gbChange.Controls.Add(this.tbDelete);
            this.gbChange.Controls.Add(this.tbSearch);
            this.gbChange.Location = new System.Drawing.Point(300, 12);
            this.gbChange.Name = "gbChange";
            this.gbChange.Size = new System.Drawing.Size(227, 97);
            this.gbChange.TabIndex = 4;
            this.gbChange.TabStop = false;
            this.gbChange.Text = "Zoeken of verwijderen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Resultaat:";
            // 
            // lblFoundAnimal
            // 
            this.lblFoundAnimal.AutoSize = true;
            this.lblFoundAnimal.Location = new System.Drawing.Point(67, 51);
            this.lblFoundAnimal.Name = "lblFoundAnimal";
            this.lblFoundAnimal.Size = new System.Drawing.Size(97, 13);
            this.lblFoundAnimal.TabIndex = 22;
            this.lblFoundAnimal.Text = "Geen dier gezocht!";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(144, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(144, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Zoek";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(6, 73);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(132, 20);
            this.tbDelete.TabIndex = 19;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(132, 20);
            this.tbSearch.TabIndex = 18;
            // 
            // gbReserved
            // 
            this.gbReserved.Controls.Add(this.lbReserverd);
            this.gbReserved.Location = new System.Drawing.Point(12, 299);
            this.gbReserved.Name = "gbReserved";
            this.gbReserved.Size = new System.Drawing.Size(653, 100);
            this.gbReserved.TabIndex = 5;
            this.gbReserved.TabStop = false;
            this.gbReserved.Text = "Gereserveerde dieren";
            // 
            // lbReserverd
            // 
            this.lbReserverd.FormattingEnabled = true;
            this.lbReserverd.Location = new System.Drawing.Point(6, 19);
            this.lbReserverd.Name = "lbReserverd";
            this.lbReserverd.Size = new System.Drawing.Size(641, 69);
            this.lbReserverd.TabIndex = 0;
            // 
            // gbNotReserved
            // 
            this.gbNotReserved.Controls.Add(this.lbNotReserverd);
            this.gbNotReserved.Location = new System.Drawing.Point(12, 405);
            this.gbNotReserved.Name = "gbNotReserved";
            this.gbNotReserved.Size = new System.Drawing.Size(653, 100);
            this.gbNotReserved.TabIndex = 6;
            this.gbNotReserved.TabStop = false;
            this.gbNotReserved.Text = "Niet-gereserveerde dieren";
            // 
            // lbNotReserverd
            // 
            this.lbNotReserverd.FormattingEnabled = true;
            this.lbNotReserverd.Location = new System.Drawing.Point(6, 19);
            this.lbNotReserverd.Name = "lbNotReserverd";
            this.lbNotReserverd.Size = new System.Drawing.Size(641, 69);
            this.lbNotReserverd.TabIndex = 1;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnLoad);
            this.gbData.Controls.Add(this.btnSave);
            this.gbData.Location = new System.Drawing.Point(300, 119);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(227, 56);
            this.gbData.TabIndex = 7;
            this.gbData.TabStop = false;
            this.gbData.Text = "Save local";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(144, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(590, 270);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(75, 23);
            this.btnTestData.TabIndex = 0;
            this.btnTestData.Text = "Testdata";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(300, 270);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteAll.TabIndex = 8;
            this.btnDeleteAll.Text = "Verwijder alle dieren";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 521);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnTestData);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbNotReserved);
            this.Controls.Add(this.gbReserved);
            this.Controls.Add(this.gbChange);
            this.Controls.Add(this.gbAddAnimal);
            this.Name = "AdministrationForm";
            this.Text = "Administratie Dierenasiel - Sven Nottelman";
            this.gbAddAnimal.ResumeLayout(false);
            this.gbAddAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDateDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthDay)).EndInit();
            this.gbChange.ResumeLayout(false);
            this.gbChange.PerformLayout();
            this.gbReserved.ResumeLayout(false);
            this.gbNotReserved.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAddAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBadHabit;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbReserved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDateYear;
        private System.Windows.Forms.NumericUpDown nudDateMonth;
        private System.Windows.Forms.NumericUpDown nudDateDay;
        private System.Windows.Forms.NumericUpDown nudBirthYear;
        private System.Windows.Forms.NumericUpDown nudBirthMonth;
        private System.Windows.Forms.NumericUpDown nudBirthDay;
        private System.Windows.Forms.GroupBox gbChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbReserved;
        private System.Windows.Forms.ListBox lbReserverd;
        private System.Windows.Forms.GroupBox gbNotReserved;
        private System.Windows.Forms.ListBox lbNotReserverd;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFoundAnimal;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTestData;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

