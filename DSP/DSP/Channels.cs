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
    public partial class Channels : Form
    {
        public Channels()
        {
            InitializeComponent();
        }

        private void Channels_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
        }
    }
}
