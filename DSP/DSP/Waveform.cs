using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP
{
    public partial class Waveform : Form
    {
        public Waveform()
        {
            InitializeComponent();
        }

        private void Waveform_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
        }
    }
}
