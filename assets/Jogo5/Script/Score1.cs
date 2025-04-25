using UnityEngine;
using System.Collections;

public class Score1 : MonoBehaviour
{

    public int pontos = 0;
    public TextMesh Pontuacao;
    public SpawnLixo spawnLink1;
    public Lixo spawnLink2_1;
    public Lixo spawnLink2_2;
    public Lixo spawnLink2_3;
    public Lixo spawnLink2_4;
    public Lixo spawnLink2_5;
    public Lixeira spawnLink2b;
    public Pedra spawnLink2c;
    public SpawnLixeira spawnLink2d;
    public SpawnPedra spawnLink2e;
    public ScrollingScript1 spawnLink3;
    public ScrollingScript1 spawnLink3b;
    public Energia spawnLink4;

    public float pontuacao1;
    public float pontuacao2;
    public float pontuacao3;

    public float tempoDeJogo;

    void nivel()
    {
        if (tempoDeJogo >= 0 && tempoDeJogo < 30)
        {
            spawnLink1.caseSwitch = 1;
            spawnLink2_1.caseSwitch = 1;
            spawnLink2_2.caseSwitch = 1;
            spawnLink2_3.caseSwitch = 1;
            spawnLink2_4.caseSwitch = 1;
            spawnLink2_5.caseSwitch = 1;
            spawnLink2c.caseSwitch = 1;
            spawnLink3.caseSwitch = 1;
            spawnLink3b.caseSwitch = 1;
            spawnLink2d.caseSwitch = 1;
            spawnLink2b.caseSwitch = 1;
            spawnLink2e.caseSwitch = 1;
            spawnLink4.switchcase = 1;
        }
        if (tempoDeJogo >= 30 && tempoDeJogo < 60)
        {
            spawnLink1.caseSwitch = 2;
            spawnLink2_1.caseSwitch = 2;
            spawnLink2_2.caseSwitch = 2;
            spawnLink2_3.caseSwitch = 2;
            spawnLink2_4.caseSwitch = 2;
            spawnLink2_5.caseSwitch = 2;
            spawnLink2c.caseSwitch = 2;
            spawnLink3.caseSwitch = 2;
            spawnLink3b.caseSwitch = 2;
            spawnLink2d.caseSwitch = 2;
            spawnLink2b.caseSwitch = 2;
            spawnLink2e.caseSwitch = 2;
            spawnLink4.switchcase = 2;
        }
        if (tempoDeJogo >= 60)
        {
            spawnLink1.caseSwitch = 3;
            spawnLink2_1.caseSwitch = 3;
            spawnLink2_2.caseSwitch = 3;
            spawnLink2_3.caseSwitch = 3;
            spawnLink2_4.caseSwitch = 3;
            spawnLink2_5.caseSwitch = 3;
            spawnLink2c.caseSwitch = 3;
            spawnLink3.caseSwitch = 3;
            spawnLink3b.caseSwitch = 3;
            spawnLink2d.caseSwitch = 3;
            spawnLink2b.caseSwitch = 3;
            spawnLink2e.caseSwitch = 3;
            spawnLink4.switchcase = 3;
        }
    }

    void Start()
    {
        tempoDeJogo = 0;

        if (PlayerPrefs.GetFloat("pontuacao1") != null)
        {
            pontuacao1 = PlayerPrefs.GetFloat("pontuacao1");
        }
        if (PlayerPrefs.GetFloat("pontuacao2") != null)
        {
            pontuacao2 = PlayerPrefs.GetFloat("pontuacao2");
        }
        if (PlayerPrefs.GetFloat("pontuacao3") != null)
        {
            pontuacao3 = PlayerPrefs.GetFloat("pontuacao3");
        }
    }

    void Update()
    {
        Pontuacao.text = ("" + pontos).ToString();

        tempoDeJogo += Time.deltaTime;

        nivel();

        if (pontos > pontuacao1)
        {
            pontuacao1 = pontos;
            PlayerPrefs.SetFloat("pontuacao1", pontuacao1);
        }
        else if (pontos > pontuacao2 && pontos < pontuacao1)
        {
            pontuacao2 = pontos;
            PlayerPrefs.SetFloat("pontuacao2", pontuacao2);
        }
        else if (pontos > pontuacao3 && pontos < pontuacao2)
        {
            pontuacao3 = pontos;
            PlayerPrefs.SetFloat("pontuacao3", pontuacao3);

        }
    }
}