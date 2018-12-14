using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            string urlContents = client.GetStringAsync("http://msdn.microsoft.com")
                .GetAwaiter().GetResult();

            MessageBox.Show($"Tamanho da página: {urlContents.Length}");
        }

        private async void BtnAsync_Click(object sender, EventArgs e)
        {
            var tamanho = await AcessaAWebAsync();
            MessageBox.Show($"Tamanho da página: {tamanho}");
        }

        private async Task<int> AcessaAWebAsync()
        {
            HttpClient client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            string urlContents = await getStringTask;

            return urlContents.Length;
        }
    }
}
