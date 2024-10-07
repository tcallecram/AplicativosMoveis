namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOKClicked(object sender, EventArgs e)
        {
            string id = entryID.Text;
            string senha = entrySenha.Text;

            if (id == "admin" && senha == "1234")
            {
                DisplayAlert("Login", "Logado com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login não autorizado!", "OK");
            }
        }

        private void OnLimparClicked(object sender, EventArgs e)
        {
            entryID.Text = string.Empty;
            entrySenha.Text = string.Empty;
            entryID.Focus();
        }

        private void OnCreditoClicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Autores: Marcella Tavares, Victoria Andraus", "OK");
        }
    }

}