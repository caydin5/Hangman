using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adamasmaca
{
    public partial class Cpu : Form
    {
        public int ks;
        string kt;
        Point konum = new Point(1, 0); // butonun ilk konumu
        PrivateFontCollection architect = new PrivateFontCollection();
        bool durum = false;
        char[] harf = { 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'Ğ', 'Ü', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Ş', 'İ', 'Z', 'C', 'V', 'B', 'N', 'M', 'Ö', 'Ç' };
        char[] secilen = new char[29];
        Label[] labels;
        int hak;
        SoundPlayer geri = new SoundPlayer(adamasmaca.Properties.Resources.gerises);


        public Cpu()
        {
            InitializeComponent();
            tahmingoster.Visible = false;
        }


            private void button1_Click(object sender, EventArgs e)
        {
            yenitusu.Visible = true;
            button1.BackgroundImage = adamasmaca.Properties.Resources.yeniharf;
            if (durum == false)
            {
                ks = Convert.ToInt32(numericUpDown1.Value);
                labels = new Label[ks];

                giris.Visible = false;
                numericUpDown1.Enabled = false;
                numericUpDown1.Visible = false;
                tahmingoster.Visible = true;

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    labels[i] = new Label();
                    labels[i].Text = "_";

                    labels[i].Location = konum;
                    konum.Offset(labels[i].Height + 1, 0);
                    harftahta.Controls.Add(labels[i]);
                    labels[i].Click += harfsec_Click;
                    labels[i].FlatStyle = FlatStyle.Flat;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = new Font(architect.Families[0], 16);



                }

                tahmin();
                durum = true;
            }
            else
                tahmin();
        }

        private void Cpu_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 2;
            numericUpDown1.Maximum = 7;
            gorunum();
            yenitusu.Visible = false;

        }

        private void harfsec_Click(object sender, EventArgs e)
        {
            Label degistir = (Label)sender;
            degistir.Text = kt;
            int say = 0;
            for (int i=0; i<labels.Length;i++)
            {
                if (labels[i].Text != "_")
                    say++;
            
            }
            if (say == ks)
                MessageBox.Show("Kazandım haha");
            hak--;
        }

        private void harftahta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tahmin ()
        {
            if (hak <= 10)
            {
                int rastgelesayi = (new Random()).Next(0, 29);
                if (secilen.Contains(harf[rastgelesayi]) == false)
                {
                    kt = harf[rastgelesayi].ToString();
                    tahmingoster.Text = kt;
                    secilen[rastgelesayi] = harf[rastgelesayi];
                    hak++;
                }
                else
                {
                    if (harf == secilen)
                        MessageBox.Show("Bütün harfler denendi");

                    else
                        tahmin();
                }
            }
            else
                MessageBox.Show("Tamam sen kazandın");
        }

        private void Cpu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Olmadı şimdi. Bu kadar çabuk mu pes ediyorsun?", "Adamı Asamadan Çık", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes) //Evet seçeneği seçildiğinde yapılacaklar
                Application.ExitThread(); //Uygulamadan çık
            else if (uyari == DialogResult.No) //Hayır seçeneği seçildiğinde yapılacaklar
                e.Cancel = true; //Mesaj kutusunu kapat
        }

        private void geritusu_Click(object sender, EventArgs e)
        {
            geri.Play();
            this.Hide();
            Menu menu = new Menu(); //Oyun ekranını tanımlar
            menu.ShowDialog();
            this.Close();
        }

        private void yenitusu_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void gorunum()
        {
            architect.AddFontFile(@"C:\Users\Cem\Desktop\armut\AA_Beta\adamasmaca\adamasmaca\Resources\Buteco.otf");
            numericUpDown1.Font = new Font(architect.Families[0], 18);
            giris.Font = new Font(architect.Families[0], 22);
            tahmingoster.Font = new Font(architect.Families[0], 22);

            yenitusu.MouseEnter += new EventHandler(yenitusu_MouseEnter);
            yenitusu.MouseLeave += new EventHandler(yenitusu_MouseLeave);
            yenitusu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            yenitusu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            geritusu.MouseEnter += new EventHandler(geritusu_MouseEnter);
            geritusu.MouseLeave += new EventHandler(geritusu_MouseLeave);
            geritusu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            geritusu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void yenitusu_MouseEnter(object sender, EventArgs e)
        {
            yenitusu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yenisecili));
        }

        private void yenitusu_MouseLeave(object sender, EventArgs e)
        {
            yenitusu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yeni));
        }

        private void geritusu_MouseEnter(object sender, EventArgs e)
        {
            geritusu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gerisecili));
        }

        private void geritusu_MouseLeave(object sender, EventArgs e)
        {
            geritusu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.geri));
        }

    }
}
