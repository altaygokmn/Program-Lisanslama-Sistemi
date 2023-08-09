using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace LisansAlmaProgramı
{
    public partial class LisansGonderForm : Form
    {
        private string serialKey;   
        public LisansGonderForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "hvPYAAJGV0tyFGAdvydpHRwbLEFIvQTrnilIan3y",
            BasePath = "https://lisans-19952-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void btnKeyGonder_Click(object sender, EventArgs e)
        {
            // client nesnesini başlatma işlemini btnKeyGonder_Click metodu içinde yapın.
            try
            {
                client = new FireSharp.FirebaseClient(fc);

                if (client == null)
                {
                    MessageBox.Show("Veri Tabanına Bağlanamadı");
                    return;
                }

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    private string GenerateRandomKey(string cpuMarka, string cpuCekirdekSayisi, string cpuThreadSayisi)
                    {
                        string cpuBilgileri = cpuMarka + cpuCekirdekSayisi + cpuThreadSayisi;
                        byte[] cpuBilgileriBytes = Encoding.UTF8.GetBytes(cpuBilgileri);

                        using (var sha256 = new SHA256Managed())
                        {
                            byte[] hash = sha256.ComputeHash(cpuBilgileriBytes);
                            return BitConverter.ToString(hash).Replace("-", string.Empty);
                        }
                    }
                    serialKey = GenerateRandomKey(cpuMarka, cpuCekirdekSayisi, cpuThreadSayisi);
                    FrLisans frs = new FrLisans()
                    {
                        key = serialKey
                    };
                    MessageBox.Show("Lisansınız oluşturuldu!"+"\n"+"Lisans anahtarınız otomatik olarak kopyalandı!","Başarılı");
                    var setet = client.Set("Lisanstbl/" + serialKey, frs);
                    CopyTextToClipboard(serialKey);
                    labelRandomAnahtar.Text = "Kişisel Lisans Anahtarınız: " + serialKey;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private string GenerateRandomKey(string cpuMarka, string cpuCekirdekSayisi, string cpuThreadSayisi)
        {
            string cpuBilgileri = cpuMarka + cpuCekirdekSayisi + cpuThreadSayisi;
            byte[] cpuBilgileriBytes = Encoding.UTF8.GetBytes(cpuBilgileri);

            using (var sha256 = new SHA256Managed())
            {
                byte[] hash = sha256.ComputeHash(cpuBilgileriBytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
        private void CopyTextToClipboard(string text)
        {
            Clipboard.SetText(text);
        }
        public class FrLisans
        {
            public string key { get; set; }
        }
    }
}
