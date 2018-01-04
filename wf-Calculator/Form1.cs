using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ilkgiris = true;
        string sonislem = "";
        int arasonuc = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //Button btn = sender as Button;
            if (ilkgiris)
            {
                txtGiris.Text = btn.Text;
                ilkgiris = false;
            }
            else
            {
                txtGiris.Text += btn.Text;
            }
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            if (ilkgiris)
            {
                sonislem = "+";
                txtIslem.Text = txtIslem.Text.Substring(0, txtIslem.Text.Length - 1) + "+";
            }
            else
            {
                ilkgiris = true;
                txtIslem.Text += txtGiris.Text + "+";
                if (sonislem == "")
                {
                    arasonuc = Convert.ToInt32(txtGiris.Text);
                }
                else
                {
                    arasonuc = Hesapla(arasonuc, Convert.ToInt32(txtGiris.Text), sonislem);
                }
                txtGiris.Text = arasonuc.ToString();
                sonislem = "+";
            }
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            if (ilkgiris)
            {
                sonislem = "-";
                txtIslem.Text = txtIslem.Text.Substring(0, txtIslem.Text.Length - 1) + "-";
            }
            else
            {
                ilkgiris = true;
                txtIslem.Text += txtGiris.Text + "-";
                if (sonislem == "")
                {
                    arasonuc = Convert.ToInt32(txtGiris.Text);
                }
                else
                {
                    arasonuc = Hesapla(arasonuc, Convert.ToInt32(txtGiris.Text), sonislem);
                }
                txtGiris.Text = arasonuc.ToString();
                sonislem = "-";
            }
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            if (ilkgiris)
            {
                sonislem = "*";
                txtIslem.Text = txtIslem.Text.Substring(0, txtIslem.Text.Length - 1) + "*";
            }
            else
            {
                ilkgiris = true;
                txtIslem.Text += txtGiris.Text + "*";
                if (sonislem == "")
                {
                    arasonuc = Convert.ToInt32(txtGiris.Text);
                }
                else
                {
                    arasonuc = Hesapla(arasonuc, Convert.ToInt32(txtGiris.Text), sonislem);
                }
                txtGiris.Text = arasonuc.ToString();
                sonislem = "*";
            }
        }

        private void btnBolu_Click(object sender, EventArgs e)
        {
            if (ilkgiris)
            {
                sonislem = "/";
                txtIslem.Text = txtIslem.Text.Substring(0, txtIslem.Text.Length - 1) + "/";
            }
            else
            {
                ilkgiris = true;
                txtIslem.Text += txtGiris.Text + "/";
                if (sonislem == "")
                {
                    arasonuc = Convert.ToInt32(txtGiris.Text);
                }
                else
                {
                    arasonuc = Hesapla(arasonuc, Convert.ToInt32(txtGiris.Text), sonislem);
                }
                txtGiris.Text = arasonuc.ToString();
                sonislem = "/";
            }
        }
        private int Hesapla(int ilksayi, int sonsayi, string islem)
        {
            int sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = ilksayi + sonsayi;
                    break;
                case "-":
                    sonuc = ilksayi - sonsayi;
                    break;
                case "*":
                    sonuc = ilksayi * sonsayi;
                    break;
                case "/":
                    sonuc = ilksayi / sonsayi;
                    break;
            }
            return sonuc;
        }
        private void btnEsit_Click(object sender, EventArgs e)
        {
            ilkgiris = true;
            txtIslem.Text = "";
            if (sonislem == "")
            {
                arasonuc = Convert.ToInt32(txtGiris.Text);
            }
            else
            {
                arasonuc = Hesapla(arasonuc, Convert.ToInt32(txtGiris.Text), sonislem);
            }
            txtGiris.Text = arasonuc.ToString();
            sonislem = "";
        }

        private void btnSolaOk_Click(object sender, EventArgs e)
        {
            txtGiris.Text = txtGiris.Text.Substring(0, txtGiris.Text.Length - 1);
            if(txtGiris.Text == "")
            {
                txtGiris.Text = "0";
                ilkgiris = true;
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "0";
            ilkgiris = true;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "0";
            txtIslem.Text = "";
            ilkgiris = true;
            sonislem = "";
            arasonuc = 0;
        }
    }
}
