namespace Proiect_PAW
{
    partial class Meniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.buttonMagazine = new System.Windows.Forms.Button();
            this.buttonRaioane = new System.Windows.Forms.Button();
            this.buttonDesfaceri = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.btnGrafice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMagazine
            // 
            this.buttonMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMagazine.ForeColor = System.Drawing.Color.Black;
            this.buttonMagazine.Location = new System.Drawing.Point(703, 14);
            this.buttonMagazine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMagazine.Name = "buttonMagazine";
            this.buttonMagazine.Size = new System.Drawing.Size(155, 46);
            this.buttonMagazine.TabIndex = 0;
            this.buttonMagazine.Text = "&Magazine";
            this.buttonMagazine.UseVisualStyleBackColor = false;
            this.buttonMagazine.Click += new System.EventHandler(this.buttonMagazine_Click);
            // 
            // buttonRaioane
            // 
            this.buttonRaioane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRaioane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRaioane.Location = new System.Drawing.Point(703, 58);
            this.buttonRaioane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRaioane.Name = "buttonRaioane";
            this.buttonRaioane.Size = new System.Drawing.Size(155, 46);
            this.buttonRaioane.TabIndex = 1;
            this.buttonRaioane.Text = "&Raioane";
            this.buttonRaioane.UseVisualStyleBackColor = false;
            this.buttonRaioane.Click += new System.EventHandler(this.buttonRaioane_Click);
            // 
            // buttonDesfaceri
            // 
            this.buttonDesfaceri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDesfaceri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDesfaceri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDesfaceri.Location = new System.Drawing.Point(703, 104);
            this.buttonDesfaceri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDesfaceri.Name = "buttonDesfaceri";
            this.buttonDesfaceri.Size = new System.Drawing.Size(155, 49);
            this.buttonDesfaceri.TabIndex = 2;
            this.buttonDesfaceri.Text = "&Desfaceri";
            this.buttonDesfaceri.UseVisualStyleBackColor = false;
            this.buttonDesfaceri.Click += new System.EventHandler(this.buttonDesfaceri_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInapoi.Location = new System.Drawing.Point(639, 291);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(130, 47);
            this.buttonInapoi.TabIndex = 3;
            this.buttonInapoi.Text = "&Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // btnGrafice
            // 
            this.btnGrafice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGrafice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrafice.Location = new System.Drawing.Point(703, 161);
            this.btnGrafice.Name = "btnGrafice";
            this.btnGrafice.Size = new System.Drawing.Size(155, 47);
            this.btnGrafice.TabIndex = 4;
            this.btnGrafice.Text = "Grafic";
            this.btnGrafice.UseVisualStyleBackColor = false;
            this.btnGrafice.Click += new System.EventHandler(this.btnGrafice_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.btnGrafice);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonDesfaceri);
            this.Controls.Add(this.buttonRaioane);
            this.Controls.Add(this.buttonMagazine);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMagazine;
        private System.Windows.Forms.Button buttonRaioane;
        private System.Windows.Forms.Button buttonDesfaceri;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button btnGrafice;
    }
}