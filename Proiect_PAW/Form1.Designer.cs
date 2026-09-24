namespace Proiect_PAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIncepe = new System.Windows.Forms.Button();
            this.tbRegistru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIncepe
            // 
            this.buttonIncepe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonIncepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncepe.Location = new System.Drawing.Point(316, 386);
            this.buttonIncepe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIncepe.Name = "buttonIncepe";
            this.buttonIncepe.Size = new System.Drawing.Size(233, 96);
            this.buttonIncepe.TabIndex = 0;
            this.buttonIncepe.Text = "&Incepe!";
            this.buttonIncepe.UseVisualStyleBackColor = false;
            this.buttonIncepe.Click += new System.EventHandler(this.buttonIncepe_Click);
            // 
            // tbRegistru
            // 
            this.tbRegistru.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbRegistru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRegistru.Location = new System.Drawing.Point(316, 37);
            this.tbRegistru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRegistru.Name = "tbRegistru";
            this.tbRegistru.Size = new System.Drawing.Size(245, 39);
            this.tbRegistru.TabIndex = 1;
            this.tbRegistru.Text = "Registru magazine";
            this.tbRegistru.TextChanged += new System.EventHandler(this.tbRegistru_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.tbRegistru);
            this.Controls.Add(this.buttonIncepe);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncepe;
        private System.Windows.Forms.TextBox tbRegistru;
    }
}

