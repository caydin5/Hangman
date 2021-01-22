using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class _2p : Form
    {
        PrivateFontCollection architect = new PrivateFontCollection();
        SoundPlayer geri = new SoundPlayer(adamasmaca.Properties.Resources.gerises);


        public _2p()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Klasik oyun = new Klasik(); //Oyun ekranını tanımlar   
            oyun.coklu = true;
            oyun.kelime = txtkel.Text;
            oyun.ShowDialog();
            this.Close();
        }
        
        private void _2p_Load(object sender, EventArgs e)
        {
            label1.Text = "Arkadaşına çaktırmadan kelimeni gir bakalım!";
            architect.AddFontFile(@"C:\Users\Cem\Desktop\armut\AA_Beta\adamasmaca\adamasmaca\Resources\Buteco.otf");
            label1.Font = new Font(architect.Families[0], 20);
            txtkel.Font = new Font(architect.Families[0], 16);
            checkBox1.Text = "Kelimeyi göster";
            txtkel.PasswordChar = '*';
            geritusu.MouseEnter += new EventHandler(geritusu_MouseEnter);
            geritusu.MouseLeave += new EventHandler(geritusu_MouseLeave);
            geritusu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            geritusu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            giris.FlatAppearance.MouseOverBackColor = Color.Transparent;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtkel.PasswordChar = (char)0;
            else if (checkBox1.Checked == false)
                txtkel.PasswordChar = '*';
        }

        private void _2p_FormClosing(object sender, FormClosingEventArgs e)
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
