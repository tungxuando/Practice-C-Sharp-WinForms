using System.Data;
using System.Windows.Forms;

namespace CSharpAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void addTaxiButton_Click(object sender, EventArgs e)
        {
            decimal taxiId = numericUpDown_taxiId.Value;
            try
            {
                Company company = new Company();
                Taxi taxi = new Taxi(taxiId);
                company.addTaxi(taxi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal taxiId = numericUpDown_taxiId_home.Value;
            DateTime startTime = dateTimePicker_startTime.Value;
            DateTime endTime = dateTimePicker_endTime.Value;
            DayOfWeek dayOfWeek = dateTimePicker_dayOfWeek.Value.DayOfWeek;
            decimal distance = numericUpDown_distance.Value;

            try
            {
                Company company = new Company();
                Taxi taxi = new Taxi(taxiId);

                Journey journey = new Journey(taxi, startTime, endTime, dayOfWeek, distance);
                company.addJourney(journey);

                amount.Text = calculateAmount(journey).ToString();

                totalIncome.Text = calculateTotalIncome().ToString();

                averageDistance.Text = calculateAverageDistance().ToString();

                longestDistance.Text = calculateLongestDistance().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private decimal calculateAmount(Journey journey)
        {
            decimal amount;
            amount = journey.Distance * 0.5m;

            decimal totalMinute = (decimal)(journey.EndTime - journey.StartTime).TotalMinutes;
            amount += totalMinute * 0.17m;

            if (journey.DayOfWeek == DayOfWeek.Friday || journey.DayOfWeek == DayOfWeek.Saturday ||
                journey.DayOfWeek == DayOfWeek.Sunday)
            {
                if (journey.StartTime.Hour >= 22 || journey.StartTime.Hour <= 7)
                {
                    amount += amount * 15 / 100;
                }
            }

            return amount;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            averageDistance.Text = calculateAverageDistance().ToString();
            totalIncome.Text = calculateTotalIncome().ToString();
            longestDistance.Text = calculateLongestDistance().ToString();
        }

        private decimal calculateTotalIncome()
        {
            decimal totalIncome = 0;
            Company company = new Company();
            foreach (Journey journey in company.JourneyList)
            {
                totalIncome += calculateAmount(journey);
            }

            return totalIncome;
        }

        private decimal calculateAverageDistance()
        {
            decimal totalDistance = 0;
            decimal averageDistance = 0;
            Company company = new Company();
            if (company.JourneyList.Count > 0)
            {
                foreach (Journey journey in company.JourneyList)
                {
                    totalDistance += journey.Distance;
                }

                return averageDistance = totalDistance / company.JourneyList.Count;
            }
            else
            {
                return 0;
            }
        }

        private decimal calculateLongestDistance()
        {
            decimal longestDistance = 0;
            Company company = new Company();
            foreach (Journey journey in company.JourneyList)
            {
                if (journey.Distance > longestDistance)
                {
                    longestDistance = journey.Distance;
                }
            }

            return longestDistance;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "journeyOverview.csv";
            string content = "CarId; StartTime; EndTime; DayOfWeek; Distance; Amount\n";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }

                Company company = new Company();
                foreach (Journey journey in company.JourneyList)
                {
                    content +=
                        $"{journey.Taxi.TaxiId}; {journey.StartTime.Hour}:{journey.StartTime.Minute}; {journey.EndTime.Hour}:{journey.EndTime.Minute}; {journey.DayOfWeek}; {journey.Distance}; {calculateAmount(journey)}\n";
                }

                File.WriteAllText(path, content);
                MessageBox.Show("File exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };
            if (fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                readCSV(fileDialog);
            }
            else
            {
                MessageBox.Show("Please select a valid file before continuing!");
            }
        }

        private string mostActiveStartTime()
        {
            int highestCount = 0;

            Dictionary<string, int> timeCount = new Dictionary<string, int>();
            List<string> highestTimes = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var time = row.Cells[1].Value.ToString();


                if (timeCount.ContainsKey(time))// if the time is not in the dictionary, then add it and set the count to 1
                {
                    timeCount[time] += 1; //select time and +1 to value int
                    int currentCount = timeCount[time]; //timeCount[time] return the value of the key time

                    //if the current count is higher than the highest count, then set the highest count to the current count and clear the list and add the time to the list
                    //so there will always 1 highest time inside highestTimes list
                    //except when two times occurs the same times
                    if (currentCount > highestCount)
                    {
                        highestCount = currentCount;
                        highestTimes.Clear();
                        highestTimes.Add(time);
                    }
                    else if (currentCount == highestCount)
                    {
                        highestTimes.Add(time);
                    }
                }
                else
                {
                    timeCount.Add(time, 1);
                }
            }

            return string.Join(", ", highestTimes);
        }


        private void readCSV(FileDialog fileDialog)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (StreamReader streamReader = new StreamReader(fileDialog.FileName))
                {
                    bool firstRow = true;
                    while (!streamReader.EndOfStream)
                    {
                        string[] rows = streamReader.ReadLine().Split(';');
                        if (firstRow)
                        {
                            foreach (string header in rows)
                            {
                                dataTable.Columns.Add(header);
                            }

                            firstRow = false;
                        }
                        else
                        {
                            dataTable.Rows.Add(rows);
                        }
                    }
                }
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count < 4 || selectedRows.Count > 10)
            {
                MessageBox.Show("Please select 5 to 10 journeys!");
                return;
            }

            if (mostActiveTime_radioButton.Checked)
            {
                result += mostActiveStartTime();
            }

            if (averageTimeLength_radioButton.Checked)
            {
                result += averageTimeLength();
            }

            if (bestEarningDay_radioButton.Checked)
            {
                result += bestEarningDay();
            }

            richTextBox1.Text = result;

        }

        private string bestEarningDay()
        {
            Dictionary<string, decimal> earningPerDay = new Dictionary<string, decimal>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var day = row.Cells[3].Value.ToString();
                var amount = decimal.Parse(row.Cells[5].Value.ToString());

                if (earningPerDay.ContainsKey(day))
                {
                    earningPerDay[day] += amount;
                }
                else
                {
                    earningPerDay.Add(day, amount);
                }
            }

            decimal highestEarning = 0;
            string bestDay = "";
            foreach (KeyValuePair<string, decimal> pair in earningPerDay)
            {
                if (pair.Value > highestEarning)
                {
                    highestEarning = pair.Value;
                    bestDay = pair.Key;
                }
            }

            return $"Best earning day: {bestDay} with {highestEarning}";
        }

        private string averageTimeLength()
        {
            int totalMinutes = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var stringStartTime = row.Cells[1].Value.ToString();
                var stringEndTime = row.Cells[2].Value.ToString();

                String[] startTime = stringStartTime.Split(':');
                int startHour = int.Parse(startTime[0]);
                int startMinute = int.Parse(startTime[1]);

                String[] endTime = stringEndTime.Split(':');
                int endHour = int.Parse(endTime[0]);
                int endMinute = int.Parse(endTime[1]);

                int elapsedMinute = (endHour - startHour) * 60 + (endMinute - startMinute);
                totalMinutes += elapsedMinute;
            }
            int averageMinutes = totalMinutes / dataGridView1.SelectedRows.Count;
            return $"{averageMinutes / 60} hours and {averageMinutes % 60} minutes";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void addTaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}