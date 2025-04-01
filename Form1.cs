using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // yapılmak isteneni dener eğer bir sorun çıkarsa catch bloğuna geçer

                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 * s2;

                lblSonuc.Text = Convert.ToString(sonuc);

            }
            catch (Exception)
            {
                // try bloğunda herhangi bir problem çıktığında devreye girer
                MessageBox.Show("Girilen değerlere dikkat ediniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                // finally bloğu her iki durumda da çalışır
                MessageBox.Show("Finally çalıştı");
            }
            

        }

    }
}
