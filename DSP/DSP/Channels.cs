using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DSP
{
    public partial class Channels : Form
    {
        FlowLayoutPanel fpanel;
        int channels, count;
        double discret, rate;
        string[] names, file;

        public Channels(int numberOfChannels, int numberOfCount,
                double rateDiscret, double sampleRate, string[] fileDateSplit, 
                string[] nameOfChannels)
        {
            fpanel = new FlowLayoutPanel();
            fpanel.Dock = DockStyle.Fill;
            fpanel.AutoScroll = true;
            this.Controls.Add(fpanel);
            this.Load += Onload;

            InitializeComponent();

            channels = numberOfChannels;
            count = numberOfCount;
            rate = sampleRate;
            discret = rateDiscret;
            names = nameOfChannels;
            file = fileDateSplit;
        }

        private void Onload(object sender, EventArgs e)
        {
            fpanel.Controls.Clear();

            for (var i = 0; i < channels; i++)
            {
                var graph = new ZedGraphControl();
                GraphPane pane = graph.GraphPane;
                pane.XAxis.Title.Text = "";
                pane.YAxis.Title.Text = "";
                pane.Title.Text = names[i];
                pane.Title.FontSpec.IsBold = false;
                pane.Title.FontSpec.Size = 34;
                fpanel.Controls.Add(graph);
            }
        }

        private void DrawGraph()
        {
            /*GraphPane pane = graphControl.GraphPane;
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "";
            pane.Title.Text = names[0];
            pane.Title.FontSpec.IsBold = false;
            pane.Title.FontSpec.Size = 34;*/
        }

        private void Channels_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
        }
    }
}
