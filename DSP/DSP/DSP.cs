using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP
{
    public partial class DSP : Form
    {
        bool isChannalsOpen = false, isInfoOpen = false;
        int numberOfChannels = 0, numberOfCount = 0;
        DateTime dateRecord, timeRecord;
        string[] nameOfChannels, miliSeconds, fileSource;
        string fileName = "", fileShortName = "";
        double rateDiscret = 0, sampleRate = 0;
        Channels channels;
        Info info;

        public DSP()
        {
            InitializeComponent();
        }

        private void aboutMenuTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программу DSP разработали:\n" +
                "Сибен Андрей, Сосновская Ксения,\n" +
                "Гринёв Максим, Одновил Евгений\n" +
                "Разработанные функции:\n" +
                "1) Навигационное меню\n" +
                "2) Окно сигналов\n" +
                "3) Анализ сигналов\n" +
                "4) Осцилограмма\n",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void aboutSignalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChannalsOpen == true && isInfoOpen == false)
            {
                isInfoOpen = true;
                info = new Info(numberOfChannels, numberOfCount, rateDiscret, sampleRate, dateRecord,
                timeRecord, miliSeconds, nameOfChannels, fileShortName, fileSource);
                info.Show();
                info.FormClosed += (obj, args) => isInfoOpen = false;
            }
            else if (isChannalsOpen == false && isInfoOpen == false)
            {
                return;
            }
            else
            {
                info.Close();
                isInfoOpen = true;
                info = new Info(numberOfChannels, numberOfCount, rateDiscret, sampleRate, dateRecord,
                timeRecord, miliSeconds, nameOfChannels, fileShortName, fileSource);
                info.Show();
                info.FormClosed += (obj, args) => isInfoOpen = false;
            }
        }

        private void TxtFile(string file)
        {
            string[] fileDataSplit = file.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); 
            if (isChannalsOpen == false)
            {
                numberOfChannels = Convert.ToInt32(fileDataSplit[1]);
                numberOfCount = Convert.ToInt32(fileDataSplit[3]);
                sampleRate = Convert.ToDouble(fileDataSplit[5].Replace('.', ','));
                rateDiscret = 1 / sampleRate;
                string[] tempDate = fileDataSplit[7].Split('-');
                dateRecord = new DateTime(Convert.ToInt32(tempDate[2]), Convert.ToInt32(tempDate[1]),
                    Convert.ToInt32(tempDate[0]));
                string[] tempTime = fileDataSplit[9].Split(':');
                miliSeconds = tempTime[2].Split('.');
                if (miliSeconds.Length < 2)
                {
                    string[] add = new string[] { "0", "000" };
                    miliSeconds = add;
                }
                timeRecord = new DateTime(2021, 9, 4, Convert.ToInt32(tempTime[0]), Convert.ToInt32(tempTime[1]),
                    Convert.ToInt32(miliSeconds[0]));
                nameOfChannels = fileDataSplit[11].Split(';');
                fileSource = fileDataSplit[11].Split(';');
                string[] subtract = fileName.Split('\\');
                int length = subtract.Length;
                fileShortName = subtract[length - 1];
                for (int i = 0; i < numberOfChannels; i++)
                    fileSource[i] = "Файл: " + fileShortName;
                isChannalsOpen = true;
                channels = new Channels(numberOfChannels, numberOfCount, rateDiscret, sampleRate, fileDataSplit,
                    nameOfChannels);
                if (isInfoOpen == false) { }
                else
                {
                    info.Close();
                    isInfoOpen = true;
                    info = new Info(numberOfChannels, numberOfCount, rateDiscret, sampleRate, dateRecord,
                    timeRecord, miliSeconds, nameOfChannels, fileShortName, fileSource);
                    info.Show();
                    info.FormClosed += (obj, args) => isInfoOpen = false;
                }
                channels.Show();
                channels.FormClosed += (obj, args) => isChannalsOpen = false;
            }
            else
            {
                numberOfChannels = Convert.ToInt32(fileDataSplit[1]);
                numberOfCount = Convert.ToInt32(fileDataSplit[3]);
                sampleRate = Convert.ToDouble(fileDataSplit[5].Replace('.', ','));
                rateDiscret = 1 / sampleRate;
                string[] tempDate = fileDataSplit[7].Split('-');
                dateRecord = new DateTime(Convert.ToInt32(tempDate[2]), Convert.ToInt32(tempDate[1]),
                    Convert.ToInt32(tempDate[0]));
                string[] tempTime = fileDataSplit[9].Split(':');
                miliSeconds = tempTime[2].Split('.');
                if (miliSeconds.Length < 2)
                {
                    string[] add = new string[] { "0", "000" };
                    miliSeconds = add;
                }
                timeRecord = new DateTime(2021, 9, 4, Convert.ToInt32(tempTime[0]), Convert.ToInt32(tempTime[1]),
                    Convert.ToInt32(miliSeconds[0]));
                nameOfChannels = fileDataSplit[11].Split(';');
                fileSource = fileDataSplit[11].Split(';');
                string[] subtract = fileName.Split('\\');
                int length = subtract.Length;
                fileShortName = subtract[length - 1];
                for (int i = 0; i < numberOfChannels; i++)
                    fileSource[i] = "Файл: " + fileShortName;
                channels.Close();
                isChannalsOpen = true;
                channels = new Channels(numberOfChannels, numberOfCount, rateDiscret, sampleRate, fileDataSplit,
                    nameOfChannels);
                if (isInfoOpen == false) { }
                else
                {
                    info.Close();
                    isInfoOpen = true;
                    info = new Info(numberOfChannels, numberOfCount, rateDiscret, sampleRate, dateRecord,
                    timeRecord, miliSeconds, nameOfChannels, fileShortName, fileSource);
                    info.Show();
                    info.FormClosed += (obj, args) => isInfoOpen = false;
                }
                channels.Show();
                channels.FormClosed += (obj, args) => isChannalsOpen = false;
            }
        }

        private void openFileTool_Click(object sender, EventArgs e)
        {
            string fileText = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовый файл (*.txt)|*.txt|" +
                "DAT-файл (*.dat)|*.dat|" +
                "Файл аудиопотока (*.wav)|*.wav|" +
                "Звуковой файл (*.mp3)|*.mp3|" +
                "Видео файл (*.avi)|*.avi|" +
                "Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = dialog.FileName;
                StreamReader fileStream = new StreamReader(fileName, Encoding.GetEncoding(1251));
                string fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".txt")
                {
                    fileText = fileStream.ReadToEnd();
                    TxtFile(fileText);
                }
            }
        }

        private void DSP_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
