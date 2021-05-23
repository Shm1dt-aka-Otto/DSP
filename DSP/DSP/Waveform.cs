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
    public partial class Waveform : Form
    {
        int numberChannels, numberGraph, numberCount, currentNumber = 0;
        double discreteRate;
        PointPairList[] stack;
        string[] names, fileData;
        ZedGraphControl zedGraph = new ZedGraphControl();
        GraphPane p;

        public Waveform(PointPairList[] list, string[] channels, int number, int currentNumber,
            string[] file, double rate, int count)
        {
            InitializeComponent();
            numberChannels = number;
            numberGraph = currentNumber;
            numberCount = count;
            stack = new PointPairList[number];
            names = channels;
            stack = list;
            discreteRate = rate;
            fileData = file;
        }

        private void Waveform_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
            CreateGraph();
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
            ToolStripItem spectrFurie = new ToolStripMenuItem("Спектр Фурье");
            menuStrip.Items.Add(spectrFurie);
            ToolStripItem waveLetogramm = new ToolStripMenuItem("Вейвлетограмма");
            menuStrip.Items.Add(waveLetogramm);
            ToolStripItem spectrGramm = new ToolStripMenuItem("Спектрограмма");
            menuStrip.Items.Add(spectrGramm);
            ToolStripItem correlation = new ToolStripMenuItem("Корреляция с ...");
            menuStrip.Items.Add(correlation);
            ToolStripItem crossSpectrum = new ToolStripMenuItem("Кросс-спектр с ...");
            menuStrip.Items.Add(crossSpectrum);
            ToolStripItem close = new ToolStripMenuItem("Закрыть");
            menuStrip.Items.Add(close);
            close.Click += new EventHandler(closeClicked);
            ToolStripItem localView = new ToolStripMenuItem("Локальный масштаб");
            menuStrip.Items.Add(localView);
            localView.Click += new EventHandler(localViewClicked);
            ToolStripItem globalView = new ToolStripMenuItem("Глобальный масштаб");
            menuStrip.Items.Add(globalView);
            ToolStripItem selectView = new ToolStripMenuItem("Задать масштаб");
            menuStrip.Items.Add(selectView);
            ToolStripItem absoluteLocalView = new ToolStripMenuItem("Единый локальный масштаб");
            menuStrip.Items.Add(absoluteLocalView);
            ToolStripItem absoluteGlobalView = new ToolStripMenuItem("Единый глобальный масштаб");
            menuStrip.Items.Add(absoluteGlobalView);
            ToolStripItem graphic = new ToolStripMenuItem("Графики");
            menuStrip.Items.Add(graphic);
        }

        private void coordinateBox_CheckedChanged(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void linearBox_CheckedChanged(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void circleBox_CheckedChanged(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void closeClicked(object sender, EventArgs e)
        {
            graphPanel.Controls.Remove(zedGraph as Control);
            if (graphPanel.Controls.Count == 0)
            {
                this.Close();
            }
        }

        private void localViewClicked(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        public void CreateGraph()
        {
            graphPanel.Controls.Clear();
            for (var i = 0; i < numberChannels; i++)
            {
                if (i > numberGraph)
                {
                    break;
                }
                ZedGraphControl graph = new ZedGraphControl();
                graph.ContextMenuBuilder +=
                    new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
                graph.Size = new Size(781, 200);
                if (i == 0)
                {
                    graph.Location = new Point(0, 0);
                }
                else
                {
                    graph.Location = new Point(0, 200 * i);
                }
                graph.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                GraphPane pane = graph.GraphPane;
                p = pane;
                if (linearBox.Checked == true || circleBox.Checked == true)
                {
                    if (circleBox.Checked == true && linearBox.Checked == true)
                    {
                        double time = discreteRate;
                        PointPairList list = new PointPairList();
                        if (numberCount >= 100000)
                        {
                            for (int j = 12; j < numberCount - 12; j += 10)
                            {
                                if (j >= numberCount - 12)
                                {
                                    break;
                                }
                                string[] fileSplit = fileData[j].Split(' ');
                                string coordinate = fileSplit[0].Replace('.', ',');
                                list.Add(time, Convert.ToDouble(coordinate));
                                time += discreteRate * 10;
                            }
                        }
                        else
                        {
                            for (int j = 12; j < numberCount - 12; j += 5)
                            {
                                if (j >= numberCount - 12)
                                {
                                    break;
                                }
                                string[] fileSplit = fileData[j].Split(' ');
                                string coordinate = fileSplit[0].Replace('.', ',');
                                list.Add(time, Convert.ToDouble(coordinate));
                                time += discreteRate * 5;
                            }
                        }
                        LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.Circle);
                    }
                    else if (circleBox.Checked == true && linearBox.Checked == false)
                    {
                        LineItem myCurve = pane.AddCurve("", stack[i], Color.Blue, SymbolType.Circle);
                        myCurve.Symbol.Size = 10.0F;
                    }
                    else if (linearBox.Checked == true && circleBox.Checked == false)
                    {
                        double time = discreteRate;
                        PointPairList list = new PointPairList();
                        if (numberCount >= 100000)
                        {
                            for (int j = 12; j < numberCount - 12; j += 10)
                            {
                                if (j >= numberCount - 12)
                                {
                                    break;
                                }
                                string[] fileSplit = fileData[j].Split(' ');
                                string coordinate = fileSplit[0].Replace('.', ',');
                                list.Add(time, Convert.ToDouble(coordinate));
                                time += discreteRate * 10;
                            }
                        }
                        else
                        {
                            for (int j = 12; j < numberCount - 12; j += 5)
                            {
                                if (j >= numberCount - 12)
                                {
                                    break;
                                }
                                string[] fileSplit = fileData[j].Split(' ');
                                string coordinate = fileSplit[0].Replace('.', ',');
                                list.Add(time, Convert.ToDouble(coordinate));
                                time += discreteRate * 5;
                            }
                        }
                        LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.None);
                    }
                }
                else
                {
                    LineItem myCurve = pane.AddCurve("", stack[i], Color.Blue, SymbolType.None);
                }
                if (coordinateBox.Checked == true)
                {
                    pane.XAxis.MajorGrid.IsVisible = true;
                    pane.YAxis.MajorGrid.IsZeroLine = true;
                }
                else
                {
                    pane.XAxis.MajorGrid.IsVisible = false;
                    pane.YAxis.MajorGrid.IsZeroLine = false;
                }
                pane.XAxis.Title.Text = "";
                pane.YAxis.Title.Text = "";
                pane.IsBoundedRanges = true;
                pane.YAxis.Scale.MinAuto = true;
                pane.YAxis.Scale.MaxAuto = true;
                pane.XAxis.Scale.MinAuto = true;
                pane.XAxis.Scale.MaxAuto = true;
                pane.XAxis.Title.IsVisible = false;
                pane.YAxis.Title.IsVisible = false;
                pane.Title.Text = names[i];
                pane.Title.FontSpec.IsBold = false;
                pane.Title.FontSpec.Size = 34;
                graph.IsShowPointValues = true;
                graph.AxisChange();
                graph.Invalidate();
                graphPanel.Controls.Add(graph);
            }
        }
    }
}
