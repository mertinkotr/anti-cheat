using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace AntiCheat
{   
    public partial class AntiCheat : Form
    {
        public AntiCheat()
        {
            InitializeComponent();
        }

        private void FtpUpl(string furl, string purl, string flogin, string fpass, string failo_url)
        {
            FtpWebRequest ftp = (FtpWebRequest) FtpWebRequest.Create(furl + "/" + purl + "/" + Path.GetFileName(failo_url));
           
            ftp.Method = WebRequestMethods.Ftp.UploadFile;          //unique
            ftp.Credentials = new NetworkCredential(flogin, fpass);
            ftp.UsePassive = true;
            ftp.UseBinary = true;
            ftp.KeepAlive = false;

            //failo konvertavimas
            FileStream str = File.OpenRead(failo_url);
            byte[] buf = new byte[str.Length];
            str.Read(buf, 0, buf.Length);
            str.Close();

            //failo ikelimas
            Stream rstr = ftp.GetRequestStream();
            rstr.Write(buf, 0, buf.Length);
            rstr.Close();                       
        }

        private void NaujasF(string furl, string purl, string flogin, string fpass)
        {
            WebRequest request = WebRequest.Create(furl + "/" + purl);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(flogin, fpass);
            using (var resp = (FtpWebResponse)request.GetResponse())
            {               
            }
        }

        private string PrintScr()
        {
            string pvd = "";
            DateTime laikas = DateTime.Now;

            OperatingSystem os = Environment.OSVersion;
            Version vs = os.Version;

            switch (vs.Major)
            {
                //Vista arba Win7
                case 6:         
                    SendKeys.Send("%{PRTSC}");
                    Image foto = null;
                    if (Clipboard.ContainsImage())
                    {
                        foto = Clipboard.GetImage();                        
                        pvd = laikas.Hour.ToString() + laikas.Minute.ToString() + laikas.Second.ToString();
                        foto.Save(pvd + ".jpg", ImageFormat.Jpeg);
                    }
                    break;

                //XP arba kita
                default:        
                    Bitmap fot2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    Graphics ft = Graphics.FromImage(fot2 as Image);
                    ft.CopyFromScreen(0, 0, 0, 0, fot2.Size);                   
                    pvd = laikas.Hour.ToString() + laikas.Minute.ToString() +  laikas.Second.ToString();
                    fot2.Save(pvd + ".jpg", ImageFormat.Jpeg);
                    break;
            }     
            
            return pvd;
        }

        private void Zaidbus()
        {
            //zaidimo proceso pavadinimas (be exe)
            string zaid = "hl2";            
            bool tikr =  Process.GetProcesses().Any(prc => prc.ProcessName.Contains(zaid));
            if (tikr)
            {                
                lstat.Text = "on";
                lstat.ForeColor = Color.Green;
            }
            else
            {
                lstat.Text = "off";
                lstat.ForeColor = Color.LightCoral;
            }
        }

        private void Apsbus()
        {
            if (lstat.Text == "on" && Jungtis.Enabled == false)
            {                
                lrez.Text = "on";
                lrez.ForeColor = Color.Green;
            }
            else
            {
                lrez.Text = "off";
                lrez.ForeColor = Color.LightCoral;
            }
        }

        private void Fotodel()
        {
            string[] fotos = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string f in fotos)
                if (f.Contains(".jpg"))
                    File.Delete(f);
        }

        private string SlaptFail(string furl, string flogin, string fpass, string fpav)
        {
            FtpWebRequest tmpReq = (FtpWebRequest)FtpWebRequest.Create(furl + "/" + fpav);
            tmpReq.Credentials = new NetworkCredential(flogin, fpass);

            WebResponse tmpRes = tmpReq.GetResponse();
            Stream tmpStream = tmpRes.GetResponseStream();
            TextReader tmpReader = new StreamReader(tmpStream);
            return tmpReader.ReadToEnd();   
        }

        private bool Slapt(string furl, string flogin, string fpass)
        {
            bool b1 = false,
                 b2 = false;

            string duotasslapt = "slaptazodis.txt";
            string duotas = SlaptFail(furl, flogin, fpass, duotasslapt);
            if (duotas == slaptazodis.Text)
                b1 = true;

            string vartotslapt = "vartotojai.txt";
            string vartot = SlaptFail(furl, flogin, fpass, vartotslapt);
            if (vartot.Contains(slapyvardis.Text) && vartot.Contains(yslapt.Text) && 
                vartot.IndexOf(slapyvardis.Text) == vartot.IndexOf(yslapt.Text) - slapyvardis.Text.Length - 1)
                b2 = true;

            return b1 & b2;                      
        }

        private void Veikla(string furl, string flogin, string fpass, string purl)
        {
            //screeno paemimas ir jo adresas
            string failoUrl = Directory.GetCurrentDirectory() + "/" + PrintScr() + ".jpg";       

            //nuotraukos ikelimas
            FtpUpl(furl, purl, flogin, fpass, failoUrl);

            //trinam nuotraukas is pc
            Fotodel();
        }

        string Kkatalog(string furl, string flogin, string fpass)
        {
            //Siandienos data
            DateTime snd = DateTime.Now;
            string purl = snd.Year.ToString() + snd.Month.ToString() + snd.Day.ToString();

            Application.DoEvents();
            //katalogo kurimas
            try
            {
                NaujasF(furl, purl, flogin, fpass);
            }
            catch { }
            try
            {
                purl += "/" + slapyvardis.Text;
                NaujasF(furl, purl, flogin, fpass);
            }
            catch { }

            return purl;
        }
        
        private void Jungtis_Click(object sender, EventArgs e)
        {
            //FTP prisijungimo struktura         
            string furl = "hidden",
                   flogin = "hidden",
                   fpass = "hidden";            

            //slaptazodzio tikrinimas         
            bool sl = Slapt(furl, flogin, fpass);
            if (sl)
            {
                Jungtis.Text = "Connected";
                Jungtis.Enabled = false;
                slapyvardis.Enabled = false;
                slaptazodis.Enabled = false;
                yslapt.Enabled = false;
             
                //katalogu kurimas
                string purl = Kkatalog(furl, flogin, fpass);
              
                //pagrindinis algoritmas     
                DateTime prad = DateTime.Now;
                TimeSpan skirtumas;
                Random rnd = new Random();
                int tikr = rnd.Next(1, 2);                                           //po kiek laiko capturins 1st karta
                while (true)
                {
                    Application.DoEvents();                   
                    System.Threading.Thread.Sleep(50);                    
                    skirtumas = DateTime.Now.Subtract(prad);
                    Zaidbus();          Apsbus();                                     //tikrina zaidimo ir apsaugos busenas                   
                    if (skirtumas.Minutes >= tikr && lstat.Text == "on")         //praejo laikas ir veikia zaidimas
                    {
                        try
                        {
                            Veikla(furl, flogin, fpass, purl);                                  //pagr vykdymas
                        }
                        catch { }
                        prad = DateTime.Now;        
                        tikr = rnd.Next(1, 2);                                       //pakeicia capturinimo uzdelsima
                    }
                }
            }      
            else
                MessageBox.Show("Connection failed!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void AntiCheat_Load(object sender, EventArgs e)
        {
            //zaidimo busena
            Zaidbus();
            if (lstat.Text == "on")
            {
                Jungtis.Enabled = false;
                MessageBox.Show("First execute AntiCheat and just then the game!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }        
        }         

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.coderland.lt/");
        }

        private void tray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void AntiCheat_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void atkurtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tray_DoubleClick(null, null);
        }

        private void išjungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void AntiCheat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
         
    }
}