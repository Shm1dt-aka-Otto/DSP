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
        FlowLayoutPanel fPanel;
        int numberChannels, numberCount;
        double discreteRate, rateSignal;
        string[] channelsNames, fileData;
        bool isWaveFormOpen = false;

        public Channels(int numberOfChannels, int numberOfCount,
                double rateDiscret, double sampleRate, string[] fileDateSplit, 
                string[] nameOfChannels)
        {
            discreteRate = rateDiscret;
            numberChannels = numberOfChannels;
            numberCount = numberOfCount;
            fileData = fileDateSplit;
            fPanel = new FlowLayoutPanel();
            fPanel.Dock = DockStyle.Fill;
            fPanel.AutoScroll = true;
            this.Controls.Add(fPanel);
            this.Load += Onload;

            InitializeComponent();

            numberChannels = numberOfChannels;
            numberCount = numberOfCount;
            rateSignal = sampleRate;
            discreteRate = rateDiscret;
            channelsNames = nameOfChannels;
            fileData = fileDateSplit;
        }

        void zedGraph_ContextMenuBuilder(ZedGraphControl sender,
        ContextMenuStrip menuStrip,
        Point mousePt,
        ZedGraphControl.ContextMenuObjectState objState)
        {
            for (int i = 0; i < 8; i++)
            {
                menuStrip.Items.RemoveAt(0);
            }
            ToolStripItem waveForm = new ToolStripMenuItem("Осцилограмма");
            menuStrip.Items.Add(waveForm);
            waveForm.Click += new EventHandler(waveFormClicked);
            ToolStripItem spectrFurie = new ToolStripMenuItem("Спектр Фурье");
            menuStrip.Items.Add(spectrFurie);
            ToolStripItem waveLetogram = new ToolStripMenuItem("Вейвлетограмма");
            menuStrip.Items.Add(waveLetogram);
            ToolStripItem correlation = new ToolStripMenuItem("Корреляция с ...");
            menuStrip.Items.Add(correlation);
            ToolStripItem crossSpectrum = new ToolStripMenuItem("Кросс-спектр с ...");
            menuStrip.Items.Add(crossSpectrum);
            ToolStripItem hide = new ToolStripMenuItem("Скрыть");
            menuStrip.Items.Add(hide);
            ToolStripItem hideAll = new ToolStripMenuItem("Скрыть все, кроме этого");
            menuStrip.Items.Add(hideAll);
            ToolStripItem showAll = new ToolStripMenuItem("Показать все");
            menuStrip.Items.Add(showAll);
            ToolStripItem filter = new ToolStripMenuItem("Фильтрация");
            menuStrip.Items.Add(filter);
        }

        private void waveFormClicked(object sender, EventArgs e)
        {
            if (isWaveFormOpen == false)
            {
                isWaveFormOpen = true;
                Waveform wave = new Waveform();
                wave.Show();
                wave.FormClosed += (obj, args) => isWaveFormOpen = false;
            }
            else
            {
                return;
            }
        }

        private void Onload(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();

            for (var i = 0; i < numberChannels; i++)
            {
                ZedGraphControl graph = new ZedGraphControl();
                graph.ContextMenuBuilder +=
                    new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
                GraphPane pane = graph.GraphPane;
                pane.XAxis.Title.Text = "";
                pane.YAxis.Title.Text = "";
                pane.Title.Text = channelsNames[i];
                pane.Title.FontSpec.IsBold = false;
                pane.Title.FontSpec.Size = 34;
                PointPairList list = new PointPairList();
                double time = discreteRate;
                if (numberChannels * numberCount > 100000)
                {
                    for (int j = 12; j < (numberCount - 12) / numberChannels; j += 3)
                    {
                        string[] fileSplit = fileData[j].Split(' ');
                        string coordinate = fileSplit[i].Replace('.', ',');
                        list.Add(time, Convert.ToDouble(coordinate));
                        time += discreteRate;
                    }
                }
                else
                {
                    for (int j = 12; j < numberCount - 12; j++)
                    {
                        string[] fileSplit = fileData[j].Split(' ');
                        string coordinate = fileSplit[i].Replace('.', ',');
                        list.Add(j - 12, Convert.ToDouble(coordinate));
                    }
                }
                LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.None);
                pane.YAxis.MajorGrid.IsZeroLine = false;
                graph.AxisChange();
                graph.Invalidate();
                fPanel.Controls.Add(graph);
            }
        }

        private void Channels_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;

        }
    }
}
