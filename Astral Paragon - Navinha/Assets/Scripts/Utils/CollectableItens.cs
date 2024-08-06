using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItens : MonoBehaviour
{
    public bool itemDeEscudo;
    public bool itemDeLaserDuplo;
    public bool itemDeVida;

    public int vidaParaDar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (itemDeEscudo == true)
            {
                other.gameObject.GetComponent<VidaDoPlayer>().AtivarEscudo();
            }

            if (itemDeLaserDuplo == true)
            {
                other.gameObject.GetComponent<PlayerController>().temLaserDuplo = false;

                other.gameObject.GetComponent<PlayerController>().tempoAtualDosLasersDuplos = other.gameObject.GetComponent<PlayerController>().tempoMaximoDosLasersDuplos;

                other.gameObject.GetComponent<PlayerController>().temLaserDuplo = true;
            }

            if (itemDeVida == true)
            {
                other.gameObject.GetComponent<VidaDoPlayer>().GanharVida(vidaParaDar);
                
            }
                
            Destroy(this.gameObject);
        }
    }
}
