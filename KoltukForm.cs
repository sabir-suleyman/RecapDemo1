/*
 * Sabir Süleymanlı  <suleymanli.sabir@anticverse.com>
 * 
 * KoltukForm.cs
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecapDemo1;
namespace RecapDemo1
{
    public partial class KoltukForm : Form
    {
        public KoltukForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // pencere boyutunu sabitledik
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600); 
        }


        

        private void KoltukForm_Load(object sender, EventArgs e)
        {
            
        }

        private void KoltukForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.KoltukBilgisi))
            {
                koltukno_uyari.Visible = true;
            }
        }

        private void koltuk_onay_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
