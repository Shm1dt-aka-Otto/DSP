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
    public partial class Info : Form
    {
        public Info(int numberOfChannels, int numberOfCount,
                double rateDiscret, double sampleRate, DateTime dateRecord,
                DateTime timeRecord, string[] miliSeconds, string[] nameOfChannels, string fileName,
                string[] fileSource)
        {
            InitializeComponent();
            numberOfChannelsLabel.Text = "Общее число каналов - " + numberOfChannels.ToString();
            numberOfCountLabel.Text = "Общее количество отсчетов – " + numberOfCount.ToString();
            rateDiscretLabel.Text = "Частота дискретизации – " + sampleRate.ToString() + " Гц" +
                " ( шаг между отсчетами " + rateDiscret.ToString() + " сек)";
            dateRecordLabel.Text = "Дата и время начала записи - " + dateRecord.ToShortDateString() + " " +
                timeRecord.ToLongTimeString() + "." + miliSeconds[1].ToString();
            string[] newClock = timeRecord.ToString().Split(' ');
            string[] newTime = newClock[1].Split(':');
            string[] newClockDay = dateRecord.ToString().Split(' ');
            string[] newDay = newClockDay[0].Split('.');
            DateTime newDate = new DateTime(Convert.ToInt32(newDay[2]), Convert.ToInt32(newDay[1]),
                Convert.ToInt32(newDay[0]), Convert.ToInt32(newTime[0]), Convert.ToInt32(newTime[1]),
                Convert.ToInt32(newTime[2]));
            dateEndLabel.Text = "Дата и время окончания записи - " + newDate.AddSeconds(Convert.ToInt32(numberOfCount 
                * rateDiscret)).ToString()+ "." + miliSeconds[1];
            DateTime subtractDate = new DateTime(Convert.ToInt32(newDay[2]), Convert.ToInt32(newDay[1]),
                Convert.ToInt32(newDay[0]), Convert.ToInt32(newTime[0]), Convert.ToInt32(newTime[1]),
                Convert.ToInt32(newTime[2]));
            string difference = newDate.AddSeconds(Convert.ToInt32(numberOfCount
                * rateDiscret)).Subtract(subtractDate).ToString();
            string[] range = difference.Split(':');
            string[] correct = range[0].Split('.');
            if (correct.Length > 1)
            {
                summaryLabel.Text = "Длительность: " + correct[0] + " – суток, " + correct[1] +
                " – часов, " + range[1] + " – минут, " + range[2] + "." + miliSeconds[1] + " - секунд";
            }
            else 
            {
                int day = Convert.ToInt32(range[0]) / 24;
                summaryLabel.Text = "Длительность: " + day + " – суток, " + (Convert.ToInt32(range[0]) - day * 24)
                    + " – часов, " + range[1] + " – минут, " + range[2] + "." + miliSeconds[1] + " - секунд";
            }
            for (int i = 0; i < numberOfChannels; i++)
            {
                infoGridView.Rows.Add(i + 1, nameOfChannels[i], fileSource[i]);
            }
            activeLabel.Text = "Активный фрагмент: [начальный отсчет, конечный отсчет], " + numberOfCount;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            MdiParent = Form.ActiveForm;
        }
    }
}
