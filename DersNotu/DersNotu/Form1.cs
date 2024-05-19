using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersNotu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int Vize = Convert.ToInt16(textBoxvize.Text);
			int Ödev = Convert.ToInt16(textBoxödev.Text);
			int Final = Convert.ToInt16(textBoxfinal.Text);

			double sonuc = BasariPuani(Vize, Ödev, Final);
			if (Vize < 0 || Vize > 100 || Ödev < 0 || Ödev > 100 || Final < 0 || Final > 100)
			{
				MessageBox.Show("0 ile 100 arasında puan girmelisiniz!");
			}
			else if (sonuc >= 90)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: AA");
			}
			else if (sonuc >= 85 && sonuc < 90)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: AB");
			}
			else if (sonuc >= 80 && sonuc < 85)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: BB");
			}
			else if (sonuc >= 75 && sonuc < 80)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: CB");
			}
			else if (sonuc >= 70 && sonuc < 75)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: CC");
			}
			else if (sonuc >= 65 && sonuc < 70)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: DC");
			}
			else if (sonuc >= 50 && sonuc < 60)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: FD");
			}
			else if (sonuc < 50)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Harf Notu: FF");
			}
			else if (Final < 50)
			{
				label4.Text = "Başarı Puanı: " + sonuc.ToString();
				MessageBox.Show("Dersi geçmek için finalden en az 50 almalısınız!");
			}
		}
		public double BasariPuani(Double Vize, Double Ödev, Double Final)
		{
			Double sonuc = (Vize / 100) * 20 + (Ödev / 100) * 30 + (Final / 100) * 50;
			return sonuc;
		}

		private void buttonx_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
