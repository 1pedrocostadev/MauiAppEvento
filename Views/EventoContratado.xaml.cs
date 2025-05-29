using MauiAppEvento.Models;

namespace MauiAppEvento.Views;

public partial class EventoContratado : ContentPage
{
	public EventoContratado(Evento evento)
	{
		InitializeComponent();
        BindingContext = evento;

    }
}