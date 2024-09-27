﻿namespace JOGODOMILIAO;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
		gerenciador = ProximaPergunta();
	}

    private Gerenciador ProximaPergunta()
    {
        throw new NotImplementedException();
    }

    void OnButtonResposta1Clicked(object sender, EventArgs args)
	{
		gerenciador.VerficaResposta (1);
	}

	
	void OnButtonResposta2Clicked(object sender, EventArgs  args)
	{
		gerenciador.VerficaResposta (2);
	}

	void OnButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerficaResposta (3);
	}

	void OnButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerficaResposta (4);
	}

	void OnButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerficaResposta (5);
	}

}