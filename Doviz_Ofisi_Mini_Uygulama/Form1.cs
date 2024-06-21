using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi_Mini_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);

            string dolaralis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarA.Text = dolaralis;

            string dolarsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarS.Text = dolarsatis;

            string euroalis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroA.Text = euroalis;

            string eurosatis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroS.Text = eurosatis;
        }

        private void btnDolarA_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarA.Text;
        }

        private void btnDolarS_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarS.Text;
        }

        private void btnEuroA_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroA.Text;
        }

        private void btnEuroS_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroS.Text;
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".",",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur =Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            double kalan = miktar - (tutar * kur);
            txtTutar.Text = tutar.ToString();
            txtKalan.Text = kalan.ToString();
        }
    }
}
