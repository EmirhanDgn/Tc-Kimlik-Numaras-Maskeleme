using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tc_Kimlik_Maskeleme
{
    public partial class TcMaskeleme : Form
    {
        public TcMaskeleme()
        {
            InitializeComponent();
        }
        public void TcMaskele()
        {
            var tc = txtTc.Text;
            var ilk = tc.Substring(0, 3);
            var son = tc.Substring(tc.Length - 3, 3);
            var mask = new string('X', tc.Length - ilk.Length - son.Length);
            var maskelenmis = string.Concat(ilk, mask, son);
            lblMaskelenmis.Text = maskelenmis.ToString();
        }

        private void TcMaskeleme_Load(object sender, EventArgs e)
        {

        }

        private void btnMaskele_Click(object sender, EventArgs e)
        {
            TcMaskele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
