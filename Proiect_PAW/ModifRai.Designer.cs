namespace Proiect_PAW
{
    partial class ModifRai
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
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbSef = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelSefRaion = new System.Windows.Forms.Label();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(130, 38);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 14;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(130, 76);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 13;
            // 
            // tbSef
            // 
            this.tbSef.Location = new System.Drawing.Point(130, 117);
            this.tbSef.Name = "tbSef";
            this.tbSef.Size = new System.Drawing.Size(100, 20);
            this.tbSef.TabIndex = 12;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(53, 45);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(55, 13);
            this.labelCod.TabIndex = 11;
            this.labelCod.Text = "Cod raion:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(53, 83);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(55, 13);
            this.labelDenumire.TabIndex = 10;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelSefRaion
            // 
            this.labelSefRaion.AutoSize = true;
            this.labelSefRaion.Location = new System.Drawing.Point(56, 124);
            this.labelSefRaion.Name = "labelSefRaion";
            this.labelSefRaion.Size = new System.Drawing.Size(52, 13);
            this.labelSefRaion.TabIndex = 9;
            this.labelSefRaion.Text = "Sef raion:";
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(93, 160);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(75, 23);
            this.buttonModifica.TabIndex = 21;
            this.buttonModifica.Text = "Modifică";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // ModifRai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbSef);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelSefRaion);
            this.Name = "ModifRai";
            this.Text = "ModifRai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbSef;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelSefRaion;
        private System.Windows.Forms.Button buttonModifica;
    }
}