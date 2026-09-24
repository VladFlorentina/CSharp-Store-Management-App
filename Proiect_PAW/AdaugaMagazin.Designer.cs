namespace Proiect_PAW
{
    partial class AdaugaMagazin
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
            this.components = new System.ComponentModel.Container();
            this.buttonVeziMagazin = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.cbParcare = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.labelNrang = new System.Windows.Forms.Label();
            this.labelParcare = new System.Windows.Forms.Label();
            this.tbNrAng = new System.Windows.Forms.TextBox();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVeziMagazin
            // 
            this.buttonVeziMagazin.Location = new System.Drawing.Point(73, 281);
            this.buttonVeziMagazin.Name = "buttonVeziMagazin";
            this.buttonVeziMagazin.Size = new System.Drawing.Size(141, 23);
            this.buttonVeziMagazin.TabIndex = 0;
            this.buttonVeziMagazin.Text = "Vezi magazine introduse";
            this.buttonVeziMagazin.UseVisualStyleBackColor = true;
            this.buttonVeziMagazin.Click += new System.EventHandler(this.buttonVeziMagazin_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(446, 281);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(75, 23);
            this.buttonInapoi.TabIndex = 1;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // cbParcare
            // 
            this.cbParcare.FormattingEnabled = true;
            this.cbParcare.Items.AddRange(new object[] {
            "Da",
            "Nu"});
            this.cbParcare.Location = new System.Drawing.Point(219, 220);
            this.cbParcare.Name = "cbParcare";
            this.cbParcare.Size = new System.Drawing.Size(104, 21);
            this.cbParcare.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(165, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(140, 85);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(55, 13);
            this.labelDenumire.TabIndex = 9;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(150, 120);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(45, 13);
            this.labelLocatie.TabIndex = 10;
            this.labelLocatie.Text = "Locatie:";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Location = new System.Drawing.Point(148, 157);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(49, 13);
            this.labelProgram.TabIndex = 11;
            this.labelProgram.Text = "Program:";
            // 
            // labelNrang
            // 
            this.labelNrang.AutoSize = true;
            this.labelNrang.Location = new System.Drawing.Point(116, 194);
            this.labelNrang.Name = "labelNrang";
            this.labelNrang.Size = new System.Drawing.Size(81, 13);
            this.labelNrang.TabIndex = 12;
            this.labelNrang.Text = "Numar angajati:";
            // 
            // labelParcare
            // 
            this.labelParcare.AutoSize = true;
            this.labelParcare.Location = new System.Drawing.Point(150, 228);
            this.labelParcare.Name = "labelParcare";
            this.labelParcare.Size = new System.Drawing.Size(47, 13);
            this.labelParcare.TabIndex = 13;
            this.labelParcare.Text = "Parcare:";
            // 
            // tbNrAng
            // 
            this.tbNrAng.Location = new System.Drawing.Point(219, 187);
            this.tbNrAng.Name = "tbNrAng";
            this.tbNrAng.Size = new System.Drawing.Size(100, 20);
            this.tbNrAng.TabIndex = 14;
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(219, 150);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(100, 20);
            this.tbProgram.TabIndex = 15;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(219, 113);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(100, 20);
            this.tbLocatie.TabIndex = 16;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(219, 78);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(219, 39);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 18;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(446, 239);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 19;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdaugaMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 353);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.tbNrAng);
            this.Controls.Add(this.labelParcare);
            this.Controls.Add(this.labelNrang);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.cbParcare);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonVeziMagazin);
            this.Name = "AdaugaMagazin";
            this.Text = "AdaugaMagazin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVeziMagazin;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.ComboBox cbParcare;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Label labelNrang;
        private System.Windows.Forms.Label labelParcare;
        private System.Windows.Forms.TextBox tbNrAng;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}