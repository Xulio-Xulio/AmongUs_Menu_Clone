using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour
{
    // Start is called before the first frame update

    /* void Start()
    {   
        // Este método impede que o objeto 
        // atual seja destruido durante o carregamento.
        DontDestroyOnLoad(gameObject);
    } */

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
       /*  // Obtém o objeto da cena que possui o AudioClip
        // é bom manter uma convenção para o nome deste objeto.
        // Neste exemplo BGM.
        GameObject menu_theme = GameObject.Find("menu_theme");

        // Obtém o componente AudioSource do objeto.
        AudioSource source = menu_theme.GetComponent<AudioSource>();

        // Utilize as linhas abaixo conforme necessário
        // para controlar a reprodução.
        //source.Play();      // Inicia a reprodução do áudio.
        //source.Stop();      // Pára a reprodução do áudio, inicia do começo quando for reproduzido novamente.
        //source.UnPause();   // Despausa a reprodução previamente pausada. Similar ao Play após um audio ter sido pausado.
        //source.Pause();     // Pausa a reprodução.

        // Exemplo:
        if(SceneManager.GetActiveScene().name == "local" || name == "online")
        {
            source.Stop();
        }
        else
        {
            source.Play();
        } */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
