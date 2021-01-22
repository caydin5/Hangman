using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class Klasik : Form
    {
        PrivateFontCollection architect = new PrivateFontCollection();
        SoundPlayer dogru = new SoundPlayer(adamasmaca.Properties.Resources.dogruses);
        SoundPlayer yanlis = new SoundPlayer(adamasmaca.Properties.Resources.yanlisses);
        SoundPlayer geri = new SoundPlayer(adamasmaca.Properties.Resources.gerises);
        SoundPlayer yeni = new SoundPlayer(adamasmaca.Properties.Resources.yenises);
        Bitmap[] adamresim = {adamasmaca.Properties.Resources.st1, adamasmaca.Properties.Resources.st2, adamasmaca.Properties.Resources.st3, adamasmaca.Properties.Resources.st4, adamasmaca.Properties.Resources.st5, adamasmaca.Properties.Resources.st6, adamasmaca.Properties.Resources.st7, adamasmaca.Properties.Resources.st8};
        Bitmap[] dogrusec = { adamasmaca.Properties.Resources.dogru0, adamasmaca.Properties.Resources.dogru1, adamasmaca.Properties.Resources.dogru2, adamasmaca.Properties.Resources.dogru3, adamasmaca.Properties.Resources.dogru4 };
        Bitmap[] yanlissec = { adamasmaca.Properties.Resources.yanlis0, adamasmaca.Properties.Resources.yanlis1, adamasmaca.Properties.Resources.yanlis2, adamasmaca.Properties.Resources.yanlis3, adamasmaca.Properties.Resources.yanlis4 };

        private int yanlissecim = 0;
        public string kelime;
        private string kelimeKopya;
        Button b;
        Button yapilansecim;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        public bool coklu;
        int rastgelesayi;

        Point konum = new Point(5, 0); // butonun ilk konumu
        char[] turkcekarakter = { 'Ç', 'Ğ', 'İ', 'Ö', 'Ş', 'Ü' };
        int harf;
        int t; //turkce karakter dizisi sayaci

        public Klasik()
        {
            InitializeComponent();
            gorunum();
            
        }

        private void Klasik_Load(object sender, EventArgs e)
        { 
            kur();
        }
        private void buton()
        {
            t = 0;
            harf = 65;
            for (int i = 0; i < 32; ++i)
            {
                b = new Button();
                switch (i)
                {
                    case 3:  case 8: case 11: case 18: case 23: case 26:
                        {
                            b.Text = turkcekarakter[t].ToString();
                            b.Size = new Size(35, 35);
                            b.Location = konum;
                            konum.Offset(0, b.Height + 5);
                            Klavye.Controls.Add(b);
                            b.Click += secim;
                            b.FlatStyle = FlatStyle.Flat;
                            b.BackColor = Color.Transparent;
                            b.MouseEnter += new EventHandler(b_MouseEnter);
                            b.MouseLeave += new EventHandler(b_MouseLeave);
                            b.BackgroundImageLayout = ImageLayout.Stretch;
                            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            t++;
                            break;
                        }
                    default:
                        {
                            b.Text = Convert.ToString((char)harf); ;
                            b.Size = new Size(35, 35);
                            b.Location = konum;
                            konum.Offset(0, b.Height + 5);
                            Klavye.Controls.Add(b);
                            b.Click += secim;
                            b.FlatStyle = FlatStyle.Flat;
                            b.BackColor = Color.Transparent;
                            b.BackgroundImageLayout = ImageLayout.Stretch;
                            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            b.MouseEnter += new EventHandler(b_MouseEnter);
                            b.MouseLeave += new EventHandler(b_MouseLeave);
                            harf++;
                            break;
                        }
                }

            }
        }

        private void butonaktif(bool durum)//Butonlara deger atama (Turkce karakterlerin ASCII degerleri basilmadigi icin ayrica tanimlandi)

        {
            Klavye.Enabled = durum;
        }

            private void kur()
        {
            _2p kel = new _2p();
            if (kelime==null)
            {
                db();//kelimenin rastgele olarak cekilecegi dbEkle
                coklu = false;
            }
            yanlissecim = 0;
            daragaci.Image = null;

            char[] kelcheck = kelime.ToCharArray(); //Bosluk ve i kontrolu icin kelimeyi char dizisine cevirme
            kelimeKopya = "";

            for (int c = 0; c < kelime.Length; c++)
            {
                if (kelcheck[c] == 'i')
                    kelcheck[c] = 'İ';
                kelime = new string(kelcheck);
                kelime = kelime.ToUpper(); //Secilen kelimeyi kucuk harfe cevirme
                if (kelcheck[c] == ' ')
                    kelimeKopya += " ";
                else
                    kelimeKopya += "_";
            }
            kopyaGoster();
            buton();
            timer.Start();
        }

        private void kopyaGoster()
        {
            label1.Text = " ";
            for (int c = 0; c < kelimeKopya.Length; c++)
            {
                label1.Text += kelimeKopya.Substring(c, 1);
                label1.Text += " ";
            }
        }

        private void secim(object basilan, EventArgs e)         //Basılan tüm butonların ortak olarak çalıştığı fonksiyon
        {
            yapilansecim = (Button)basilan;
            yapilansecim.Enabled = false;
            rastgelesayi = (new Random()).Next(0,5);
            yapilansecim.BackgroundImageLayout = ImageLayout.Stretch;

            if (kelime.Contains(yapilansecim.Text))
            {
                dogru.Play();
                yapilansecim.BackgroundImage = dogrusec[rastgelesayi];
                char[] gecici = kelimeKopya.ToCharArray();
              char[] bul = kelime.ToCharArray();
              char charTahmin = yapilansecim.Text.ElementAt(0);
                for (int i = 0; i < bul.Length; i++)
                {
                    if (bul[i] == charTahmin)
                    {
                   gecici[i] = charTahmin;
                    }
                    
                }
                kelimeKopya = new string(gecici);
                kopyaGoster();

                if (kelimeKopya.Equals(kelime))
                {
                    MessageBox.Show("Kazandınız. Yeniden denemek için yeniden dene butonuna tıklayın.");
                   butonaktif(false);
                    if (coklu == false)
                    {
                        con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""..\kelimelistesi.mdf""; Integrated Security = True");
                        con.Open();
                        //cmd = new SqlCommand("INSERT INTO [Table] (Bildi) VALUES ("+1+") WHERE (Kelime) = '"+kelime+ "' COLLATE SQL_Latin1_General_CP1_CI_AS");
                        cmd = new SqlCommand("UPDATE [Table] SET (Bildi) = (" + 1 + ") WHERE (Kelime) = '" + kelime + "'");
                        cmd.Connection = con;
                        da = new SqlDataAdapter(cmd);
                        con.Close();
                    }
                    kelime = "";
                }
            }

            else
            {
                yanlis.Play();
                yapilansecim.BackgroundImage = yanlissec[rastgelesayi];
                yanlissecim++;

                if (yanlissecim < 7)
                    daragaci.Image = adamresim[yanlissecim];
                else
                {
                    daragaci.Image = adamresim[yanlissecim];
                    kelimeKopya = kelime;
                    kopyaGoster();
                    MessageBox.Show("Kaybettiniz. Yeniden denemek için yeniden dene butonuna tıklayın.");
                    yanlissecim = 0;
                   butonaktif(false);
                    
                }
            }
        }

        private void yenioyun(object sender, EventArgs e)
        {
            if (coklu == true)
            {
                _2p coklu = new _2p();
                this.Hide();
                coklu.ShowDialog();
                this.Close();
            }
            else
                kelime = null;
                yeni.Play();
                this.Controls.Clear();
                this.InitializeComponent();
                gorunum();
                kur();
        }
        
        private void Klasik_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Olmadı şimdi. Bu kadar çabuk mu pes ediyorsun?", "Adamı Asamadan Çık", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes) //Evet seçeneği seçildiğinde yapılacaklar
                Application.ExitThread(); //Uygulamadan çık
            else if (uyari == DialogResult.No) //Hayır seçeneği seçildiğinde yapılacaklar
                e.Cancel = true; //Mesaj kutusunu kapat
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

        private void b_MouseEnter(object sender, EventArgs e)
        {
            rastgelesayi = (new Random()).Next(0, 5);
            yapilansecim = (Button)sender;
            yapilansecim.BackgroundImage = dogrusec[rastgelesayi];
        }

        private void b_MouseLeave(object sender, EventArgs e)
        {
            if (yapilansecim.Enabled)
            {
                yapilansecim = (Button)sender;
                yapilansecim.BackgroundImage = null;
            }
        }


        private void db()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""..\kelimelistesi.mdf""; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 [Kelime] FROM [Table] WHERE [Bildi] IS NULL ORDER BY NEWID()");
            //"SELECT TOP 1 [Kelime] FROM [Table] WHERE LEN(Kelime) =4 ORDER BY NEWID()"
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            kelime = dt.Rows[0]["Kelime"].ToString();
            con.Close();
        }

        private void gorunum()
        {
            //Pencere Boyut Ayari
            int height = 640;
            int width = 725;
            ClientSize = new System.Drawing.Size(width, height);

            architect.AddFontFile(@"..\Resources\Buteco.otf");
            label1.Font = new Font(architect.Families[0], 36);
            Klavye.Font = new Font(architect.Families[0], 18);

            yenitusu.MouseEnter += new EventHandler(yenitusu_MouseEnter);
            yenitusu.MouseLeave += new EventHandler(yenitusu_MouseLeave);
            yenitusu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            yenitusu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            geritusu.MouseEnter += new EventHandler(geritusu_MouseEnter);
            geritusu.MouseLeave += new EventHandler(geritusu_MouseLeave);
            geritusu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            geritusu.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void geritusu_Click(object sender, EventArgs e)
        {
            geri.Play();
            this.Hide();
            Menu menu = new Menu(); //Oyun ekranını tanımlar
            menu.ShowDialog();
            this.Close();

        }
    }

   


}