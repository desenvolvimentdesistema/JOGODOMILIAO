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
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q1);

        var Q2 = new Questao();
        Q2.Pergunta = "Qual é a moeda do Japão?";
        Q2.Resposta1 = "Yen";
        Q2.Resposta2 = "Won";
        Q2.Resposta3 = "Dólar";
        Q2.Resposta4 = "Euro";
        Q2.Resposta5 = "Rupia";
        Q2.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q2);

        var Q3 = new Questao();
        Q3.Pergunta = "Quem pintou a Mona Lisa?";
        Q3.Resposta1 = "Rembrandt";
        Q3.Resposta2 = "Pablo Picasso";
        Q3.Resposta3 = "Vincent van Gogh";
        Q3.Resposta4 = "Michelangelo";
        Q3.Resposta5 = "Leonardo da Vinci";
        Q3.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q3);

        var Q4 = new Questao();
        Q4.Pergunta = "Qual é o maior planeta do sistema solar?";
        Q4.Resposta1 = "Júpiter";
        Q4.Resposta2 = "Saturno";
        Q4.Resposta3 = "Terra";
        Q4.Resposta4 = "Marte";
        Q4.Resposta5 = "Netuno";
        Q4.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q4);

        var Q5 = new Questao();
        Q5.Pergunta = "Qual é a capital do Brasil?";
        Q5.Resposta1 = "São Paulo";
        Q5.Resposta2 = "Rio de Janeiro";
        Q5.Resposta3 = "Brasília";
        Q5.Resposta4 = "Salvador";
        Q5.Resposta5 = "Fortaleza";
        Q5.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q5);

        var Q6 = new Questao();
        Q6.Pergunta = "Qual é a língua mais falada do mundo?";
        Q6.Resposta1 = "Mandarim";
        Q6.Resposta2 = "Inglês";
        Q6.Resposta3 = "Espanhol";
        Q6.Resposta4 = "Árabe";
        Q6.Resposta5 = "Hindi";
        Q6.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q6);

        var Q7 = new Questao();
        Q7.Pergunta = "Qual é o maior oceano do mundo?";
        Q7.Resposta1 = "Oceano Antárticoo";
        Q7.Resposta2 = "Oceano Atlântico";
        Q7.Resposta3 = "Oceano Índico";
        Q7.Resposta4 = "Oceano Ártico";
        Q7.Resposta5 = "Oceano Pacífico";
        Q7.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q7);

        var Q8 = new Questao();
        Q8.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q8.Resposta1 = "Machado de Assis";
        Q8.Resposta2 = "José de Alencar";
        Q8.Resposta3 = "Graciliano Ramos";
        Q8.Resposta4 = "Jorge Amado";
        Q8.Resposta5 = "Clarice Lispector";
        Q8.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q8);

        var Q9 = new Questao();
        Q9.Pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q9.Resposta1 = "Ósmio";
        Q9.Resposta2 = "Ouro";
        Q9.Resposta3 = "Oxigênio";
        Q9.Resposta4 = "Ozônio";
        Q9.Resposta5 = "Oxido";
        Q9.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q9);

        var Q10 = new Questao();
        Q10.Pergunta = "Qual é a capital da Itália?";
        Q10.Resposta1 = "Milão";
        Q10.Resposta2 = "Roma";
        Q10.Resposta3 = "Nápoles";
        Q10.Resposta4 = "Veneza";
        Q10.Resposta5 = "Florência";
        Q10.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q10);

        var Q11 = new Questao();
        Q11.Pergunta = "Qual é a fórmula da água?";
        Q11.Resposta1 = "H2O";
        Q11.Resposta2 = "O2";
        Q11.Resposta3 = "CO2";
        Q11.Resposta4 = "NaCl";
        Q11.Resposta5 = "H2O2";
        Q11.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q11);

        var Q12 = new Questao();
        Q12.Pergunta = "Quem foi o primeiro homem a pisar na lua?";
        Q12.Resposta1 = "Michael Collins";
        Q12.Resposta2 = "Buzz Aldrin";
        Q12.Resposta3 = "Yuri Gagarin";
        Q12.Resposta4 = "John Glenn";
        Q12.Resposta5 = "Neil Armstrong";
        Q12.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q12);

        var Q13 = new Questao();
        Q13.Pergunta = "Qual é a montanha mais alta do mundo?";
        Q13.Resposta1 = "K2";
        Q13.Resposta2 = "Everest";
        Q13.Resposta3 = "Kangchenjunga";
        Q13.Resposta4 = "Lhotse";
        Q13.Resposta5 = "Makalu";
        Q13.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q13);

        var Q14 = new Questao();
        Q14.Pergunta = "Qual é o maior mamífero do planeta?";
        Q14.Resposta1 = "Elefante";
        Q14.Resposta2 = "Baleia Azul";
        Q14.Resposta3 = "Girafa";
        Q14.Resposta4 = "Orca";
        Q14.Resposta5 = "Urso Pardo";
        Q14.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q14);

        var Q15 = new Questao();
        Q15.Pergunta = "Qual é o símbolo químico do ferro?";
        Q15.Resposta1 = "Fe";
        Q15.Resposta2 = "Ir";
        Q15.Resposta3 = "F";
        Q15.Resposta4 = "Fr";
        Q15.Resposta5 = "Pb";
        Q15.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q15);

        var Q16 = new Questao();
        Q16.Pergunta = "Qual é o continente onde fica o Egito?";
        Q16.Resposta1 = "Ásia";
        Q16.Resposta2 = "Europa";
        Q16.Resposta3 = "África";
        Q16.Resposta4 = "América do Sul";
        Q16.Resposta5 = "Oceania";
        Q16.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q16);

        var Q17 = new Questao();
        Q17.Pergunta = "Qual é o animal símbolo da Austrália?";
        Q17.Resposta1 = "Canguru";
        Q17.Resposta2 = "Koala";
        Q17.Resposta3 = "Emu";
        Q17.Resposta4 = "Tasmânia";
        Q17.Resposta5 = "Dingo";
        Q17.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q17);

        var Q18 = new Questao();
        Q18.Pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
        Q18.Resposta1 = "1944";
        Q18.Resposta2 = "1946";
        Q18.Resposta3 = "1945";
        Q18.Resposta4 = "1947";
        Q18.Resposta5 = "1948";
        Q18.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q18);

        var Q19 = new Questao();
        Q19.Pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
        Q19.Resposta1 = "Hercule Poirot";
        Q19.Resposta2 = "Sherlock Holmes";
        Q19.Resposta3 = "Miss Marple";
        Q19.Resposta4 = "Sam Spade";
        Q19.Resposta5 = "Philip Marlowe";
        Q19.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q19);

        var Q20 = new Questao();
        Q20.Pergunta = "Qual é o principal componente do núcleo da Terra?";
        Q20.Resposta1 = "Silício";
        Q20.Resposta2 = "Ferro";
        Q20.Resposta3 = "Níquel";
        Q20.Resposta4 = "Alumínio";
        Q20.Resposta5 = "Cálcio";
        Q20.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q20);

        var Q21 = new Questao();
        Q21.Pergunta = "Quem foi o primeiro imperador romano?";
        Q21.Resposta1 = "Júlio César";
        Q21.Resposta2 = "Constantino";
        Q21.Resposta3 = "Nero";
        Q21.Resposta4 = "Trajano";
        Q21.Resposta5 = "Augusto";
        Q21.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q21);

        var Q22 = new Questao();
        Q22.Pergunta = "Qual é a obra mais famosa de Miguel de Cervantes?";
        Q22.Resposta1 = "A Divina Comédia";
        Q22.Resposta2 = "O Pequeno Príncipe";
        Q22.Resposta3 = "Dom Quixote";
        Q22.Resposta4 = "Os Miseráveis";
        Q22.Resposta5 = "Guerra e Paz";
        Q22.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q22);

        var Q23 = new Questao();
        Q23.Pergunta = "Qual elemento químico tem o maior número atômico conhecido?";
        Q23.Resposta1 = "Uranium";
        Q23.Resposta2 = "Plutônio";
        Q23.Resposta3 = "Carbono";
        Q23.Resposta4 = "Oganessônio";
        Q23.Resposta5 = "Tório";
        Q23.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q23);

        var Q24 = new Questao();
        Q24.Pergunta = "Quem desenvolveu a teoria da relatividade?";
        Q24.Resposta1 = "Albert Einstein";
        Q24.Resposta2 = "Isaac Newton";
        Q24.Resposta3 = "Niels Bohr";
        Q24.Resposta4 = "Galileu Galilei";
        Q24.Resposta5 = "Stephen Hawking";
        Q24.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q24);

        var Q25 = new Questao();
        Q25.Pergunta = "Qual era o nome do último imperador romano?";
        Q25.Resposta1 = "Nero";
        Q25.Resposta2 = "Augusto";
        Q25.Resposta3 = "Júlio César";
        Q25.Resposta4 = "Constantino";
        Q25.Resposta5 = "Rômulo Augusto";
        Q25.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q25);

        var Q26 = new Questao();
        Q26.Pergunta = "Quem foi o primeiro homem a viajar ao espaço?";
        Q26.Resposta1 = "Neil Armstrong";
        Q26.Resposta2 = "Yuri Gagarin";
        Q26.Resposta3 = "Buzz Aldrin";
        Q26.Resposta4 = "John Glenn";
        Q26.Resposta5 = "Valentina Tereshkova";
        Q26.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q26);

        var Q27 = new Questao();
        Q27.Pergunta = "Qual foi a causa da queda do Império Romano?";
        Q27.Resposta1 = "Invasões Bárbaras";
        Q27.Resposta2 = "Fome";
        Q27.Resposta3 = "Revoltas internas";
        Q27.Resposta4 = "Desastres naturais";
        Q27.Resposta5 = "Crise econômica";
        Q27.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q27);

        var Q28 = new Questao();
        Q28.Pergunta = "Qual foi o primeiro estado a abolir a escravidão no mundo?";
        Q28.Resposta1 = "Brasil";
        Q28.Resposta2 = "Reino Unido";
        Q28.Resposta3 = "Haiti";
        Q28.Resposta4 = "Espanha";
        Q28.Resposta5 = "França";
        Q28.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q28);

        var Q29 = new Questao();
        Q29.Pergunta = "Quem descobriu a penicilina?";
        Q29.Resposta1 = "Alexander Fleming ";
        Q29.Resposta2 = "Louis Pasteur";
        Q29.Resposta3 = "Joseph Lister";
        Q29.Resposta4 = "Robert Koch";
        Q29.Resposta5 = "Edward Jenner";
        Q29.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q29);

        var Q30 = new Questao();
        Q30.Pergunta = "Qual é a capital da Islândia?";
        Q30.Resposta1 = "Helsinque";
        Q30.Resposta2 = "Oslo";
        Q30.Resposta3 = "Copenhague";
        Q30.Resposta4 = "Reykjavik";
        Q30.Resposta5 = "Estocolmo";
        Q30.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q30);

        var Q31 = new Questao();
        Q31.Pergunta = "Quem foi o primeiro imperador da China?";
        Q31.Resposta1 = "Qin Shi Huang";
        Q31.Resposta2 = "Han Wudi";
        Q31.Resposta3 = "Kublai Khan";
        Q31.Resposta4 = "Tang Taizong";
        Q31.Resposta5 = "Sun Yat-sen";
        Q31.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q31);

        var Q32 = new Questao();
        Q32.Pergunta = "Qual foi o evento que marcou o início da Revolução Francesa?";
        Q32.Resposta1 = "A declaração dos Direitos do Homem e do Cidadão";
        Q32.Resposta2 = "A Assembleia Nacional";
        Q32.Resposta3 = "A Queda da Bastilha";
        Q32.Resposta4 = "O Reinado do Terror";
        Q32.Resposta5 = "A execução de Luís XVI";
        Q32.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q32);

        var Q33 = new Questao();
        Q33.Pergunta = "Quem foi a rainha da Inglaterra durante a Era Elisabetana?";
        Q33.Resposta1 = "Maria I";
        Q33.Resposta2 = "Elizabeth I";
        Q33.Resposta3 = "Victoria";
        Q33.Resposta4 = "Anne";
        Q33.Resposta5 = "Catarina";
        Q33.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q33);

        var Q34 = new Questao();
        Q34.Pergunta = "Qual foi o principal tratado que encerrou a Primeira Guerra Mundial?";
        Q34.Resposta1 = "Tratado de Versalhes";
        Q34.Resposta2 = "Tratado de Trianon";
        Q34.Resposta3 = "Tratado de Saint-Germain";
        Q34.Resposta4 = "Tratado de Brest-Litovsk";
        Q34.Resposta5 = "Tratado de Paris";
        Q34.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q34);

        var Q35 = new Questao();
        Q35.Pergunta = "Quem foi o líder da União Soviética durante a Segunda Guerra Mundial?";
        Q35.Resposta1 = "Leon Trotsky";
        Q35.Resposta2 = "Vladimir Lenin";
        Q35.Resposta3 = "Joseph Stalin";
        Q35.Resposta4 = "Nikita Khrushchev";
        Q35.Resposta5 = "Mikhail Gorbachev";
        Q35.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q35);

        var Q36 = new Questao();
        Q36.Pergunta = "Qual civilização antiga construiu as pirâmides de Gizé?";
        Q36.Resposta1 = "Babilônios";
        Q36.Resposta2 = "Egípcios";
        Q36.Resposta3 = "Sumérios";
        Q36.Resposta4 = "Maias";
        Q36.Resposta5 = "Incas";
        Q36.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q36);

        var Q37 = new Questao();
        Q37.Pergunta = "Qual foi o nome do famoso discurso de Martin Luther King Jr. durante a Marcha sobre Washington?";
        Q37.Resposta1 = "I Have a Dream";
        Q37.Resposta2 = "We Shall Overcome";
        Q37.Resposta3 = "The Ballot or the Bullet";
        Q37.Resposta4 = "Give Me Liberty or Give Me Death";
        Q37.Resposta5 = "The Audacity of Hope";
        Q37.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q37);

        var Q38 = new Questao();
        Q38.Pergunta = "Em que ano ocorreu a queda do Muro de Berlim?";
        Q38.Resposta1 = "1985";
        Q38.Resposta2 = "1989";
        Q38.Resposta3 = "1991";
        Q38.Resposta4 = "1995";
        Q38.Resposta5 = "2001";
        Q38.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q38);

        var Q39 = new Questao();
        Q39.Pergunta = "Quem foi o principal autor da Constituição dos Estados Unidos?";
        Q39.Resposta1 = "George Washington";
        Q39.Resposta2 = "Thomas Jefferson";
        Q39.Resposta3 = "James Madison";
        Q39.Resposta4 = "Benjamin Franklin";
        Q39.Resposta5 = "John Adams";
        Q39.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q39);

        var Q40 = new Questao();
        Q40.Pergunta = "Qual evento deu início à Guerra Fria?";
        Q40.Resposta1 = "A queda da bomba atômica em Hiroshima";
        Q40.Resposta2 = "A criação da OTAN";
        Q40.Resposta3 = "A divisão da Alemanha";
        Q40.Resposta4 = "A Revolução Russa";
        Q40.Resposta5 = "A Guerra da Coreia";
        Q40.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q40);

        var Q41 = new Questao();
        Q41.Pergunta = "Quem foi o responsável pela unificação da Alemanha em 1871?";
        Q41.Resposta1 = "Otto von Bismarck";
        Q41.Resposta2 = "Wilhelm I";
        Q41.Resposta3 = "Kaiser Friedrich";
        Q41.Resposta4 = "Ludwig van Beethoven";
        Q41.Resposta5 = "Heinrich Himmler";
        Q41.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q41);

        var Q42 = new Questao();
        Q42.Pergunta = "Qual foi a primeira civilização a desenvolver um sistema de escrita?";
        Q42.Resposta1 = "Egípcios";
        Q42.Resposta2 = "Sumérios";
        Q42.Resposta3 = "Gregos";
        Q42.Resposta4 = "Fenícios";
        Q42.Resposta5 = "Romanos";
        Q42.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q42);

        var Q43 = new Questao();
        Q43.Pergunta = "Qual evento levou os EUA a entrar na Primeira Guerra Mundial?";
        Q43.Resposta1 = "Ataque a Pearl Harbor";
        Q43.Resposta2 = "Conferência de Paris";
        Q43.Resposta3 = "Revolução Russa";
        Q43.Resposta4 = "Tratado de Versalhes";
        Q43.Resposta5 = "Ação de submarinos alemães";
        Q43.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q43);

        var Q44 = new Questao();
        Q44.Pergunta = "Qual foi a principal causa da Revolução Industrial?";
        Q44.Resposta1 = "Mudanças climáticas";
        Q44.Resposta2 = "Inovações tecnológicas";
        Q44.Resposta3 = "Guerras constantes";
        Q44.Resposta4 = "Colonização";
        Q44.Resposta5 = "Falta de recursos naturais";
        Q44.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q44);

        var Q45 = new Questao();
        Q45.Pergunta = "Quem foi o autor da obra 'A Arte da Guerra'?";
        Q45.Resposta1 = "Confúcio";
        Q45.Resposta2 = "Sun Tzu";
        Q45.Resposta3 = "Laozi";
        Q45.Resposta4 = "Buddha";
        Q45.Resposta5 = "Zhuangzi";
        Q45.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q45);

        var Q46 = new Questao();
        Q46.Pergunta = "Qual foi o nome da primeira colônia britânica na América do Norte?";
        Q46.Resposta1 = "Jamestown";
        Q46.Resposta2 = "Plymouth";
        Q46.Resposta3 = "Roanoke";
        Q46.Resposta4 = "Massachusetts";
        Q46.Resposta5 = "Virginia";
        Q46.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q46);

        var Q47 = new Questao();
        Q47.Pergunta = "Qual tratado encerrou a Guerra Civil Americana?";
        Q47.Resposta1 = "Tratado de Paris";
        Q47.Resposta2 = "Tratado de Appomattox";
        Q47.Resposta3 = "Tratado de Guadalupe Hidalgo";
        Q47.Resposta4 = "Tratado de Versalhes";
        Q47.Resposta5 = "Tratado de Trianon";
        Q47.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q47);

        var Q48 = new Questao();
        Q48.Pergunta = "Qual foi o movimento social que buscou abolir a escravidão nos EUA?";
        Q48.Resposta1 = "Abolicionismo";
        Q48.Resposta2 = "Suffragismo";
        Q48.Resposta3 = "Socialismo";
        Q48.Resposta4 = "Progressivismo";
        Q48.Resposta5 = "Reforma do Trabalho";
        Q48.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q48);

        var Q49 = new Questao();
        Q49.Pergunta = "Qual foi a consequência da Revolução Russa de 1917?";
        Q49.Resposta1 = "Estabelecimento do regime nazista";
        Q49.Resposta2 = "Adoção do capitalismo";
        Q49.Resposta3 = "Ascensão do socialismo";
        Q49.Resposta4 = "Unificação da Europa";
        Q49.Resposta5 = "Guerra Fria";
        Q49.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q49);

        var Q50 = new Questao();
        Q50.Pergunta = "Qual foi o principal objetivo da Conferência de Potsdam em 1945?";
        Q50.Resposta1 = "Planejar a reconstrução da Europa";
        Q50.Resposta2 = "Estabelecer as fronteiras da Polônia";
        Q50.Resposta3 = "Criar a Organização das Nações Unidas";
        Q50.Resposta4 = "Dividir a Alemanha";
        Q50.Resposta5 = "Definir a nova ordem mundial após a guerra";
        Q50.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q50);

        var Q51 = new Questao();
        Q51.Pergunta = "Qual filósofo é conhecido por sua teoria do 'imperativo categórico'?";
        Q51.Resposta1 = "Friedrich Nietzsche";
        Q51.Resposta2 = "Immanuel Kant";
        Q51.Resposta3 = "John Stuart Mill";
        Q51.Resposta4 = "Georg Wilhelm Friedrich Hegel";
        Q51.Resposta5 = "David Hume";
        Q51.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q51);

        var Q52 = new Questao();
        Q52.Pergunta = "Qual é o conceito sociológico de 'anomia', proposto por Émile Durkheim?";
        Q22.Resposta1 = "Desigualdade social";
        Q52.Resposta2 = "Alienaçãos";
        Q52.Resposta3 = "Conformidade social";
        Q52.Resposta4 = "Mobilidade social";
        Q52.Resposta5 = "Desintegração de normas sociais";
        Q52.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q52);

        var Q53 = new Questao();
        Q53.Pergunta = "Qual movimento artístico é associado a Marcel Duchamp e ao conceito de 'ready-made'?";
        Q53.Resposta1 = "Surrealismo";
        Q53.Resposta2 = "Impressionismo";
        Q53.Resposta3 = "Dadaísmo";
        Q53.Resposta4 = "Cubismo";
        Q53.Resposta5 = "Expressionismo";
        Q53.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q53);

        var Q54 = new Questao();
        Q54.Pergunta = "O que é o 'Homo Ludens', segundo Johan Huizinga?";
        Q54.Resposta1 = "O homem como trabalhador";
        Q54.Resposta2 = "O homem como consumidor";
        Q54.Resposta3 = "O homem como jogador";
        Q54.Resposta4 = "O homem como pensador";
        Q54.Resposta5 = "O homem como artista";
        Q54.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q54);

        var Q55 = new Questao();
        Q55.Pergunta = "Qual é a obra famosa de Edvard Munch que retrata a angústia humana?";
        Q55.Resposta1 = "A Persistência da Memória";
        Q55.Resposta2 = "O Grito";
        Q55.Resposta3 = "O Beijo";
        Q55.Resposta4 = "A Noite Estrelada";
        Q55.Resposta5 = "A Criação de Adão";
        Q55.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q55);

        var Q56 = new Questao();
        Q56.Pergunta = "Quem é considerado o pai da sociologia moderna?";
        Q56.Resposta1 = "Karl Marx";
        Q56.Resposta2 = "Émile Durkheim";
        Q56.Resposta3 = "Max Weber";
        Q56.Resposta4 = "Alexis de Tocqueville";
        Q56.Resposta5 = "Herbert Spencer";
        Q56.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q56);

        var Q57 = new Questao();
        Q57.Pergunta = "Qual filósofo propôs o conceito de 'super-homem' (Übermensch)?";
        Q57.Resposta1 = "Arthur Schopenhauer";
        Q57.Resposta2 = "Friedrich Nietzsche";
        Q57.Resposta3 = "Jean-Paul Sartre";
        Q57.Resposta4 = "Michel Foucault";
        Q57.Resposta5 = "Simone de Beauvoir";
        Q57.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q57);

        var Q58 = new Questao();
        Q58.Pergunta = "Qual é a principal crítica de Adorno e Horkheimer à cultura de massa?";
        Q58.Resposta1 = "A ausência de criatividade";
        Q58.Resposta2 = "A falta de diversidade";
        Q58.Resposta3 = "A manipulação ideológica";
        Q58.Resposta4 = "O excesso de consumo";
        Q58.Resposta5 = "A banalização da arte";
        Q58.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q58);

        var Q59 = new Questao();
        Q59.Pergunta = "O que significa a expressão 'cogito, ergo sum', de René Descartes?";
        Q59.Resposta1 = "Penso, logo existo";
        Q59.Resposta2 = "Sinto, logo sou";
        Q59.Resposta3 = "Falo, logo existo";
        Q59.Resposta4 = "Amo, logo sou";
        Q59.Resposta5 = "Acredito, logo existo";
        Q59.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q59);

        var Q60 = new Questao();
        Q60.Pergunta = "Qual é o último dígito da função zeta de Riemann avaliada em s = 2, na forma de uma fração irracional?";
        Q60.Resposta1 = "1";
        Q60.Resposta2 = "2";
        Q60.Resposta3 = "3";
        Q60.Resposta4 = "6";
        Q60.Resposta5 = "Nenhuma das anteriores";
        Q60.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q60);

        var Q61 = new Questao();
        Q61.Pergunta = "Qual é o nome do teorema que estabelece a relação entre o número de zeros e polos de uma função meromorfa em uma superfície de Riemann compacta?";
        Q61.Resposta1 = "Teorema de Poincaré-Hopf";
        Q61.Resposta2 = "Teorema dos Resíduos";
        Q61.Resposta3 = "Teorema de Gauss-Bonnet";
        Q61.Resposta4 = "Teorema de Riemann-Roch";
        Q61.Resposta5 = "Teorema de Liouville";
        Q61.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q61);

        var Q62 = new Questao();
        Q62.Pergunta = "Qual foi a primeira prova formalmente reconhecida do teorema de incompletude de Gödel?";
        Q62.Resposta1 = "Prova de Gödel em 1931";
        Q62.Resposta2 = "Prova de Turing em 1936";
        Q62.Resposta3 = "Prova de Church em 1935";
        Q62.Resposta4 = "Prova de Kleene em 1943";
        Q62.Resposta5 = "Prova de Hilbert em 1928";
        Q62.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q62);

        var Q63 = new Questao();
        Q63.Pergunta = "Na física quântica, qual é o nome da equação que descreve a evolução temporal de um estado quântico em termos de um operador Hamiltoniano?";
        Q63.Resposta1 = "Equação de Schrödinger";
        Q63.Resposta2 = "Equação de Klein-Gordon";
        Q63.Resposta3 = "Equação de Dirac";
        Q63.Resposta4 = "Equação de Heisenberg";
        Q63.Resposta5 = "Equação de Pauli";
        Q63.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q63);

        var Q64 = new Questao();
        Q64.Pergunta = "Em que ano a conjectura de Poincaré foi finalmente resolvida, e quem foi o matemático responsável pela sua solução?";
        Q64.Resposta1 = "2000, por Andrew Wiles";
        Q64.Resposta2 = "2003, por Grigori Perelman";
        Q64.Resposta3 = "1994, por John Nash";
        Q64.Resposta4 = "2006, por Terence Tao";
        Q64.Resposta5 = "2001, por Edward Witten";
        Q64.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q64);

        var Q65 = new Questao();
        Q65.Pergunta = "Na topologia algébrica, o que o teorema de classificação das superfícies compactas orientáveis afirma sobre essas superfícies?";
        Q65.Resposta1 = "Elas são classificadas de acordo com o número de buracos";
        Q65.Resposta2 = "Elas são classificadas pela sua curvatura gaussiana";
        Q65.Resposta3 = "Elas são todas homeomorfas a esferas";
        Q65.Resposta4 = "Elas podem ser classificadas pelo seu gênero";
        Q65.Resposta5 = "Elas são todas simplesmente conexas";
        Q65.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q65);

        var Q66 = new Questao();
        Q66.Pergunta = "Na física de partículas, o que a violação da simetria CP implica em termos da física fundamental do universo?";
        Q66.Resposta1 = "Que há uma diferença entre matéria e antimatéria";
        Q66.Resposta2 = "Que o universo pode ter uma curvatura negativa";
        Q66.Resposta3 = "Que as interações fracas não conservam paridade";
        Q66.Resposta4 = "Que o tempo pode ser revertido em certas interações";
        Q66.Resposta5 = "Que as leis da física mudam em diferentes pontos do universo";
        Q66.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q66);

        var Q67 = new Questao();
        Q67.Pergunta = "Em teoria das cordas, qual é a implicação física da dualidade T em dimensões compactificadas?";
        Q67.Resposta1 = "Ela conecta diferentes teorias de cordas através de transformações de campo";
        Q67.Resposta2 = "Ela estabelece a equivalência entre cordas de diferentes tensões";
        Q67.Resposta3 = "Ela descreve a equivalência entre grandes e pequenas dimensões compactificadas";
        Q67.Resposta4 = "Ela prediz a existência de partículas supersimétricas";
        Q67.Resposta5 = "Ela estabelece que cordas podem se dividir em dimensões extras";
        Q67.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q67);

        var Q68 = new Questao();
        Q68.Pergunta = "Na teoria da complexidade computacional, qual é a relação entre os problemas NP-completos e os problemas P?";
        Q68.Resposta1 = "Todo problema NP-completo é resolvido em tempo polinomial";
        Q68.Resposta2 = "Se um problema NP-completo for resolvido em tempo polinomial, todos os problemas NP também podem ser";
        Q68.Resposta3 = "Problemas NP-completos são os mais difíceis dentro da classe P";
        Q68.Resposta4 = "Problemas NP-completos podem ser resolvidos apenas por algoritmos exponenciais";
        Q68.Resposta5 = "Problemas NP e P são conjuntos disjuntos";
        Q68.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q68);

        var Q69 = new Questao();
        Q69.Pergunta = "Qual é a conjectura de Birch e Swinnerton-Dyer, um dos grandes problemas abertos da matemática moderna?";
        Q69.Resposta1 = "Ela propõe uma fórmula para o número de soluções de equações diofantinas cúbicas";
        Q69.Resposta2 = "Ela relaciona a função L de uma curva elíptica com o número de seus pontos racionais";
        Q69.Resposta3 = "Ela sugere uma generalização do último teorema de Fermat";
        Q69.Resposta4 = "Ela afirma que a soma dos quadrados de dois números primos sempre resulta em outro primo";
        Q69.Resposta5 = "Ela postula que não existem soluções inteiras para equações polinomiais de grau maior que 2";
        Q69.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q69);

        var Q70 = new Questao();
        Q70.Pergunta = "Na geometria algébrica, o que estabelece o teorema de Mordell-Weil sobre as curvas elípticas definidas sobre corpos numéricos?";
        Q70.Resposta1 = "O grupo dos pontos racionais de uma curva elíptica é finitamente gerado";
        Q70.Resposta2 = "As curvas elípticas têm número finito de soluções inteiras";
        Q70.Resposta3 = "O número de pontos racionais de uma curva elíptica é infinito";
        Q70.Resposta4 = "Toda curva elíptica é birracionalmente equivalente a uma superfície projetiva";
        Q70.Resposta5 = "A função L de uma curva elíptica determina o seu comportamento assintótico";
        Q70.RespostaCorreta = 1;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q70);

        var Q71 = new Questao();
        Q71.Pergunta = "Qual é o nome do teorema que afirma que, sob certas condições, a equação de Dirac pode ser usada para descrever partículas relativísticas de spin 1/2?";
        Q71.Resposta1 = "Teorema de Noether";
        Q71.Resposta2 = "Teorema de Feynman-Stueckelberg";
        Q71.Resposta3 = "Teorema de Spin-Estatística";
        Q71.Resposta4 = "Teorema de Pauli-Lubanski";
        Q71.Resposta5 = "Teorema de Foldy-Wouthuysen";
        Q71.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q71);

        var Q72 = new Questao();
        Q72.Pergunta = "Na teoria de Galois, qual é a condição necessária e suficiente para que uma equação polinomial seja resolúvel por radicais?";
        Q72.Resposta1 = "O grupo de Galois associado à equação deve ser abeliano";
        Q72.Resposta2 = "O grau do polinômio deve ser menor ou igual a 4";
        Q72.Resposta3 = "O discriminante do polinômio deve ser igual a zero";
        Q72.Resposta4 = "O grupo de Galois associado à equação deve ser solúvel";
        Q72.Resposta5 = "O polinômio deve ser irreducível sobre os números racionais";
        Q72.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q72);

        var Q73 = new Questao();
        Q73.Pergunta = "Na mecânica quântica, o que estabelece o teorema de Bell sobre as desigualdades de Bell e suas implicações para a realidade local?";
        Q73.Resposta1 = "Que a teoria quântica pode ser formulada de maneira determinista";
        Q73.Resposta2 = "Que as variáveis ocultas locais são incompatíveis com as previsões da mecânica quântica";
        Q73.Resposta3 = "Que a mecânica quântica preserva a localidade em todos os experimentos";
        Q73.Resposta4 = "Que a não-localidade é irrelevante para sistemas emaranhados";
        Q73.Resposta5 = "Que as desigualdades de Bell provam a natureza determinista da quântica";
        Q73.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q73);

        var Q74 = new Questao();
        Q74.Pergunta = "No estudo da geometria de variedades, o que estabelece o teorema de Nash sobre imersões isométricas?";
        Q74.Resposta1 = "Toda variedade compacta pode ser mergulhada em um espaço euclidiano";
        Q74.Resposta2 = "Toda variedade riemanniana pode ser imersa isometricamente em um espaço euclidiano";
        Q74.Resposta3 = "Toda variedade orientável admite uma folheação global";
        Q74.Resposta4 = "Toda superfície com curvatura constante pode ser parametrizada por coordenadas isométricas";
        Q74.Resposta5 = "Toda variedade riemanniana compacta admite uma métrica plana";
        Q74.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q74);

        var Q75 = new Questao();
        Q75.Pergunta = "Na história política, o que foi o Tratado de Westfália, assinado em 1648, e qual foi sua principal consequência para o sistema internacional?";
        Q75.Resposta1 = "Estabeleceu a Liga das Nações como um precursor das Nações Unidas";
        Q75.Resposta2 = "Resultou na criação de fronteiras fixas na Europa";
        Q75.Resposta3 = "Marcou o fim da Guerra dos Trinta Anos e o início do conceito de soberania nacional";
        Q75.Resposta4 = "Dividiu o império otomano entre as potências europeias";
        Q75.Resposta5 = "Reafirmou o domínio papal sobre os Estados europeus";
        Q75.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q75);

        var Q76 = new Questao();
        Q76.Pergunta = "Na psicologia cognitiva, o que propõe o modelo de processamento dual em relação à tomada de decisões humanas?";
        Q76.Resposta1 = "Que a tomada de decisão ocorre de forma puramente racional";
        Q76.Resposta2 = "Que há dois sistemas de pensamento: um rápido e automático, e outro lento e deliberado";
        Q76.Resposta3 = "Que todas as decisões são baseadas em memórias inconscientes";
        Q76.Resposta4 = "Que o processo decisório é sempre influenciado por emoções";
        Q76.Resposta5 = "Que o ambiente externo não tem impacto significativo na tomada de decisão";
        Q76.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q76);

        var Q77 = new Questao();
        Q77.Pergunta = "Na química orgânica, qual é a principal característica que define os compostos aromáticos, como o benzeno, de acordo com a regra de Hückel?";
        Q77.Resposta1 = "Eles têm uma cadeia de átomos de carbono aberta e saturada";
        Q77.Resposta2 = "Eles têm um número par de elétrons de ligação pi deslocalizados";
        Q77.Resposta3 = "Eles obedecem à regra de 4n + 2 elétrons pi deslocalizados em anéis conjugados";
        Q77.Resposta4 = "Eles são sempre alifáticos e possuem ligações duplas";
        Q77.Resposta5 = "Eles têm uma estrutura geométrica linear e acíclica";
        Q77.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q77);

        var Q78 = new Questao();
        Q78.Pergunta = "Na economia, o que propõe o teorema de Coase sobre a alocação eficiente de recursos em presença de externalidades?";
        Q78.Resposta1 = "Que o governo deve intervir em todas as situações de externalidades negativas";
        Q78.Resposta2 = "Que as externalidades sempre levam ao fracasso do mercado, independentemente de acordos entre as partes";
        Q78.Resposta3 = "Que, na ausência de custos de transação, os agentes econômicos podem negociar para alocar recursos de forma eficiente";
        Q78.Resposta4 = "Que externalidades positivas são corrigidas automaticamente pelos mercados";
        Q78.Resposta5 = "Que as externalidades são irrelevantes para o equilíbrio de mercado";
        Q78.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q78);

        var Q79 = new Questao();
        Q79.Pergunta = "Na filosofia política, o que sustenta a teoria da justiça de John Rawls, especialmente com relação ao 'véu da ignorância'?";
        Q79.Resposta1 = "Que as desigualdades sociais são inevitáveis e devem ser aceitas";
        Q79.Resposta2 = "Que os indivíduos devem escolher princípios de justiça sem conhecer sua posição na sociedade";
        Q79.Resposta3 = "Que a justiça é uma questão de eficiência econômica";
        Q79.Resposta4 = "Que o poder político deve ser distribuído de acordo com o mérito";
        Q79.Resposta5 = "Que a justiça só pode ser alcançada por meio de uma economia de mercado sem restrições";
        Q79.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q79);

        var Q80 = new Questao();
        Q80.Pergunta = "Na ecologia, o que define o conceito de nicho ecológico segundo a visão de G. Evelyn Hutchinson?";
        Q80.Resposta1 = "É o conjunto de habitats onde uma espécie pode ser encontrada";
        Q80.Resposta2 = "É a posição de uma espécie na cadeia alimentar";
        Q80.Resposta3 = "É o conjunto de condições ambientais e recursos que uma espécie requer para sobreviver e se reproduzir";
        Q80.Resposta4 = "É o papel de uma espécie na polinização e dispersão de sementes";
        Q80.Resposta5 = "É o espaço físico que uma espécie ocupa em um ecossistema";
        Q80.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q80);

        var Q81 = new Questao();
        Q81.Pergunta = "Na linguística, qual é o princípio fundamental da hipótese de Sapir-Whorf, também conhecida como a hipótese da relatividade linguística?";
        Q81.Resposta1 = "Todas as línguas possuem estruturas gramaticais idênticas";
        Q81.Resposta2 = "A linguagem influencia o pensamento e a percepção de mundo";
        Q81.Resposta3 = "A linguagem é uma criação arbitrária sem conexão com a realidade";
        Q81.Resposta4 = "A linguagem evolui de maneira independente das influências culturais";
        Q81.Resposta5 = "A linguagem se desenvolve de acordo com regras matemáticas precisas";
        Q81.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q81);

        var Q82 = new Questao();
        Q82.Pergunta = "Em economia, qual é o conceito fundamental que descreve a relação inversa entre o nível de preços e a quantidade demandada de bens e serviços, conhecido como a lei da demanda?";
        Q82.Resposta1 = "Quanto maior o preço, maior a quantidade demandada";
        Q82.Resposta2 = "A demanda é completamente insensível às variações de preço";
        Q82.Resposta3 = "Quanto menor o preço, maior a quantidade demandada";
        Q82.Resposta4 = "A quantidade demandada é diretamente proporcional ao preço";
        Q82.Resposta5 = "A demanda por bens de luxo aumenta com o preço";
        Q82.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q82);

        var Q83 = new Questao();
        Q83.Pergunta = "Na filosofia, qual é a principal questão tratada na obra 'Crítica da Razão Pura' de Immanuel Kant?";
        Q83.Resposta1 = "A existência de Deus";
        Q83.Resposta2 = "A relação entre experiência e conhecimento a priori";
        Q83.Resposta3 = "A moralidade e o imperativo categórico";
        Q83.Resposta4 = "A relação entre mente e corpo";
        Q83.Resposta5 = "A natureza do ser e do tempo";
        Q83.RespostaCorreta = 2;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q83);

        var Q84 = new Questao();
        Q84.Pergunta = "Na biologia molecular, o que é o splicing alternativo e qual é sua principal função nos organismos eucarióticos?";
        Q84.Resposta1 = "Remover introns e exons de maneira sequencial";
        Q84.Resposta2 = "Permitir a tradução direta de RNA em proteínas sem processamento";
        Q84.Resposta3 = "Permitir que um único gene codifique múltiplas proteínas";
        Q84.Resposta4 = "Acelerar o processo de replicação do DNA";
        Q84.Resposta5 = "Controlar a velocidade de transcrição dos genes";
        Q84.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q84);

        var Q85 = new Questao();
        Q85.Pergunta = "Na medicina, qual é a principal função das células de Schwann no sistema nervoso periférico?";
        Q85.Resposta1 = "Atuam na produção de neurotransmissores";
        Q85.Resposta2 = "Participam na manutenção da barreira hematoencefálica";
        Q85.Resposta3 = "Facilitam a regeneração de sinapses neuronais";
        Q85.Resposta4 = "Regulam a pressão sanguínea nas arteríolas cerebrais";
        Q85.Resposta5 = "Promovem a mielinização dos axônios, aumentando a velocidade de condução dos impulsos nervosos";
        Q85.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q85);

        var Q86 = new Questao();
        Q86.Pergunta = "Em engenharia civil, o que é o 'módulo de Young' e como ele é utilizado no cálculo estrutural?";
        Q86.Resposta1 = "Uma medida da resistência ao impacto de um material";
        Q86.Resposta2 = "A força necessária para causar uma falha catastrófica em uma estrutura";
        Q86.Resposta3 = "Um coeficiente usado para calcular a carga crítica em vigas";
        Q86.Resposta4 = "A relação entre a tensão aplicada e a deformação elástica resultante em um material";
        Q86.Resposta5 = "Uma constante que descreve a resistência ao cisalhamento de um material";
        Q86.RespostaCorreta = 4;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q86);

        var Q87 = new Questao();
        Q87.Pergunta = "Na sociologia, o que Max Weber propôs como a característica central da 'ética protestante' em relação ao desenvolvimento do capitalismo?";
        Q87.Resposta1 = "A ênfase na salvação individual por meio da fé";
        Q87.Resposta2 = "A crença de que a acumulação de riquezas é moralmente condenável";
        Q87.Resposta3 = "A visão de que o capitalismo floresceu em culturas não religiosas";
        Q87.Resposta4 = "O desenvolvimento de uma ética de trabalho e disciplina que favoreceu o surgimento do capitalismo moderno";
        Q87.RespostaCorreta = 5;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q87);

        var Q88 = new Questao();
        Q88.Pergunta = "Na estatística, o que afirma o teorema do limite central sobre distribuições de amostras aleatórias?";
        Q88.Resposta1 = "Que qualquer amostra aleatória sempre segue uma distribuição normal";
        Q88.Resposta2 = "Que a média de uma distribuição uniforme sempre tende a ser igual à média da população";
        Q88.Resposta3 = "Que a soma de um grande número de variáveis aleatórias independentes tende a se aproximar de uma distribuição normal";
        Q88.Resposta4 = "Que a variância de uma amostra aumenta com o tamanho da amostra";
        Q88.Resposta5 = "Que qualquer amostra aleatória segue uma distribuição binomial";
        Q88.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q88);

        var Q89 = new Questao();
        Q89.Pergunta = "Na ciência da computação, o que é o problema da parada (Halting Problem) e qual foi a sua conclusão principal segundo Alan Turing?";
        Q89.Resposta1 = "Um algoritmo que decide se um programa terminará ou entrará em um loop infinito sempre pode ser construído";
        Q89.Resposta2 = "O problema da parada é resolúvel apenas para programas com complexidade computacional linear";
        Q89.Resposta3 = "É impossível construir um algoritmo que determine, para todo programa e toda entrada, se o programa vai parar ou rodar indefinidamente";
        Q89.Resposta4 = "O problema da parada é resolvido com o uso de máquinas de Turing universais";
        Q89.Resposta5 = "A solução depende da quantidade de memória disponível no sistema";
        Q89.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q89);

        var Q90 = new Questao();
        Q90.Pergunta = "Na filosofia da ciência, o que é o 'falsificacionismo' proposto por Karl Popper e qual é sua implicação para a prática científica?";
        Q90.Resposta1 = "Teorias científicas podem ser comprovadas através de observações repetidas";
        Q90.Resposta2 = "Teorias científicas devem ser confirmadas por um consenso científico universal";
        Q90.Resposta3 = "Uma teoria científica é válida apenas se puder ser refutada por algum experimento ou observação";
        Q90.Resposta4 = "Teorias científicas são irrefutáveis, apenas evoluindo com o tempo";
        Q90.Resposta5 = "Uma teoria científica só pode ser verdadeira se for suportada por uma evidência empírica extensa";
        Q90.RespostaCorreta = 3;
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q90);

        var Q91 = new Questao();
        Q91.Pergunta = "Na física, o que estabelece o princípio de exclusão de Pauli em relação aos férmions em um sistema quântico?";
        Q91.Resposta1 = "Férmions não podem coexistir no mesmo estado quântico";
        Q91.resposta02 = "Férmions podem ocupar o mesmo estado quântico em temperaturas baixas";
        Q91.resposta03 = "Férmions são indistinguíveis, mas podem coexistir no mesmo estado quântico";
        Q91.resposta04 = "Férmions se aniquilam ao compartilhar o mesmo estado quântico";
        Q91.resposta05 = "Férmions e bósons obedecem às mesmas regras de ocupação quântica";
        Q91.RespostaCorreta = "Férmions não podem coexistir no mesmo estado quântico";
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q91);

