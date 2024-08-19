using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Vari�veis")]

    public static GameManager instance;

    public AudioSource gameMusic;
    public AudioSource gameOverMusic;
    
    public Text textoDePontuacaoAtual;
    public Text textoDePontuacaoFinal;
    public Text textoDeHighScore;
    
    public GameObject painelDeGameOver;

    public int pontuacaoAtual;

    #region
    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameMusic.Play();

        pontuacaoAtual = 0;
        textoDePontuacaoAtual.text = "PONTUA��O: " + pontuacaoAtual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        pontuacaoAtual += pontosParaGanhar;
        textoDePontuacaoAtual.text = "PONTUA��O: " + pontuacaoAtual;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameMusic.Stop();
        gameOverMusic.Play();

        painelDeGameOver.SetActive(true);
        textoDePontuacaoFinal.text = "PONTUA��O: " + pontuacaoAtual;

        if (pontuacaoAtual > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", pontuacaoAtual);
        }

        textoDeHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
    }
    #endregion
}
