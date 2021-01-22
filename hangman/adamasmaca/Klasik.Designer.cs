namespace adamasmaca
{
    partial class Klasik
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
            this.yenitusu = new System.Windows.Forms.Button();
            this.daragaci = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.geritusu = new System.Windows.Forms.Button();
            this.Klavye = new System.Windows.Forms.FlowLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.daragaci)).BeginInit();
            this.SuspendLayout();
            // 
            // yenitusu
            // 
            this.yenitusu.BackColor = System.Drawing.Color.Transparent;
            this.yenitusu.BackgroundImage = global::adamasmaca.Properties.Resources.yeni;
            this.yenitusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yenitusu.FlatAppearance.BorderSize = 0;
            this.yenitusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenitusu.ForeColor = System.Drawing.Color.Transparent;
            this.yenitusu.Location = new System.Drawing.Point(1206, -22);
            this.yenitusu.Name = "yenitusu";
            this.yenitusu.Size = new System.Drawing.Size(232, 228);
            this.yenitusu.TabIndex = 29;
            this.yenitusu.UseVisualStyleBackColor = false;
            this.yenitusu.Click += new System.EventHandler(this.yenioyun);
            this.yenitusu.MouseEnter += new System.EventHandler(this.yenitusu_MouseEnter);
            this.yenitusu.MouseLeave += new System.EventHandler(this.yenitusu_MouseLeave);
            // 
            // daragaci
            // 
            this.daragaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daragaci.BackColor = System.Drawing.Color.Transparent;
            this.daragaci.BackgroundImage = global::adamasmaca.Properties.Resources.st1;
            this.daragaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.daragaci.Location = new System.Drawing.Point(-35, 33);
            this.daragaci.Name = "daragaci";
            this.daragaci.Size = new System.Drawing.Size(470, 542);
            this.daragaci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.daragaci.TabIndex = 34;
            this.daragaci.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 189);
            this.label1.TabIndex = 35;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // geritusu
            // 
            this.geritusu.BackColor = System.Drawing.Color.Transparent;
            this.geritusu.BackgroundImage = global::adamasmaca.Properties.Resources.geri;
            this.geritusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geritusu.FlatAppearance.BorderSize = 0;
            this.geritusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geritusu.ForeColor = System.Drawing.Color.Transparent;
            this.geritusu.Location = new System.Drawing.Point(27, 12);
            this.geritusu.Name = "geritusu";
            this.geritusu.Size = new System.Drawing.Size(172, 164);
            this.geritusu.TabIndex = 36;
            this.geritusu.UseVisualStyleBackColor = false;
            this.geritusu.Click += new System.EventHandler(this.geritusu_Click);
            this.geritusu.MouseEnter += new System.EventHandler(this.geritusu_MouseEnter);
            this.geritusu.MouseLeave += new System.EventHandler(this.geritusu_MouseLeave);
            // 
            // Klavye
            // 
            this.Klavye.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Klavye.BackColor = System.Drawing.Color.Transparent;
            this.Klavye.Location = new System.Drawing.Point(217, 444);
            this.Klavye.Name = "Klavye";
            this.Klavye.Size = new System.Drawing.Size(924, 477);
            this.Klavye.TabIndex = 37;
            // 
            // Klasik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::adamasmaca.Properties.Resources.oyun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 989);
            this.Controls.Add(this.Klavye);
            this.Controls.Add(this.geritusu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenitusu);
            this.Controls.Add(this.daragaci);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Klasik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klasik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klasik_FormClosing);
            this.Load += new System.EventHandler(this.Klasik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daragaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox daragaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenitusu;
        private System.Windows.Forms.Button geritusu;
        private System.Windows.Forms.FlowLayoutPanel Klavye;
        private System.Windows.Forms.Timer timer;
    }
}