var Q37 = new Questao();
Q37.Pergunta = "Na literatura, o que caracteriza o conceito de 'fluxo de consciência' utilizado por autores como James Joyce e Virginia Woolf?";
Q37.Resposta1 = "Um estilo narrativo linear e objetivo";
Q37.resposta02 = "A descrição de eventos com foco exclusivamente em ações externas";
Q37.resposta03 = "Uma técnica narrativa que busca reproduzir o fluxo de pensamentos internos de um personagem, muitas vezes sem estrutura gramatical rígida";
Q37.resposta04 = "O uso de diálogos internos claros e objetivos";
Q37.resposta05 = "A cronologia exata dos pensamentos do personagem";
Q37.RespostaCorreta = "Uma técnica narrativa que busca reproduzir o fluxo de pensamentos internos de um personagem, muitas vezes sem estrutura gramatical rígida";
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q37);

var Q38 = new Questao();
Q38.Pergunta = "Na matemática, o que define um espaço métrico completo segundo o conceito de completude em análise real?";
Q38.Resposta1 = "Todo espaço métrico tem uma métrica derivada que é completa";
Q38.resposta02 = "Um espaço métrico é completo se toda sequência de Cauchy nele convergir para um ponto dentro do espaço";
Q38.resposta03 = "Espaços métricos completos contêm apenas números inteiros";
Q38.resposta04 = "Espaços métricos completos são caracterizados pela existência de subconjuntos densos";
Q38.resposta05 = "Espaços métricos completos são aqueles que têm uma curvatura constante";
Q38.RespostaCorreta = "Um espaço métrico é completo se toda sequência de Cauchy nele convergir para um ponto dentro do espaço";
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q38);

