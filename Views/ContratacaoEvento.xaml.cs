using MauiAppEvento.Models;
using MauiAppEvento.Views;

namespace MauiAppEvento.Views;

public partial class ContratacaoEvento : ContentPage
{
	public Evento Evento { get; set; } = new Evento
	{
        DataInicio = DateTime.Today,
        DataTermino = DateTime.Today
    };
	public ContratacaoEvento()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventoContratado(Evento));
    }
}