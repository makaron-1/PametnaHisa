using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PametnaHisa
{
    public partial class FormGeslo : Form
    {
        public string VnesenoGeslo { get; private set; }
        public FormGeslo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            VnesenoGeslo = txtGeslo.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
