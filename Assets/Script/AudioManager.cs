using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfx, music;

    public static AudioManager Instance { get; private set; }


    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }

    /*Desventajas:
    - Acoplamiento de codigo (comunicacion de script).
    - Dificil de Testear
    - Esconde Dependencias (legibilidad del codigo)
    - Problemas de Extension
     */

}
