namespace MauiAppHotel.Views{

    public partial class HistoricoHospedagem : ContentPage
    {
     public HistoricoHospedagem()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratacaoHospedagem());
        }
    }
}