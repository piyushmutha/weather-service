using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherService.Interfaces;

namespace WeatherService
{
    public partial class Form1 : Form
    {
        private IEnumerable<ICity> Cities { get; set; }
        private IList<ICityWeather> CityWeathers { get; set; } = new List<ICityWeather>();
        private delegate void Progress(int count);
        private Progress progress;
        private CancellationTokenSource CancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Controls.Add(lblProgress);
            lblProgress.Location = new Point(progressBar1.Width / 2 - lblProgress.Width / 2, progressBar1.Height / 2 - lblProgress.Height / 2);
            progress = new Progress(ProgressHandler);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cities = Factory.GetCities();
            DGVCities.DataSource = Cities.ToList();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            switchButtons(true);
            progressBar1.Maximum = Cities.Count();
            CancellationTokenSource = new CancellationTokenSource();
            int i = 0;
            await Task.Run(() =>
            {
                try
                {
                    ParallelOptions parallelOptions = new ParallelOptions()
                    {
                        MaxDegreeOfParallelism = 2000,
                        CancellationToken = CancellationTokenSource.Token
                    };
                    Parallel.ForEach(Cities, parallelOptions, (city, loop) =>
                      {
                          DGVCities.Rows[i++].Selected = true;
                          CityWeathers.Add(Factory.newApiHandler().GetCityWeather(city.id));
                          this.Invoke(progress, i);
                          if (parallelOptions.CancellationToken.IsCancellationRequested)
                              loop.Break();
                          DGVCities.Rows[i++].Selected = false;
                      });
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CancellationTokenSource.Dispose();
                    Save();
                }
            });
            switchButtons(false);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Stop Task?", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                CancellationTokenSource.Cancel();
            }
        }

        private void Save()
        {
            var persistence = Factory.newPersistence();

            if (persistence.Create(CityWeathers, DateTime.Today))
                MessageBox.Show("Data Saved!");
            else MessageBox.Show("Error occured while saving data!");
        }

        private void ProgressHandler(int count)
        {
            lblProgress.Text = $"{count}/{Cities.Count()}";
            progressBar1.PerformStep();
            
            if (DGVCities.SelectedRows.Count > 0)
                DGVCities.FirstDisplayedScrollingRowIndex = DGVCities.SelectedRows[0].Index;
        }

        private void switchButtons(bool taskStatus)
        {
            btnStart.Enabled = !taskStatus;
            btnStop.Enabled = taskStatus;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            var persistence = Factory.newPersistence();
            var cityWeathers = persistence.GetCityWeathers(dateTimePicker1.Value);
            DGVHistory.DataSource = cityWeathers.ToDataTable();
        }
    }
}
