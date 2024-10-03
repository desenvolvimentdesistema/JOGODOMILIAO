namespace JOGODOMILHAO
{
    public class Gerenciador
    {
        List <Questao> ListaQuestao = new List <Questao>();
        List <int> ListaQuestaoRespondida = new List <int>();
        Questao QuestaoAtual;
    public Gerenciador(Label LabelPergunta, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
    {
        CriarQuestao (LabelPergunta,  ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4,  ButtonResposta5);
    }
    void  CriarQuestao (Label LabelPergunta, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
    {
        var Q1 = new Questao();
        Q1.Pergunta = "Qual é a capital da França?";
        Q1.Resposta1 = "Madrid";
        Q1.Resposta2 = "Londres";
        Q1.Resposta3 = "Berlim";
        Q1.Resposta4 = "Paris";
        Q1.Resposta5 = "Roma";
        Q1.RespostaCorreta = 4;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q1);

        var Q2 = new Questao();
        Q2.Pergunta = "Qual é a moeda do Japão?";
        Q2.Resposta1 = "Yen";
        Q2.Resposta2 = "Won";
        Q2.Resposta3 = "Dólar";
        Q2.Resposta4 = "Euro";
        Q2.Resposta5 = "Rupia";
        Q2.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q2);

        var Q3 = new Questao();
        Q3.Pergunta = "Quem pintou a Mona Lisa?";
        Q3.Resposta1 = "Rembrandt";
        Q3.Resposta2 = "Pablo Picasso";
        Q3.Resposta3 = "Vincent van Gogh";
        Q3.Resposta4 = "Michelangelo";
        Q3.Resposta5 = "Leonardo da Vinci";
        Q3.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q3);

        var Q4 = new Questao();
        Q4.Pergunta = "Qual é o maior planeta do sistema solar?";
        Q4.Resposta1 = "Júpiter";
        Q4.Resposta2 = "Saturno";
        Q4.Resposta3 = "Terra";
        Q4.Resposta4 = "Marte";
        Q4.Resposta5 = "Netuno";
        Q4.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q4);

        var Q5 = new Questao();
        Q5.Pergunta = "Qual é a capital do Brasil?";
        Q5.Resposta1 = "São Paulo";
        Q5.Resposta2 = "Rio de Janeiro";
        Q5.Resposta3 = "Brasília";
        Q5.Resposta4 = "Salvador";
        Q5.Resposta5 = "Fortaleza";
        Q5.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q5);

        var Q6 = new Questao();
        Q6.Pergunta = "Qual é a língua mais falada do mundo?";
        Q6.Resposta1 = "Mandarim";
        Q6.Resposta2 = "Inglês";
        Q6.Resposta3 = "Espanhol";
        Q6.Resposta4 = "Árabe";
        Q6.Resposta5 = "Hindi";
        Q6.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q6);

        var Q7 = new Questao();
        Q7.Pergunta = "Qual é o maior oceano do mundo?";
        Q7.Resposta1 = "Oceano Antárticoo";
        Q7.Resposta2 = "Oceano Atlântico";
        Q7.Resposta3 = "Oceano Índico";
        Q7.Resposta4 = "Oceano Ártico";
        Q7.Resposta5 = "Oceano Pacífico";
        Q7.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q7);

        var Q8 = new Questao();
        Q8.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q8.Resposta1 = "Machado de Assis";
        Q8.Resposta2 = "José de Alencar";
        Q8.Resposta3 = "Graciliano Ramos";
        Q8.Resposta4 = "Jorge Amado";
        Q8.Resposta5 = "Clarice Lispector";
        Q8.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q8);

        var Q9 = new Questao();
        Q9.Pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q9.Resposta1 = "Ósmio";
        Q9.Resposta2 = "Ouro";
        Q9.Resposta3 = "Oxigênio";
        Q9.Resposta4 = "Ozônio";
        Q9.Resposta5 = "Oxido";
        Q9.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q9);

        var Q10 = new Questao();
        Q10.Pergunta = "Qual é a capital da Itália?";
        Q10.Resposta1 = "Milão";
        Q10.Resposta2 = "Roma";
        Q10.Resposta3 = "Nápoles";
        Q10.Resposta4 = "Veneza";
        Q10.Resposta5 = "Florência";
        Q10.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q10);

        var Q11 = new Questao();
        Q11.Pergunta = "Qual é a fórmula da água?";
        Q11.Resposta1 = "H2O";
        Q11.Resposta2 = "O2";
        Q11.Resposta3 = "CO2";
        Q11.Resposta4 = "NaCl";
        Q11.Resposta5 = "H2O2";
        Q11.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q11);

        var Q12 = new Questao();
        Q12.Pergunta = "Quem foi o primeiro homem a pisar na lua?";
        Q12.Resposta1 = "Michael Collins";
        Q12.Resposta2 = "Buzz Aldrin";
        Q12.Resposta3 = "Yuri Gagarin";
        Q12.Resposta4 = "John Glenn";
        Q12.Resposta5 = "Neil Armstrong";
        Q12.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q12);

        var Q13 = new Questao();
        Q13.Pergunta = "Qual é a montanha mais alta do mundo?";
        Q13.Resposta1 = "K2";
        Q13.Resposta2 = "Everest";
        Q13.Resposta3 = "Kangchenjunga";
        Q13.Resposta4 = "Lhotse";
        Q13.Resposta5 = "Makalu";
        Q13.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q13);

        var Q14 = new Questao();
        Q14.Pergunta = "Qual é o maior mamífero do planeta?";
        Q14.Resposta1 = "Elefante";
        Q14.Resposta2 = "Baleia Azul";
        Q14.Resposta3 = "Girafa";
        Q14.Resposta4 = "Orca";
        Q14.Resposta5 = "Urso Pardo";
        Q14.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q14);

        var Q15 = new Questao();
        Q15.Pergunta = "Qual é o símbolo químico do ferro?";
        Q15.Resposta1 = "Fe";
        Q15.Resposta2 = "Ir";
        Q15.Resposta3 = "F";
        Q15.Resposta4 = "Fr";
        Q15.Resposta5 = "Pb";
        Q15.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q15);

        var Q16 = new Questao();
        Q16.Pergunta = "Qual é o continente onde fica o Egito?";
        Q16.Resposta1 = "Ásia";
        Q16.Resposta2 = "Europa";
        Q16.Resposta3 = "África";
        Q16.Resposta4 = "América do Sul";
        Q16.Resposta5 = "Oceania";
        Q16.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q16);

        var Q17 = new Questao();
        Q17.Pergunta = "Qual é o animal símbolo da Austrália?";
        Q17.Resposta1 = "Canguru";
        Q17.Resposta2 = "Koala";
        Q17.Resposta3 = "Emu";
        Q17.Resposta4 = "Tasmânia";
        Q17.Resposta5 = "Dingo";
        Q17.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q17);

        var Q18 = new Questao();
        Q18.Pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
        Q18.Resposta1 = "1944";
        Q18.Resposta2 = "1946";
        Q18.Resposta3 = "1945";
        Q18.Resposta4 = "1947";
        Q18.Resposta5 = "1948";
        Q18.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q18);

        var Q19 = new Questao();
        Q19.Pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
        Q19.Resposta1 = "Hercule Poirot";
        Q19.Resposta2 = "Sherlock Holmes";
        Q19.Resposta3 = "Miss Marple";
        Q19.Resposta4 = "Sam Spade";
        Q19.Resposta5 = "Philip Marlowe";
        Q19.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q19);

        var Q20 = new Questao();
        Q20.Pergunta = "Qual é o principal componente do núcleo da Terra?";
        Q20.Resposta1 = "Silício";
        Q20.Resposta2 = "Ferro";
        Q20.Resposta3 = "Níquel";
        Q20.Resposta4 = "Alumínio";
        Q20.Resposta5 = "Cálcio";
        Q20.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q20);

        var Q21 = new Questao();
        Q21.Pergunta = "Quem foi o primeiro imperador romano?";
        Q21.Resposta1 = "Júlio César";
        Q21.Resposta2 = "Constantino";
        Q21.Resposta3 = "Nero";
        Q21.Resposta4 = "Trajano";
        Q21.Resposta5 = "Augusto";
        Q21.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q21);

        var Q22 = new Questao();
        Q22.Pergunta = "Qual é a obra mais famosa de Miguel de Cervantes?";
        Q22.Resposta1 = "A Divina Comédia";
        Q22.Resposta2 = "O Pequeno Príncipe";
        Q22.Resposta3 = "Dom Quixote";
        Q22.Resposta4 = "Os Miseráveis";
        Q22.Resposta5 = "Guerra e Paz";
        Q22.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q22);

        var Q23 = new Questao();
        Q23.Pergunta = "Qual elemento químico tem o maior número atômico conhecido?";
        Q23.Resposta1 = "Uranium";
        Q23.Resposta2 = "Plutônio";
        Q23.Resposta3 = "Carbono";
        Q23.Resposta4 = "Oganessônio";
        Q23.Resposta5 = "Tório";
        Q23.RespostaCorreta = 4;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q23);

        var Q24 = new Questao();
        Q24.Pergunta = "Quem desenvolveu a teoria da relatividade?";
        Q24.Resposta1 = "Albert Einstein";
        Q24.Resposta2 = "Isaac Newton";
        Q24.Resposta3 = "Niels Bohr";
        Q24.Resposta4 = "Galileu Galilei";
        Q24.Resposta5 = "Stephen Hawking";
        Q24.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q24);

        var Q25 = new Questao();
        Q25.Pergunta = "Qual era o nome do último imperador romano?";
        Q25.Resposta1 = "Nero";
        Q25.Resposta2 = "Augusto";
        Q25.Resposta3 = "Júlio César";
        Q25.Resposta4 = "Constantino";
        Q25.Resposta5 = "Rômulo Augusto";
        Q25.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q25);

        var Q26 = new Questao();
        Q26.Pergunta = "Quem foi o primeiro homem a viajar ao espaço?";
        Q26.Resposta1 = "Neil Armstrong";
        Q26.Resposta2 = "Yuri Gagarin";
        Q26.Resposta3 = "Buzz Aldrin";
        Q26.Resposta4 = "John Glenn";
        Q26.Resposta5 = "Valentina Tereshkova";
        Q26.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q26);

        var Q27 = new Questao();
        Q27.Pergunta = "Qual foi a causa da queda do Império Romano?";
        Q27.Resposta1 = "Invasões Bárbaras";
        Q27.Resposta2 = "Fome";
        Q27.Resposta3 = "Revoltas internas";
        Q27.Resposta4 = "Desastres naturais";
        Q27.Resposta5 = "Crise econômica";
        Q27.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q27);

        var Q28 = new Questao();
        Q28.Pergunta = "Qual foi o primeiro estado a abolir a escravidão no mundo?";
        Q28.Resposta1 = "Brasil";
        Q28.Resposta2 = "Reino Unido";
        Q28.Resposta3 = "Haiti";
        Q28.Resposta4 = "Espanha";
        Q28.Resposta5 = "França";
        Q28.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q28);

        var Q29 = new Questao();
        Q29.Pergunta = "Quem descobriu a penicilina?";
        Q29.Resposta1 = "Alexander Fleming ";
        Q29.Resposta2 = "Louis Pasteur";
        Q29.Resposta3 = "Joseph Lister";
        Q29.Resposta4 = "Robert Koch";
        Q29.Resposta5 = "Edward Jenner";
        Q29.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q29);

        var Q30 = new Questao();
        Q30.Pergunta = "Qual é a capital da Islândia?";
        Q30.Resposta1 = "Helsinque";
        Q30.Resposta2 = "Oslo";
        Q30.Resposta3 = "Copenhague";
        Q30.Resposta4 = "Reykjavik";
        Q30.Resposta5 = "Estocolmo";
        Q30.RespostaCorreta = 4;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q30);

        var Q31 = new Questao();
        Q31.Pergunta = "Quem foi o primeiro imperador da China?";
        Q31.Resposta1 = "Qin Shi Huang";
        Q31.Resposta2 = "Han Wudi";
        Q31.Resposta3 = "Kublai Khan";
        Q31.Resposta4 = "Tang Taizong";
        Q31.Resposta5 = "Sun Yat-sen";
        Q31.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q31);

        var Q32 = new Questao();
        Q32.Pergunta = "Qual foi o evento que marcou o início da Revolução Francesa?";
        Q32.Resposta1 = "A declaração dos Direitos do Homem e do Cidadão";
        Q32.Resposta2 = "A Assembleia Nacional";
        Q32.Resposta3 = "A Queda da Bastilha";
        Q32.Resposta4 = "O Reinado do Terror";
        Q32.Resposta5 = "A execução de Luís XVI";
        Q32.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q32);

        var Q33 = new Questao();
        Q33.Pergunta = "Quem foi a rainha da Inglaterra durante a Era Elisabetana?";
        Q33.Resposta1 = "Maria I";
        Q33.Resposta2 = "Elizabeth I";
        Q33.Resposta3 = "Victoria";
        Q33.Resposta4 = "Anne";
        Q33.Resposta5 = "Catarina";
        Q33.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q33);

        var Q34 = new Questao();
        Q34.Pergunta = "Qual foi o principal tratado que encerrou a Primeira Guerra Mundial?";
        Q34.Resposta1 = "Tratado de Versalhes";
        Q34.Resposta2 = "Tratado de Trianon";
        Q34.Resposta3 = "Tratado de Saint-Germain";
        Q34.Resposta4 = "Tratado de Brest-Litovsk";
        Q34.Resposta5 = "Tratado de Paris";
        Q34.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q34);

        var Q35 = new Questao();
        Q35.Pergunta = "Quem foi o líder da União Soviética durante a Segunda Guerra Mundial?";
        Q35.Resposta1 = "Leon Trotsky";
        Q35.Resposta2 = "Vladimir Lenin";
        Q35.Resposta3 = "Joseph Stalin";
        Q35.Resposta4 = "Nikita Khrushchev";
        Q35.Resposta5 = "Mikhail Gorbachev";
        Q35.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q35);

        var Q36 = new Questao();
        Q36.Pergunta = "Qual civilização antiga construiu as pirâmides de Gizé?";
        Q36.Resposta1 = "Babilônios";
        Q36.Resposta2 = "Egípcios";
        Q36.Resposta3 = "Sumérios";
        Q36.Resposta4 = "Maias";
        Q36.Resposta5 = "Incas";
        Q36.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q36);

        var Q37 = new Questao();
        Q37.Pergunta = "Qual foi o nome do famoso discurso de Martin Luther King Jr. durante a Marcha sobre Washington?";
        Q37.Resposta1 = "I Have a Dream";
        Q37.Resposta2 = "We Shall Overcome";
        Q37.Resposta3 = "The Ballot or the Bullet";
        Q37.Resposta4 = "Give Me Liberty or Give Me Death";
        Q37.Resposta5 = "The Audacity of Hope";
        Q37.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q37);

        var Q38 = new Questao();
        Q38.Pergunta = "Em que ano ocorreu a queda do Muro de Berlim?";
        Q38.Resposta1 = "1985";
        Q38.Resposta2 = "1989";
        Q38.Resposta3 = "1991";
        Q38.Resposta4 = "1995";
        Q38.Resposta5 = "2001";
        Q38.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q38);

        var Q39 = new Questao();
        Q39.Pergunta = "Quem foi o principal autor da Constituição dos Estados Unidos?";
        Q39.Resposta1 = "George Washington";
        Q39.Resposta2 = "Thomas Jefferson";
        Q39.Resposta3 = "James Madison";
        Q39.Resposta4 = "Benjamin Franklin";
        Q39.Resposta5 = "John Adams";
        Q39.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q39);

        var Q40 = new Questao();
        Q40.Pergunta = "Qual evento deu início à Guerra Fria?";
        Q40.Resposta1 = "A queda da bomba atômica em Hiroshima";
        Q40.Resposta2 = "A criação da OTAN";
        Q40.Resposta3 = "A divisão da Alemanha";
        Q40.Resposta4 = "A Revolução Russa";
        Q40.Resposta5 = "A Guerra da Coreia";
        Q40.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q40);

        var Q41 = new Questao();
        Q41.Pergunta = "Quem foi o responsável pela unificação da Alemanha em 1871?";
        Q41.Resposta1 = "Otto von Bismarck";
        Q41.Resposta2 = "Wilhelm I";
        Q41.Resposta3 = "Kaiser Friedrich";
        Q41.Resposta4 = "Ludwig van Beethoven";
        Q41.Resposta5 = "Heinrich Himmler";
        Q41.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q41);

        var Q42 = new Questao();
        Q42.Pergunta = "Qual foi a primeira civilização a desenvolver um sistema de escrita?";
        Q42.Resposta1 = "Egípcios";
        Q42.Resposta2 = "Sumérios";
        Q42.Resposta3 = "Gregos";
        Q42.Resposta4 = "Fenícios";
        Q42.Resposta5 = "Romanos";
        Q42.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q42);

        var Q43 = new Questao();
        Q43.Pergunta = "Qual evento levou os EUA a entrar na Primeira Guerra Mundial?";
        Q43.Resposta1 = "Ataque a Pearl Harbor";
        Q43.Resposta2 = "Conferência de Paris";
        Q43.Resposta3 = "Revolução Russa";
        Q43.Resposta4 = "Tratado de Versalhes";
        Q43.Resposta5 = "Ação de submarinos alemães";
        Q43.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q43);

        var Q44 = new Questao();
        Q44.Pergunta = "Qual foi a principal causa da Revolução Industrial?";
        Q44.Resposta1 = "Mudanças climáticas";
        Q44.Resposta2 = "Inovações tecnológicas";
        Q44.Resposta3 = "Guerras constantes";
        Q44.Resposta4 = "Colonização";
        Q44.Resposta5 = "Falta de recursos naturais";
        Q44.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q44);

        var Q45 = new Questao();
        Q45.Pergunta = "Quem foi o autor da obra 'A Arte da Guerra'?";
        Q45.Resposta1 = "Confúcio";
        Q45.Resposta2 = "Sun Tzu";
        Q45.Resposta3 = "Laozi";
        Q45.Resposta4 = "Buddha";
        Q45.Resposta5 = "Zhuangzi";
        Q45.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q45);

        var Q46 = new Questao();
        Q46.Pergunta = "Qual foi o nome da primeira colônia britânica na América do Norte?";
        Q46.Resposta1 = "Jamestown";
        Q46.Resposta2 = "Plymouth";
        Q46.Resposta3 = "Roanoke";
        Q46.Resposta4 = "Massachusetts";
        Q46.Resposta5 = "Virginia";
        Q46.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q46);

        var Q47 = new Questao();
        Q47.Pergunta = "Qual tratado encerrou a Guerra Civil Americana?";
        Q47.Resposta1 = "Tratado de Paris";
        Q47.Resposta2 = "Tratado de Appomattox";
        Q47.Resposta3 = "Tratado de Guadalupe Hidalgo";
        Q47.Resposta4 = "Tratado de Versalhes";
        Q47.Resposta5 = "Tratado de Trianon";
        Q47.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q47);

        var Q48 = new Questao();
        Q48.Pergunta = "Qual foi o movimento social que buscou abolir a escravidão nos EUA?";
        Q48.Resposta1 = "Abolicionismo";
        Q48.Resposta2 = "Suffragismo";
        Q48.Resposta3 = "Socialismo";
        Q48.Resposta4 = "Progressivismo";
        Q48.Resposta5 = "Reforma do Trabalho";
        Q48.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q48);

        var Q49 = new Questao();
        Q49.Pergunta = "Qual foi a consequência da Revolução Russa de 1917?";
        Q49.Resposta1 = "Estabelecimento do regime nazista";
        Q49.Resposta2 = "Adoção do capitalismo";
        Q49.Resposta3 = "Ascensão do socialismo";
        Q49.Resposta4 = "Unificação da Europa";
        Q49.Resposta5 = "Guerra Fria";
        Q49.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q49);

        var Q50 = new Questao();
        Q50.Pergunta = "Qual foi o principal objetivo da Conferência de Potsdam em 1945?";
        Q50.Resposta1 = "Planejar a reconstrução da Europa";
        Q50.Resposta2 = "Estabelecer as fronteiras da Polônia";
        Q50.Resposta3 = "Criar a Organização das Nações Unidas";
        Q50.Resposta4 = "Dividir a Alemanha";
        Q50.Resposta5 = "Definir a nova ordem mundial após a guerra";
        Q50.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q50);

        var Q51 = new Questao();
        Q51.Pergunta = "Qual filósofo é conhecido por sua teoria do 'imperativo categórico'?";
        Q51.Resposta1 = "Friedrich Nietzsche";
        Q51.Resposta2 = "Immanuel Kant";
        Q51.Resposta3 = "John Stuart Mill";
        Q51.Resposta4 = "Georg Wilhelm Friedrich Hegel";
        Q51.Resposta5 = "David Hume";
        Q51.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q51);

        var Q52 = new Questao();
        Q52.Pergunta = "Qual é o conceito sociológico de 'anomia', proposto por Émile Durkheim?";
        Q22.Resposta1 = "Desigualdade social";
        Q52.Resposta2 = "Alienaçãos";
        Q52.Resposta3 = "Conformidade social";
        Q52.Resposta4 = "Mobilidade social";
        Q52.Resposta5 = "Desintegração de normas sociais";
        Q52.RespostaCorreta = 5;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q52);

        var Q53 = new Questao();
        Q53.Pergunta = "Qual movimento artístico é associado a Marcel Duchamp e ao conceito de 'ready-made'?";
        Q53.Resposta1 = "Surrealismo";
        Q53.Resposta2 = "Impressionismo";
        Q53.Resposta3 = "Dadaísmo";
        Q53.Resposta4 = "Cubismo";
        Q53.Resposta5 = "Expressionismo";
        Q53.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q53);

        var Q54 = new Questao();
        Q54.Pergunta = "O que é o 'Homo Ludens', segundo Johan Huizinga?";
        Q54.Resposta1 = "O homem como trabalhador";
        Q54.Resposta2 = "O homem como consumidor";
        Q54.Resposta3 = "O homem como jogador";
        Q54.Resposta4 = "O homem como pensador";
        Q54.Resposta5 = "O homem como artista";
        Q54.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q54);

        var Q55 = new Questao();
        Q55.Pergunta = "Qual é a obra famosa de Edvard Munch que retrata a angústia humana?";
        Q55.Resposta1 = "A Persistência da Memória";
        Q55.Resposta2 = "O Grito";
        Q55.Resposta3 = "O Beijo";
        Q55.Resposta4 = "A Noite Estrelada";
        Q55.Resposta5 = "A Criação de Adão";
        Q55.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q55);

        var Q56 = new Questao();
        Q56.Pergunta = "Quem é considerado o pai da sociologia moderna?";
        Q56.Resposta1 = "Karl Marx";
        Q56.Resposta2 = "Émile Durkheim";
        Q56.Resposta3 = "Max Weber";
        Q56.Resposta4 = "Alexis de Tocqueville";
        Q56.Resposta5 = "Herbert Spencer";
        Q56.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q56);

        var Q57 = new Questao();
        Q57.Pergunta = "Qual filósofo propôs o conceito de 'super-homem' (Übermensch)?";
        Q57.Resposta1 = "Arthur Schopenhauer";
        Q57.Resposta2 = "Friedrich Nietzsche";
        Q57.Resposta3 = "Jean-Paul Sartre";
        Q57.Resposta4 = "Michel Foucault";
        Q57.Resposta5 = "Simone de Beauvoir";
        Q57.RespostaCorreta = 2;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q57);

        var Q58 = new Questao();
        Q58.Pergunta = "Qual é a principal crítica de Adorno e Horkheimer à cultura de massa?";
        Q58.Resposta1 = "A ausência de criatividade";
        Q58.Resposta2 = "A falta de diversidade";
        Q58.Resposta3 = "A manipulação ideológica";
        Q58.Resposta4 = "O excesso de consumo";
        Q58.Resposta5 = "A banalização da arte";
        Q58.RespostaCorreta = 3;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q58);

        var Q60 = new Questao();
        Q60.Pergunta = "O que significa a expressão 'cogito, ergo sum', de René Descartes?";
        Q60.Resposta1 = "Penso, logo existo";
        Q60.Resposta2 = "Sinto, logo sou";
        Q60.Resposta3 = "Falo, logo existo";
        Q60.Resposta4 = "Amo, logo sou";
        Q60.Resposta5 = "Acredito, logo existo";
        Q60.RespostaCorreta = 1;
        ConfiguraDesenhar(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q60);

    }
    public void ProximaQuestao()
    {
        var numRandomico = Random.Shared.Next (0,ListaQuestaoRespondida.Count);
        while (ListaQuestaoRespondida.Contains (numRandomico) )
        numRandomico = Random.Shared.Next (0,ListaQuestaoRespondida.Count -1);

        ListaQuestaoRespondida.Add (numRandomico);
        QuestaoAtual = ListaQuestao[numRandomico];
        QuestaoAtual.Desenhar();
    }
    public async void VerficaCorreta (int RespostaSelecionada)
    {
        if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
        {
            await Task.Delay (1000);
            ProximaQuestao();
        }
    }

    public int Pontuaçao {get; private set;}
        public int Pontuacao { get; private set; }

        int NivelAtual = 0;

    void Inicializar()
    {
        Pontuaçao = 0;
        NivelAtual = 0;
        ProximaQuestao();
    }
    
    public async void VerficaCorreta (int RespostaSelecionada)
    {
        if (QuestaoAtual.Pergunta EstaCorreto(RespostaSelecionada))
        {
            await Task.Delay (1000);
            NivelAtual ++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim!","Você Errou","OK");
            Inicializar();
        }

        void Adiciona Pontuacao (int n);
        {
            if (n == 1)
             Pontuacao = 1000;
            else if (n == 2);
             Pontuacao = 2000;
            else if (n == 3);
             Pontuacao = 5000;
             else if (n == 4);
             Pontuacao = 10000;
            else if (n == 5);
             Pontuacao = 20000;
              Pontuacao = 2000;
            else if (n == 6);
             Pontuacao = 50000;
             else if (n == 7);
             Pontuacao = 100000;
            else if (n == 8);
             Pontuacao = 200000;
            else if (n == 9);
             Pontuacao = 500000;
            else
                Pontuacao = 1000000;
            
        }
    }
    }
}