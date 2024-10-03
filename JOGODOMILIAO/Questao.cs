namespace JOGODOMILHAO
{

    public class Questao
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCorreta;
        public int NíveldaPergunta;
        private Label LabelPergunta;
        private Button ButtonResposta1;
        private Button ButtonResposta2;
        private Button ButtonResposta3;
        private Button ButtonResposta4;
        private Button ButtonResposta5;

        public void ConfiguraDesenha(Label LabelPergunta, Button Button1, Button Button2,Button Button3,Button Button4,Button Button5)
        {
            LabelPergunta = LabelPergunta;
            ButtonResposta1 = ButtonResposta1;
            ButtonResposta2 = ButtonResposta2;
            ButtonResposta3 = ButtonResposta3;
            ButtonResposta4 = ButtonResposta4;
            ButtonResposta5 = ButtonResposta5;
        }
        public void Desenha()
        {
            LabelPergunta = LabelPergunta;
            ButtonResposta1 = ButtonResposta1;
            ButtonResposta2 = ButtonResposta2;
            ButtonResposta3 = ButtonResposta3;
            ButtonResposta4 = ButtonResposta4;
            ButtonResposta5 = ButtonResposta5;
            ButtonResposta1.IsVisible = true;
            ButtonResposta2.IsVisible = true;
            ButtonResposta3.IsVisible = true;
            ButtonResposta4.IsVisible = true;
            ButtonResposta5.IsVisible = true;

        }
        private Button QualButton(int VerificaResposta)
        {
            if (VerificaResposta == 1)
                return ButtonResposta1;
            else if (VerificaResposta == 2)
                return ButtonResposta2;
            else if (VerificaResposta == 3)
                return ButtonResposta3;
            else if (VerificaResposta == 4)
                return ButtonResposta4;
            else if (VerificaResposta == 5)
                return ButtonResposta5;
            else
                return null;
        }
        public bool  VerificaResposta(int RespostaSelecionada)
        {
            if (RespostaCorreta == RespostaSelecionada)
            {
                var Button = QualButton(RespostaSelecionada);
                Button.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var ButtonCorreto = QualButton(RespostaCorreta);
                var ButtonIncorreto = QualButton(RespostaSelecionada);
                ButtonCorreto.BackgroundColor = Colors.Green;
                ButtonIncorreto.BackgroundColor = Colors.Red;
                return false;
            }
        }

    public Questao()
    {

    }

    public Questao(Label LabelPergunta, Button Button1, Button Button2,Button Button3,Button Button4,Button Button5)
    {
            LabelPergunta = LabelPergunta;
            ButtonResposta1 = ButtonResposta1;
            ButtonResposta2 = ButtonResposta2;
            ButtonResposta3 = ButtonResposta3;
            ButtonResposta4 = ButtonResposta4;
            ButtonResposta5 = ButtonResposta5;
    }
    }

    public class Questao : IEquatable<Questao>
    {
        public bool Equals (Questao q)
        {
            return this.Nivel == q.Nivel &&
                   this.Pergunta == q.Pergunta;
        }
    }
}