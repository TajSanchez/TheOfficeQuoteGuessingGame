using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace TheOfficeQuoteGuessingGameDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var address = new Uri("https://the-office.fly.dev/season/1/format/quotes");

            var data = client.GetStringAsync(address).Result;

            List<EpisodeData> episodeData = JsonSerializer.Deserialize<List<EpisodeData>>(data, 
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true}) ?? new List<EpisodeData>();


            var rando = new Random();
            TextBox.Text = episodeData[rando.Next(episodeData.Count)].Quote;
        }

        
    }
}