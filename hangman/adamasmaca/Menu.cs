using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace adamasmaca
{

    public partial class Menu : Form
    {
        SoundPlayer cevir = new SoundPlayer(adamasmaca.Properties.Resources.cevir);
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        bool ekleDurum = false;
        public Menu()
        {
            InitializeComponent();


        }

        private void klasik_Click(object sender, EventArgs e)
        {
            cevir.Play();
            Klasik oyun = new Klasik(); //Oyun ekranını tanımlar
            this.Hide(); //Menü ekranını oyun ekranını açmak üzere gizler
            oyun.ShowDialog(); //Oyun ekranı içeriğini görüntüler
            //this.Close(); //Menü ekranını kapatır
        }

        void klasik_MouseLeave(object sender, EventArgs e)
        {
            //this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasik));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframe));
        }

        void klasik_MouseEnter(object sender, EventArgs e)
        {
            // this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasiksecili));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframeklasik));
        }

        void pc_MouseLeave(object sender, EventArgs e)
        {
            //this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasik));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframe));
        }

        void pc_MouseEnter(object sender, EventArgs e)
        {
            // this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasiksecili));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframepc));
        }

        void coklu_MouseLeave(object sender, EventArgs e)
        {
            //this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasik));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframe));
        }

        void coklu_MouseEnter(object sender, EventArgs e)
        {
            // this.klasik.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.klasiksecili));
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.menuframecoklu));
        }

        private void coklu_Click(object sender, EventArgs e)
        {
            cevir.Play();
            _2p coklu = new _2p(); //Oyun ekranını tanımlar
            this.Hide(); //Menü ekranını oyun ekranını açmak üzere gizler
            coklu.ShowDialog(); //Oyun ekranı içeriğini görüntüler
            //this.Close(); //Menü ekranını kapatır
        }

        private void pc_Click(object sender, EventArgs e)
        {
            cevir.Play();
            Cpu cpu = new Cpu(); //Oyun ekranını tanımlar
            this.Hide(); //Menü ekranını oyun ekranını açmak üzere gizler
            cpu.ShowDialog(); //Oyun ekranı içeriğini görüntüler
            //this.Close(); //Menü ekranını kapatır
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (ekleDurum == false)
            {
                klasik.Visible = false;
                pc.Visible = false;
                coklu.Visible = false;
                Hakkinda.Visible = false;
                textBox1.Visible = true;
                eklebuton.Visible = true;
                silbuton.Visible = true;
                eklebuton.Enabled = false;
                silbuton.Enabled = false;
                this.BackgroundImage = adamasmaca.Properties.Resources.oyun;
                ekleDurum = true;
            }
            else if (ekleDurum == true)
            {
                klasik.Visible = true;
                pc.Visible = true;
                coklu.Visible = true;
                Hakkinda.Visible = true;
                this.BackgroundImage = adamasmaca.Properties.Resources.menuframe;
                ekleDurum = false;
                textBox1.Visible = false;
                eklebuton.Visible = false;
                silbuton.Visible = false;

            }
        }

        private void Hakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda hak = new Hakkinda(); //Oyun ekranını tanımlar
            hak.ShowDialog(); //Oyun ekranı içeriğini görüntüler
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Olmadı şimdi. Bu kadar çabuk mu pes ediyorsun?", "Adamı Asamadan Çık", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes) //Evet seçeneği seçildiğinde yapılacaklar
                Application.ExitThread(); //Uygulamadan çık
            else if (uyari == DialogResult.No) //Hayır seçeneği seçildiğinde yapılacaklar
                e.Cancel = true; //Mesaj kutusunu kapat
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eklebuton.Enabled = true;
            silbuton.Enabled = true;
            if (textBox1.Text == "")
            {
                eklebuton.Enabled = false;
                silbuton.Enabled = false;
            }
        }

        private void eklebuton_Click(object sender, EventArgs e)
        {
            dbEkle();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            dbSil();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            eklebuton.Visible = false;
            silbuton.Visible = false;
            textBox1.Visible = false;
            //Kullanıcı arayüzü için araçlara isim atama
            bilgi.SetToolTip(klasik, "Klasik adam asmaca oyunun keyfini çıkarın!");
            bilgi.SetToolTip(pc, "Bilgisayarın kelime bilgisini test edin!");
            bilgi.SetToolTip(coklu, "Arkadaşınıza kendi seçtiğiniz bir soru sorarak kelime bilgisini test edin!");
            bilgi.SetToolTip(eklebuton, "Bu kelimeyi veritabanına ekle");
            bilgi.SetToolTip(silbuton, "Bu kelimeyi veritabanından sil");
            bilgi.SetToolTip(Ekle, "Veritabanına kelime ekleyin yada silin");
            bilgi.SetToolTip(Hakkinda, "Bizi daha yakından tanıyın!");



            klasik.MouseEnter += new EventHandler(klasik_MouseEnter);
            klasik.MouseLeave += new EventHandler(klasik_MouseLeave);
            pc.MouseEnter += new EventHandler(pc_MouseEnter);
            pc.MouseLeave += new EventHandler(pc_MouseLeave);
            coklu.MouseEnter += new EventHandler(coklu_MouseEnter);
            coklu.MouseLeave += new EventHandler(coklu_MouseLeave);


            klasik.FlatStyle = FlatStyle.Flat;
            klasik.BackColor = Color.Transparent;
            klasik.FlatAppearance.MouseDownBackColor = Color.Transparent;
            klasik.FlatAppearance.MouseOverBackColor = Color.Transparent;
            pc.FlatStyle = FlatStyle.Flat;
            pc.BackColor = Color.Transparent;
            pc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            pc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            coklu.FlatStyle = FlatStyle.Flat;
            coklu.BackColor = Color.Transparent;
            coklu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            coklu.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void dbEkle()
        {
                con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""..\kelimelistesi.mdf""; Integrated Security = True");
         
                   // comm.Parameters.AddWithValue("@val2", txtbox2.Text);
                    //comm.Parameters.AddWithValue("@val3", txtbox3.Text);
                // da = new SqlDataAdapter("Select *From Table", con);
                 //dt = new DataTable();
                 con.Open();
           
           // cmd.Parameters.AddWithValue("@val1", textBox1.Text);
            cmd = new SqlCommand("INSERT INTO [Table] (Ekli, Kelime) VALUES ('"+1+"','" + textBox1.Text + "')", con);
            //cmd.Parameters.Add("@veri", textBox1.Text);
                 //"SELECT TOP 1 [Kelime] FROM [Table] WHERE LEN(Kelime) =4 ORDER BY NEWID()"
               //  cmd.Connection = con;
               //  da = new SqlDataAdapter(cmd);
               //  dt = new DataTable();
                cmd.ExecuteNonQuery();
                 con.Close();
            textBox1.Clear();
            }

        private void dbSil()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""..\kelimelistesi.mdf""; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("DELETE FROM [Table] WHERE Kelime= '" + textBox1.Text + "' AND [Ekli] != '"+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
        }

    }
}