var Q39 = new Questao();
Q39.Pergunta = "Na arqueologia, o que o estudo das pinturas rupestres nas cavernas de Lascaux, na França, revela sobre as sociedades paleolíticas?";
Q39.resposta01 = "A estrutura política centralizada das tribos paleolíticas";
Q39.resposta02 = "A ausência de qualquer tipo de organização social";
Q39.resposta03 = "A importância da caça e de rituais relacionados à sobrevivência";
Q39.resposta04 = "O uso de escritas sofisticadas e registradas";
Q39.resposta05 = "A predominância da agricultura nas sociedades paleolíticas";
Q39.RespostaCorreta = "A importância da caça e de rituais relacionados à sobrevivência";
        ConfiguraDesenha(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
        ListaQuestao.Add(Q39);


    }
    public void ProximaQuestao()
    {
        var numRandomico = Random.Shared.Next (0,ListaQuestaoRespondida.Count);
        while (ListaQuestaoRespondida.Contains (numRandomico) )
        numRandomico = Random.Shared.Next (0,ListaQuestaoRespondida.Count -1);

        ListaQuestaoRespondida.Add (numRandomico);
        QuestaoAtual = ListaQuestao[numRandomico];
        QuestaoAtual.Desenha();
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
    
    public async void VerificaResposta (int RespostaSelecionada)
    {
        if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
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

        void AdicionaPontuacao (int n)
        {
            if (n == 1)
             Pontuacao = 1000;
            else if (n == 2)
             Pontuacao = 2000;
            else if (n == 3)
             Pontuacao = 5000;
             else if (n == 4)
             Pontuacao = 10000;
            else if (n == 5)
             Pontuacao = 20000;
            else if (n == 6)
             Pontuacao = 50000;
             else if (n == 7)
             Pontuacao = 100000;
            else if (n == 8)
             Pontuacao = 200000;
            else if (n == 9)
             Pontuacao = 500000;
            else
                Pontuacao = 1000000;
            
        }
    }
    }
}