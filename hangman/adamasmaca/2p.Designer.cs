namespace adamasmaca
{
    partial class _2p
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
            this.txtkel = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.geritusu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtkel
            // 
            this.txtkel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtkel.Location = new System.Drawing.Point(364, 318);
            this.txtkel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkel.Name = "txtkel";
            this.txtkel.Size = new System.Drawing.Size(232, 31);
            this.txtkel.TabIndex = 0;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Transparent;
            this.giris.BackgroundImage = global::adamasmaca.Properties.Resources.girdim;
            this.giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giris.FlatAppearance.BorderSize = 0;
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Location = new System.Drawing.Point(364, 513);
            this.giris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(272, 103);
            this.giris.TabIndex = 1;
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(364, 406);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // geritusu
            // 
            this.geritusu.BackColor = System.Drawing.Color.Transparent;
            this.geritusu.BackgroundImage = global::adamasmaca.Properties.Resources.geri;
            this.geritusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geritusu.FlatAppearance.BorderSize = 0;
            this.geritusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geritusu.ForeColor = System.Drawing.Color.Transparent;
            this.geritusu.Location = new System.Drawing.Point(12, -3);
            this.geritusu.Name = "geritusu";
            this.geritusu.Size = new System.Drawing.Size(145, 143);
            this.geritusu.TabIndex = 37;
            this.geritusu.UseVisualStyleBackColor = false;
            this.geritusu.Click += new System.EventHandler(this.geritusu_Click);
            // 
            // _2p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::adamasmaca.Properties.Resources.oyun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 691);
            this.Controls.Add(this.geritusu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.txtkel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "_2p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_2p";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._2p_FormClosing);
            this.Load += new System.EventHandler(this._2p_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkel;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button geritusu;
    }
}