//GabdrahmanovRadmir220_MonitoringTemp

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MonitoringTemp
{
    public partial class frmMain : Form
    {
        int[] temperatures;
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int tempMax = Convert.ToInt32(tbMaxTemp.Text);
                int tempMaxTime = Convert.ToInt32(tbMaxTempTime.Text);
                int countMaxTime = 0;
                bool checkMaxTime = true;

                int tempMin = (tbMinTemp.Text != "" ? Convert.ToInt32(tbMinTemp.Text) : 0);
                int tempMinTime = Convert.ToInt32(tbMinTempTime.Text);
                int countMinTime = 0;
                bool checkMinTime = true;

                string[] strDate = tbDateTime.Text.Split('.', ' ', ':');

                int year = int.Parse(strDate[2]);
                int month = int.Parse(strDate[1]);
                int day = int.Parse(strDate[0]);
                int hours = int.Parse(strDate[3]);
                int minutes = int.Parse(strDate[4]);

                temperatures = Array.ConvertAll<string, int>(tbTemperature.Text.Split(',', ' '), int.Parse);

                List<int> temperatureAboveMax = new List<int>();
                List<int> temperatureBelowMin = new List<int>();

                for (int i = 0; i < temperatures.Length; i++)
                {
                    if (tempMax < temperatures[i])
                    {
                        countMaxTime += 10;
                        if (countMaxTime > tempMaxTime) checkMaxTime = false;
                        temperatureAboveMax.Add(temperatures[i]);
                    }

                    if (tempMin > temperatures[i] && tempMinTime != 0)
                    {
                        countMinTime += 10;
                        if (countMinTime > tempMinTime) checkMinTime = false;
                        temperatureBelowMin.Add(temperatures[i]);
                    }
                }

                if (checkMaxTime == false || checkMinTime == false)
                {
                    MessageBox.Show("Нарушение условий хранения!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    saveFileDialog1.ShowDialog();

                    string path = saveFileDialog1.FileName;

                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        if (checkMaxTime == false)
                        {
                            sw.WriteLine($"Порог максимально допустимой температуры превышен на {countMaxTime} минут.");

                            foreach (var item in temperatureAboveMax)
                            {
                                DateTime date = new DateTime(year, month, day, hours, minutes, 0);
                                int timeDeflection = item - tempMax;

                                sw.WriteLine("Время: " + date.ToShortDateString() + " " + date.ToShortTimeString() + " " +
                                    "Факт: " + item.ToString() + " Норма: " + tempMax + " Отклонение: " + timeDeflection);

                                if (date.Minute > 0)
                                {
                                    minutes = date.Minute + (10);
                                    if (minutes >= 60)
                                    {
                                        hours = hours + 1;
                                        minutes -= 60;
                                    }
                                }

                                if (hours > 24)
                                {
                                    day += 1;
                                }
                            }
                        }

                        if (checkMinTime == false)
                        {
                            sw.WriteLine($"Порог минимально допустимой температуры превышен на {countMinTime} минут.");

                            foreach (var item in temperatureBelowMin)
                            {
                                DateTime date = new DateTime(year, month, day, hours, minutes, 0);
                                int timeDeflection = item - tempMin;

                                sw.WriteLine("Время: " + date.ToShortDateString() + " " + date.ToShortTimeString() + " " +
                                    "Факт: " + item.ToString() + " Норма: " + tempMin + " Отклонение: " + timeDeflection);

                                if (date.Minute > 0)
                                {
                                    minutes = date.Minute + (10);

                                    if (minutes >= 60)
                                    {
                                        hours = hours + 1;
                                        minutes -= 60;
                                    }
                                }

                                if (hours > 24)
                                {
                                    day += 1;
                                }
                            }

                        }
                        sw.Close();
                    }
                }

                tbResult.Text = (checkMaxTime == true && checkMinTime == true ? "OK" : LoadReport(saveFileDialog1.FileName));

                if (tbResult.Text == "")
                {
                    tbResult.Text = "ОК: Условия хранения не нарушены";
                }
            }

            catch 
            {
                MessageBox.Show("Неверный ввод данных", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Load(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string temperature = "";
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    temperature += line + "\r\n";
                }
                return temperature;
            }
        }

        public string LoadReport(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string reportData = "";
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    reportData += line + "\r\n";
                }

                return reportData;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDateTemp = Load(openFileDialog1.FileName);
                string[] arrDateTemp = fileDateTemp.Split();

                tbDateTime.Text = arrDateTemp[0] + " " + arrDateTemp[1];

                for (int i = 2; i < arrDateTemp.Length; i++)
                {
                    tbTemperature.Text += arrDateTemp[i] + " ";
                }
                tbTemperature.Text = tbTemperature.Text.Trim();
            }
        }
    }
}
