namespace adamasmaca
{
    partial class Cpu
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.giris = new System.Windows.Forms.Label();
            this.harftahta = new System.Windows.Forms.FlowLayoutPanel();
            this.tahmingoster = new System.Windows.Forms.Label();
            this.geritusu = new System.Windows.Forms.Button();
            this.yenitusu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::adamasmaca.Properties.Resources.girdim;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(300, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 118);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(401, 279);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // giris
            // 
            this.giris.AutoSize = true;
            this.giris.BackColor = System.Drawing.Color.Transparent;
            this.giris.Location = new System.Drawing.Point(181, 177);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(259, 25);
            this.giris.TabIndex = 2;
            this.giris.Text = "Kelimen kaç harfli acaba?";
            // 
            // harftahta
            // 
            this.harftahta.BackColor = System.Drawing.Color.Transparent;
            this.harftahta.Location = new System.Drawing.Point(66, 157);
            this.harftahta.Name = "harftahta";
            this.harftahta.Size = new System.Drawing.Size(746, 273);
            this.harftahta.TabIndex = 3;
            this.harftahta.Paint += new System.Windows.Forms.PaintEventHandler(this.harftahta_Paint);
            // 
            // tahmingoster
            // 
            this.tahmingoster.AutoSize = true;
            this.tahmingoster.BackColor = System.Drawing.Color.Transparent;
            this.tahmingoster.Location = new System.Drawing.Point(156, 460);
            this.tahmingoster.Name = "tahmingoster";
            this.tahmingoster.Size = new System.Drawing.Size(70, 25);
            this.tahmingoster.TabIndex = 4;
            this.tahmingoster.Text = "label1";
            // 
            // geritusu
            // 
            this.geritusu.BackColor = System.Drawing.Color.Transparent;
            this.geritusu.BackgroundImage = global::adamasmaca.Properties.Resources.geri;
            this.geritusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geritusu.FlatAppearance.BorderSize = 0;
            this.geritusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geritusu.ForeColor = System.Drawing.Color.Transparent;
            this.geritusu.Location = new System.Drawing.Point(2, 1);
            this.geritusu.Name = "geritusu";
            this.geritusu.Size = new System.Drawing.Size(147, 134);
            this.geritusu.TabIndex = 37;
            this.geritusu.UseVisualStyleBackColor = false;
            this.geritusu.Click += new System.EventHandler(this.geritusu_Click);
            // 
            // yenitusu
            // 
            this.yenitusu.BackColor = System.Drawing.Color.Transparent;
            this.yenitusu.BackgroundImage = global::adamasmaca.Properties.Resources.yeni;
            this.yenitusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yenitusu.FlatAppearance.BorderSize = 0;
            this.yenitusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenitusu.ForeColor = System.Drawing.Color.Transparent;
            this.yenitusu.Location = new System.Drawing.Point(667, -27);
            this.yenitusu.Name = "yenitusu";
            this.yenitusu.Size = new System.Drawing.Size(184, 185);
            this.yenitusu.TabIndex = 38;
            this.yenitusu.UseVisualStyleBackColor = false;
            this.yenitusu.Click += new System.EventHandler(this.yenitusu_Click);
            // 
            // Cpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::adamasmaca.Properties.Resources.oyun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.yenitusu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.geritusu);
            this.Controls.Add(this.tahmingoster);
            this.Controls.Add(this.harftahta);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Cpu";
            this.Text = "Cpu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cpu_FormClosing);
            this.Load += new System.EventHandler(this.Cpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label giris;
        private System.Windows.Forms.FlowLayoutPanel harftahta;
        private System.Windows.Forms.Label tahmingoster;
        private System.Windows.Forms.Button geritusu;
        private System.Windows.Forms.Button yenitusu;
    }
}