namespace Proiect_PAW
{
    partial class AdaugaDesfacere
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIncasariMin = new System.Windows.Forms.TextBox();
            this.tbIncasariMax = new System.Windows.Forms.TextBox();
            this.tbTva = new System.Windows.Forms.TextBox();
            this.tbLucratorCom = new System.Windows.Forms.TextBox();
            this.cbModalitate = new System.Windows.Forms.ComboBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonVeziDesf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalitate:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incasari minime:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incasari maxime:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TVA:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lucrator comercial:";
            //
            // tbIncasariMin
            //
            this.tbIncasariMin.Location = new System.Drawing.Point(227, 86);
            this.tbIncasariMin.Name = "tbIncasariMin";
            this.tbIncasariMin.Size = new System.Drawing.Size(100, 20);
            this.tbIncasariMin.TabIndex = 5;
            //
            // tbIncasariMax
            //
            this.tbIncasariMax.Location = new System.Drawing.Point(227, 117);
            this.tbIncasariMax.Name = "tbIncasariMax";
            this.tbIncasariMax.Size = new System.Drawing.Size(100, 20);
            this.tbIncasariMax.TabIndex = 6;
            //
            // tbTva
            //
            this.tbTva.Location = new System.Drawing.Point(227, 145);
            this.tbTva.Name = "tbTva";
            this.tbTva.Size = new System.Drawing.Size(100, 20);
            this.tbTva.TabIndex = 7;
            //
            // tbLucratorCom
            //
            this.tbLucratorCom.Location = new System.Drawing.Point(227, 172);
            this.tbLucratorCom.Name = "tbLucratorCom";
            this.tbLucratorCom.Size = new System.Drawing.Size(100, 20);
            this.tbLucratorCom.TabIndex = 8;
            //
            // cbModalitate
            //
            this.cbModalitate.FormattingEnabled = true;
            this.cbModalitate.Items.AddRange(new object[] {
            "Online",
            "Fizic"});
            this.cbModalitate.Location = new System.Drawing.Point(227, 53);
            this.cbModalitate.Name = "cbModalitate";
            this.cbModalitate.Size = new System.Drawing.Size(100, 21);
            this.cbModalitate.TabIndex = 9;
            //
            // buttonAdauga
            //
            this.buttonAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdauga.Location = new System.Drawing.Point(402, 213);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 11;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            //
            // buttonInapoi
            //
            this.buttonInapoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInapoi.Location = new System.Drawing.Point(402, 255);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(75, 23);
            this.buttonInapoi.TabIndex = 12;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            //
            // buttonVeziDesf
            //
            this.buttonVeziDesf.Location = new System.Drawing.Point(91, 239);
            this.buttonVeziDesf.Name = "buttonVeziDesf";
            this.buttonVeziDesf.Size = new System.Drawing.Size(200, 23);
            this.buttonVeziDesf.TabIndex = 13;
            this.buttonVeziDesf.Text = "Vezi informatii desfaceri introduse";
            this.buttonVeziDesf.UseVisualStyleBackColor = true;
            this.buttonVeziDesf.Click += new System.EventHandler(this.buttonVeziDesf_Click);
            //
            // AdaugaDesfacere
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 332);
            this.Controls.Add(this.buttonVeziDesf);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.cbModalitate);
            this.Controls.Add(this.tbLucratorCom);
            this.Controls.Add(this.tbTva);
            this.Controls.Add(this.tbIncasariMax);
            this.Controls.Add(this.tbIncasariMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaDesfacere";
            this.Text = "AdaugaDesfacere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIncasariMin;
        private System.Windows.Forms.TextBox tbIncasariMax;
        private System.Windows.Forms.TextBox tbTva;
        private System.Windows.Forms.TextBox tbLucratorCom;
        private System.Windows.Forms.ComboBox cbModalitate;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonVeziDesf;
    }
}