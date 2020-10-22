using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject partida_mapa;
    public GameObject panel_config;

    public void local()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("local");
    }

    public void online()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("online");
    }

    public void como_jogar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("como_jogar");
    }

    public void voltar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }

    public void sair()
    {
        Application.Quit();
    }

    public void show_partida() 
    {
       partida_mapa.SetActive(true);
    }

    public void show_config() 
    {
       panel_config.SetActive(true);
    }

    public void cover_partida() 
    {
       partida_mapa.SetActive(false);
    }

    public void cover_config() 
    {
       panel_config.SetActive(false);
    }
}
