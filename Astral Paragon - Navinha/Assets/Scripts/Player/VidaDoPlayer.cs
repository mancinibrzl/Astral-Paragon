using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoPlayer : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;

    public int vidaMaximaDoJogador;
    public int vidaAtualDoJogador;

    public bool temEscudo;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDoJogador;
        barraDeVidaDoJogador.maxValue = vidaMaximaDoJogador;
        barraDeVidaDoJogador.value = vidaAtualDoJogador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarJogador(int danoParaReceber)
    {
        if(temEscudo == false)
        {
            vidaAtualDoJogador -= danoParaReceber;
            barraDeVidaDoJogador.value = vidaAtualDoJogador;

            if(vidaAtualDoJogador <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }

}
