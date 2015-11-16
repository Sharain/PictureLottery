namespace PictureLottery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_Animals = new System.Windows.Forms.Button();
            this.Start_Colors = new System.Windows.Forms.Button();
            this.animals = new System.Windows.Forms.PictureBox();
            this.colors = new System.Windows.Forms.PictureBox();
            this.timer_animals = new System.Windows.Forms.Timer(this.components);
            this.timer_colors = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Animals
            // 
            this.Start_Animals.Location = new System.Drawing.Point(161, 436);
            this.Start_Animals.Name = "Start_Animals";
            this.Start_Animals.Size = new System.Drawing.Size(168, 55);
            this.Start_Animals.TabIndex = 0;
            this.Start_Animals.Text = "Start_Animals";
            this.Start_Animals.UseVisualStyleBackColor = true;
            this.Start_Animals.Click += new System.EventHandler(this.Start_Animals_Click);
            // 
            // Start_Colors
            // 
            this.Start_Colors.Location = new System.Drawing.Point(848, 436);
            this.Start_Colors.Name = "Start_Colors";
            this.Start_Colors.Size = new System.Drawing.Size(183, 55);
            this.Start_Colors.TabIndex = 1;
            this.Start_Colors.Text = "Start_Colors";
            this.Start_Colors.UseVisualStyleBackColor = true;
            this.Start_Colors.Click += new System.EventHandler(this.Start_Colors_Click);
            // 
            // animals
            // 
            this.animals.InitialImage = ((System.Drawing.Image)(resources.GetObject("animals.InitialImage")));
            this.animals.Location = new System.Drawing.Point(12, 12);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(514, 393);
            this.animals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animals.TabIndex = 2;
            this.animals.TabStop = false;
            this.animals.Click += new System.EventHandler(this.animals_Click);
            // 
            // colors
            // 
            this.colors.Location = new System.Drawing.Point(667, 12);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(514, 393);
            this.colors.TabIndex = 3;
            this.colors.TabStop = false;
            // 
            // timer_animals
            // 
            this.timer_animals.Interval = 500;
            this.timer_animals.Tick += new System.EventHandler(this.timer_animals_Tick);
            // 
            // timer_colors
            // 
            this.timer_colors.Interval = 500;
            this.timer_colors.Tick += new System.EventHandler(this.timer_colors_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1044, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Powerd by Sharain 2015";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1193, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.Start_Colors);
            this.Controls.Add(this.Start_Animals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureLottery";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Animals;
        private System.Windows.Forms.Button Start_Colors;
        private System.Windows.Forms.PictureBox animals;
        private System.Windows.Forms.PictureBox colors;
        private System.Windows.Forms.Timer timer_animals;
        private System.Windows.Forms.Timer timer_colors;
        private System.Windows.Forms.Label label1;
    }
}

