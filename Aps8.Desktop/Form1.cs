using Aps8.Desktop.Models;
using Newtonsoft.Json;

namespace Aps8.Desktop
{
    public partial class Form1 : Form
    {
        public string url = "https://localhost:40000/api/cidades";

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private async void btnNovaCidade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                return;
            }

            await AddCidade(txbNome.Text);

            CarregarDados();
        }

        private async void btnExcluirCidade_Click(object sender, EventArgs e)
        {
            if (lsvCidades.Items.Count > 0)
            {
                ListViewItem itemSelecionado = lsvCidades.SelectedItems[0];

                await DelCidade(itemSelecionado.Text);

                CarregarDados();
            }
        }

        #region Métodos Privados/Auxiliares
        public async void CarregarDados()
        {
            lsvCidades.Items.Clear();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Cidade> cidades = JsonConvert.DeserializeObject<List<Cidade>>(responseBody);

                    foreach (var cidade in cidades)
                    {
                        ListViewItem item = new ListViewItem(cidade.Id.ToString());
                        item.SubItems.Add(cidade.Nome);

                        lsvCidades.Items.Add(item);
                    }
                }
                else
                {
                    Console.WriteLine($"Falha na solicitação GET. Código de status: {response.StatusCode}");
                }
            }
        }

        public async Task AddCidade(string cidade)
        {
            using (HttpClient client = new HttpClient())
            {
                var urlFull = $"{url}?nome={cidade}";

                HttpResponseMessage response = await client.PostAsync(urlFull, null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Solicitação POST bem-sucedida. Resposta do servidor: " + responseBody);
                }
                else
                {
                    Console.WriteLine($"Falha na solicitação POST. Código de status: {response.StatusCode}");
                    Console.WriteLine("Conteúdo da resposta: " + await response.Content.ReadAsStringAsync());
                }
            }
        }

        private async Task DelCidade(string id)
        {
            var urlFull = $"{url}/{id}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(urlFull);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Solicitação DELETE bem-sucedida!");
                }
                else
                {
                    Console.WriteLine($"Falha na solicitação DELETE. Código de status: {response.StatusCode}");
                }
            }
        }
        #endregion
    }
}