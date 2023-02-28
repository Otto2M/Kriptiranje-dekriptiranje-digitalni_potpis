using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DigitalniPotpis
{
    public partial class Kriptiranje : Form
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory.Replace("DigitalniPotpis\\bin\\Debug\\net6.0-windows", "datoteke");
        Aes aes = Aes.Create();
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        public Kriptiranje()
        {
            InitializeComponent();
            btnKriptiraj.Enabled = false;
        }

        private void btnUcitajSadrzajDatoteke_Click(object sender, EventArgs e)
        {
            string sadrzaj = File.ReadAllText(path + "tekst.txt", Encoding.UTF8);
            tbSadrzajDatoteke.Text = sadrzaj;
        }

        private void btnKreirajKljuceve_Click(object sender, EventArgs e)
        {
            KreirajKljuceve();
        }

        public void KreirajKljuceve()
        {
            aes.GenerateKey();
            aes.GenerateIV(); 

            byte[] key = aes.Key;
            byte[] iv = aes.IV;

            string tajniKljuc = Convert.ToBase64String(key); 
            string IV = Convert.ToBase64String(iv);

            tajniKljuc += Environment.NewLine + IV; 

            File.WriteAllText(path + "tajni_kljuc.txt", tajniKljuc);

            //asimetricna kriptografija - zapis kljuceva
            File.WriteAllText(path + "javni_kljuc.txt", rsa.ToXmlString(false));
            File.WriteAllText(path + "privatni_kljuc.txt", rsa.ToXmlString(true));

            MessageBox.Show("Kljucevi uspješno generirani!");
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            string sadrzajDatoteke = tbSadrzajDatoteke.Text;

            if (string.IsNullOrEmpty(tbSadrzajDatoteke.Text) == true)
            {
                MessageBox.Show("Nije moguce kriptirati sadržaj! Najprije ucitajte sadržaj datoteke 'tekst.txt'");
            }
            else if (cbAES.Checked == true) 
            {
                KriptirajAES(sadrzajDatoteke);
            }
            else
            {
                KriptirajRSA(sadrzajDatoteke);
            }
        }

        private void KriptirajAES(string sadrzaj)
        {
            byte[] tekst = Encoding.UTF8.GetBytes(sadrzaj);

            string[] lines = File.ReadAllLines(path + "tajni_kljuc.txt");
            string tajniKljuc = lines[0];
            string IVstring = lines[1];

            aes.Key = Convert.FromBase64String(tajniKljuc);
            aes.IV = Convert.FromBase64String(IVstring);
            ICryptoTransform kripto = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] kriptiranaPoruka = kripto.TransformFinalBlock(tekst, 0, tekst.Length);
            string kriptiranaPorukaString = Convert.ToBase64String(kriptiranaPoruka);
            tbKriptiranaPoruka.Text = kriptiranaPorukaString;
            File.WriteAllText(path + "kriptiranaPorukaAES.txt", kriptiranaPorukaString);
        }

        private void KriptirajRSA(string sadrzaj)
        {
            XDocument javniKljuc = XDocument.Load(path + "javni_kljuc.txt");

            rsa.FromXmlString(javniKljuc.ToString());

            byte[] tekst = Encoding.UTF8.GetBytes(sadrzaj);

            byte[] kriptiranaPoruka = rsa.Encrypt(tekst, true);

            tbKriptiranaPoruka.Text = Convert.ToBase64String(kriptiranaPoruka, 0, kriptiranaPoruka.Length);
            File.WriteAllText(path + "kriptiranaPorukaRSA.txt", tbKriptiranaPoruka.Text);
        }

        private void cbAES_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeriStanjeAES();
        }

        private void cbRSA_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeriStanjeRSA();
        }

        private void ProvjeriStanjeAES()
        {
            if (cbAES.Checked == true)
            {
                cbRSA.Checked = false;
                btnKriptiraj.Enabled = true;
            }
            else
            {
                cbAES.Checked = false;
                cbRSA.Checked = true;
            }
        }

        private void ProvjeriStanjeRSA()
        {
            if (cbRSA.Checked == true)
            {
                cbAES.Checked = false;
                btnKriptiraj.Enabled = true;
            }
            else
            {
                cbRSA.Checked = false;
                cbAES.Checked = true;
            }
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKriptiranaPoruka.Text))
            {
                MessageBox.Show("Prvo morate kriptirati poruku da bi ju mogli dekriptirati!");
            }
            else if (cbAES.Checked == true)
            {
                string kriptiranaPorukaAES = File.ReadAllText(path + "kriptiranaPorukaAES.txt");
                DekriptirajAES(kriptiranaPorukaAES);
            }
            else
            {
                string kriptiranaPorukaRSA = File.ReadAllText(path + "kriptiranaPorukaRSA.txt");
                DekriptirajRSA(kriptiranaPorukaRSA);
            }
        }

        private void DekriptirajAES(string kriptiranaPorukaAES)
        {
            byte[] kriptiraniTekst = Convert.FromBase64String(kriptiranaPorukaAES);

            string[] lines = File.ReadAllLines(path + "tajni_kljuc.txt");
            string tajniKljuc = lines[0];
            string IVstring = lines[1];

            aes.Key = Convert.FromBase64String(tajniKljuc);
            aes.IV = Convert.FromBase64String(IVstring);
            ICryptoTransform kripto = aes.CreateDecryptor(aes.Key, aes.IV);

            byte[] dekriptiranaPoruka = kripto.TransformFinalBlock(kriptiraniTekst, 0, kriptiraniTekst.Length);
            string dekriptiranaPorukaString = Encoding.UTF8.GetString(dekriptiranaPoruka);

            tbDekriptiranaPoruka.Text = dekriptiranaPorukaString;
        }

        private void DekriptirajRSA(string kriptiranaPorukaRSA)
        {
            XDocument privatniKljuc = XDocument.Load(path + "privatni_kljuc.txt");

            string privatniKljucString = privatniKljuc.ToString();

            rsa.FromXmlString(privatniKljucString);

            byte[] kriptiraniTekst = Convert.FromBase64String(kriptiranaPorukaRSA);
            byte[] dekriptiranaPoruka = rsa.Decrypt(kriptiraniTekst, true);
            string dekriptiranaPorukaString = Encoding.UTF8.GetString(dekriptiranaPoruka);

            tbDekriptiranaPoruka.Text = dekriptiranaPorukaString;
        }

        private void btnIzracunajSazetak_Click(object sender, EventArgs e)
        {
            string sadrzaj = File.ReadAllText(path + "tekst.txt");
            IzracunajSazetakUlaznogSadrzaja(sadrzaj);
        }

        private byte[] IzracunajSazetakUlaznogSadrzaja(string tekst)
        {
            var messageBytes = Encoding.UTF8.GetBytes(tekst);
            var messageDigest = IzracunajSazetakPoruke(messageBytes);

            Debug.WriteLine(BitConverter.ToString(messageDigest).Replace("-", ""));
            tbSHAsazetak.Text = Convert.ToBase64String(messageDigest);
            File.WriteAllText(path + "SHA256sazetak.txt", tbSHAsazetak.Text);
            return messageDigest;
        }

        static byte[] IzracunajSazetakPoruke(byte[] message) 
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] sazetakPoruke = sha256.ComputeHash(message);
                return sazetakPoruke;
            }
        }

        private void btnIzracunajDigitalniPotpis_Click(object sender, EventArgs e)
        {
            string sazetak = File.ReadAllText(path + "SHA256sazetak.txt");
            IzracunajDigitalniPotpis(sazetak);
        }

        private void IzracunajDigitalniPotpis(string sazetak)
        {
            byte[] sazetakByte = Convert.FromBase64String(sazetak);
            byte[] digitalniPotpis;

            var createDigitalSignature = new RSAPKCS1SignatureFormatter(rsa);
            createDigitalSignature.SetHashAlgorithm("SHA256");
            digitalniPotpis = createDigitalSignature.CreateSignature(sazetakByte);
            string digitalniPotpisString = Convert.ToBase64String(digitalniPotpis);

            tbDigitalniPotpis.Text = digitalniPotpisString;
            File.WriteAllText(path + "digitalniPotpis.txt", tbDigitalniPotpis.Text);
        }


        private void btnProvjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            ProvjeriDigitalniPotpis();
        }

        private void ProvjeriDigitalniPotpis()
        {
            string potpis = File.ReadAllText(path + "digitalniPotpis.txt");
            byte[] potpisByte;
            
            try
            {
                potpisByte = Convert.FromBase64String(potpis);
            }
            catch (FormatException)
            {
                MessageBox.Show("Potpis je neispravan! Dogodila se promjena unutar datoteke!");
                return;
            }
            
            string sadrzajPocetneDatoteke = File.ReadAllText(path + "tekst.txt");
            byte[] sazetakPocetneDatoteke = IzracunajSazetakUlaznogSadrzaja(sadrzajPocetneDatoteke);

            RSAPKCS1SignatureDeformatter provjeriPotpis = new RSAPKCS1SignatureDeformatter(rsa);
            provjeriPotpis.SetHashAlgorithm("SHA256");

            if(provjeriPotpis.VerifySignature(sazetakPocetneDatoteke, potpisByte) == true)
            {
                MessageBox.Show("Potpis je ispravan!");
            }
            else
            {
                MessageBox.Show("Potpis je neispravan! Dogodila se promjena unutar datoteke!");
            }
        }

        private void Ocisti()
        {
            tbSadrzajDatoteke.Clear();
            tbKriptiranaPoruka.Clear();
            tbDekriptiranaPoruka.Clear();
            tbSHAsazetak.Clear();
            tbDigitalniPotpis.Clear();
            File.WriteAllText(path + "javni_kljuc.txt", string.Empty);
            File.WriteAllText(path + "privatni_kljuc.txt", string.Empty);
            File.WriteAllText(path + "tajni_kljuc.txt", string.Empty);
            File.WriteAllText(path + "kriptiranaPorukaAES.txt", string.Empty);
            File.WriteAllText(path + "kriptiranaPorukaRSA.txt", string.Empty);
            File.WriteAllText(path + "SHA256sazetak.txt", string.Empty);
            File.WriteAllText(path + "digitalniPotpis.txt", string.Empty);
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            Ocisti();
        }
    }
}