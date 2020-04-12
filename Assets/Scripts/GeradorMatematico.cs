using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorMatematico : MonoBehaviour
{

    bool resolvido;
    string problema;
    int solucao;
    int[] solucoes;
    public Sprite valor1, valor2, operador;
    public static int idQuestao = 0;

    protected ProblemaMatematico[] questoes = new ProblemaMatematico[20];


    public GeradorMatematico()
    {
        this.problema = problema;
        this.solucao = solucao;
        resolvido = false;
        solucoes = new int[4];
        for (int i = 0; i < solucoes.Length; i++)
        {
            solucoes[i] = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        questoes[0] = new ProblemaMatematico("7 + 3", 10);
        questoes[1] = new ProblemaMatematico("15 + 2", 17);
        questoes[2] = new ProblemaMatematico("10 + 5", 15);
        questoes[3] = new ProblemaMatematico("2 + 1", 3);
        questoes[4] = new ProblemaMatematico("10 + 2", 12);
        questoes[5] = new ProblemaMatematico("5 - 2", 3);
        questoes[6] = new ProblemaMatematico("20 - 5 ", 15);
        questoes[7] = new ProblemaMatematico("12 - 1", 11);
        questoes[8] = new ProblemaMatematico("15 - 7", 8);
        questoes[9] = new ProblemaMatematico("9-6", 3);
        questoes[10] = new ProblemaMatematico("4 x 4", 16);
        questoes[11] = new ProblemaMatematico("10 x 1", 10);
        questoes[12] = new ProblemaMatematico("18 x 2 ", 36);
        questoes[13] = new ProblemaMatematico("5 x 4", 20);
        questoes[14] = new ProblemaMatematico("2 x 5", 10);
        questoes[15] = new ProblemaMatematico("21 / 3", 7);
        questoes[16] = new ProblemaMatematico("8 / 4", 2);
        questoes[17] = new ProblemaMatematico("16 / 4", 4);
        questoes[18] = new ProblemaMatematico("9 / 3", 3);
        questoes[19] = new ProblemaMatematico("10 / 2", 5);




        //Gerador de números randomicos
        System.Random randGen = new System.Random();
        //Armazeno randomicamente a solucao e armazeno essa posicao.
        int random = randGen.Next(0, 4);
        int posSolucao = random;
        solucoes[posSolucao] = solucao;

        for (int i = 0; i < solucoes.Length; i++)
        {
            random = randGen.Next(randGen.Next(solucao), randGen.Next(solucao, 2 * solucao));
            //Garanto que não estou removendo a solução do meu vetor de solucoes
            if (posSolucao != i)
            {
                //Verifico se já não existe aquela respotas nas minhas posicoes, se já houver, ignoro essa geração e decremento o meu "i".
                if (!contemResposta(random))
                {
                    solucoes[i] = random;
                }
                else
                {
                    i--;
                }
            }
        }

        /*for (int i = 0; i <solucoes.Length; i++){
        Console.WriteLine(solucoes[i]);
        }*/
    }
    //Crio as questoes



    //Metodo simples para analisar se já existe aquele número entre as minhas soluções.
    bool contemResposta(int num)
    {
        for (int i = 0; i < solucoes.Length; i++)
        {
            if (solucoes[i] == num)
            {
                return true;
            }
        }
        return false;
    }

    ProblemaMatematico getNovaQuestaoRandom()
    {
        //Gerador de números randomicos
        System.Random randGen = new System.Random();
        int random = randGen.Next(0, 20);
        while (true)
        {
            if (questoes[random].resolvido == false)
                questoes[random].resolvido = true;
            return questoes[random];
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}