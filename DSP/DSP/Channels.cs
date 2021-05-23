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
        int numberChannels, numberCount, currentNumber = 0, number = 0;
        double discreteRate, rateSignal;
        string[] channelsNames, fileData;
        bool isWaveFormOpen = false;
        PointPairList[] stack;
        Waveform wave;
        ZedGraphControl zedGraph = new ZedGraphControl();

        public Channels(int numberOfChannels, int numberOfCount,
                double rateDiscret, double sampleRate, string[] fileDateSplit, 
                string[] nameOfChannels)
        {
            discreteRate = rateDiscret;
            numberChannels = numberOfChannels;
            numberCount = numberOfCount;
            fileData = fileDateSplit;
            this.Load += Onload;
            InitializeComponent();
            numberChannels = numberOfChannels;
            numberCount = numberOfCount;
            rateSignal = sampleRate;
            discreteRate = rateDiscret;
            channelsNames = nameOfChannels;
            fileData = fileDateSplit;
            stack = new PointPairList[numberOfChannels];
        }

        void zedGraph_ContextMenuBuilder(ZedGraphControl sender,
        ContextMenuStrip menuStrip,
        Point mousePt,
        ZedGraphControl.ContextMenuObjectState objState)
        {
            zedGraph = sender;
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
            hide.Click += new EventHandler(hideClicked);
            ToolStripItem hideAll = new ToolStripMenuItem("Скрыть все, кроме этого");
            menuStrip.Items.Add(hideAll);
            ToolStripItem showAll = new ToolStripMenuItem("Показать все");
            menuStrip.Items.Add(showAll);
            ToolStripItem filter = new ToolStripMenuItem("Фильтрация");
            menuStrip.Items.Add(filter);
        }

        private void waveFormClicked(object sender, EventArgs e)
        {
            if (number == numberChannels)
            {
                return;
            }
            if (isWaveFormOpen == false)
            {
                isWaveFormOpen = true;
                wave = new Waveform(stack, channelsNames, numberChannels, number, fileData,
                    discreteRate, numberCount);
                number = number + 1;
                wave.Show();
                wave.FormClosed += (obj, args) =>
                {
                    isWaveFormOpen = false;
                    number = 0;
                };
            }
            else
            {
                wave.Close();
                wave = new Waveform(stack, channelsNames, numberChannels, number, fileData,
                    discreteRate, numberCount);
                number = number + 1;
                wave.Show();
                wave.FormClosed += (obj, args) =>
                {
                    isWaveFormOpen = true;
                    number = 0;
                };
            }
        }

        private void hideClicked(object sender, EventArgs e)
        {
            zedGraph.Visible = false;
        }
        private void Onload(object sender, EventArgs e)
        {
            this.Controls.Clear();
            for (var i = 0; i < numberChannels; i++)
            {
                ZedGraphControl graph = new ZedGraphControl();
                graph.ContextMenuBuilder +=
                    new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
                graph.Size = new Size(221, 127);
                if (currentNumber == 0)
                {
                    graph.Location = new Point(0, 0);
                }
                else
                {
                    graph.Location = new Point(0, 126 * currentNumber);
                }
                graph.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                currentNumber = currentNumber + 1;
                GraphPane pane = graph.GraphPane;
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
                        list.Add(time, Convert.ToDouble(coordinate));
                        time += discreteRate;
                    }
                }
                LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.None);
                stack[i] = list;
                pane.IsBoundedRanges = true;
                pane.YAxis.Scale.MinAuto = true;
                pane.YAxis.Scale.MaxAuto = true;
                pane.XAxis.Scale.MinAuto = true;
                pane.XAxis.Scale.MaxAuto = true;
                pane.YAxis.MajorGrid.IsZeroLine = false;
                pane.XAxis.Title.Text = "";
                pane.YAxis.Title.Text = "";
                pane.XAxis.Title.IsVisible = false;
                pane.YAxis.Title.IsVisible = false;
                pane.Title.Text = channelsNames[i];
                pane.Title.FontSpec.IsBold = false;
                pane.Title.FontSpec.Size = 34;
                graph.AxisChange();
                graph.Invalidate();
                this.Controls.Add(graph);
            }
        }

        private void Channels_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
            this.Location = new Point(1274, 0);

        }
    }
}
