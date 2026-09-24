namespace Proiect_PAW
{
    partial class AdaugaRaion
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
            this.buttonVeziRaion = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.labelSefRaion = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.tbSef = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonVeziRaion
            // 
            this.buttonVeziRaion.Location = new System.Drawing.Point(120, 346);
            this.buttonVeziRaion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVeziRaion.Name = "buttonVeziRaion";
            this.buttonVeziRaion.Size = new System.Drawing.Size(210, 35);
            this.buttonVeziRaion.TabIndex = 0;
            this.buttonVeziRaion.Text = "Vezi raioane adaugate";
            this.buttonVeziRaion.UseVisualStyleBackColor = true;
            this.buttonVeziRaion.Click += new System.EventHandler(this.buttonVeziRaion_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(566, 374);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(112, 35);
            this.buttonInapoi.TabIndex = 1;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(566, 303);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(112, 35);
            this.buttonAdauga.TabIndex = 2;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // labelSefRaion
            // 
            this.labelSefRaion.AutoSize = true;
            this.labelSefRaion.Location = new System.Drawing.Point(150, 218);
            this.labelSefRaion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSefRaion.Name = "labelSefRaion";
            this.labelSefRaion.Size = new System.Drawing.Size(77, 20);
            this.labelSefRaion.TabIndex = 3;
            this.labelSefRaion.Text = "Sef raion:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(146, 155);
            this.labelDenumire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(82, 20);
            this.labelDenumire.TabIndex = 4;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(146, 97);
            this.labelCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(81, 20);
            this.labelCod.TabIndex = 5;
            this.labelCod.Text = "Cod raion:";
            // 
            // tbSef
            // 
            this.tbSef.Location = new System.Drawing.Point(261, 208);
            this.tbSef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSef.Name = "tbSef";
            this.tbSef.Size = new System.Drawing.Size(148, 26);
            this.tbSef.TabIndex = 6;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(261, 145);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(148, 26);
            this.tbDenumire.TabIndex = 7;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(261, 86);
            this.tbCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(148, 26);
            this.tbCod.TabIndex = 8;
            // 
            // AdaugaRaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 491);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbSef);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelSefRaion);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonVeziRaion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdaugaRaion";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVeziRaion;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label labelSefRaion;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox tbSef;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbCod;
    }
}