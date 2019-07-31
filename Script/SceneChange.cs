using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour {

    [SerializeField] private Image watercan;
    [SerializeField] private Image shovel;

    public GameObject satu;

    public AudioSource ParticleEffectSFX;

    public ParticleSystem particleEffect;

    public GameObject PopUpMenanam;
    public GameObject PopUpItem;
    public GameObject panel;
    public GameObject img;
    public GameObject tutup;
    


    public void Scene2()
    {
        SceneManager.LoadScene("Continue_scene");
    }

    public void Scene1()
    {
        SceneManager.LoadScene("UI_MainMenu");
    }

    public void Level3_1()
    {
        SceneManager.LoadScene("ReviewLevel3");
    }

    public void level1()
    {
        SceneManager.LoadScene("level_1");
    }

    public void level2()
    {
        SceneManager.LoadScene("level_2");
    }

    public void level3()
    {
        SceneManager.LoadScene("level_3");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("UI_OpeningScene");
    }

    public void minigame()
    {
        SceneManager.LoadScene("minigame");
    }

    public void minigame2()
    {
        SceneManager.LoadScene("minigame2");
    }

    public void minigame3()
    {
        SceneManager.LoadScene("minigame3");
    }

    public void setelahMiniGame()
    {
        SceneManager.LoadScene("level_1_setelahMiniGame");
    }

    public void setelahMiniGame2()
    {
        SceneManager.LoadScene("level_2_setelahMiniGame");
    }

    public void setelahMiniGame3()
    {
        SceneManager.LoadScene("level_3_setelahMiniGame");
    }

    public void map1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void map2()
    {
        SceneManager.LoadScene("Map2");
    }

    public void map2alt()
    {
        SceneManager.LoadScene("Map2_alternate");
    }

    public void map3()
    {
        SceneManager.LoadScene("Map3");
    }

    public void apalah()
    {
        satu.SetActive(true);
    }

    public void ItemAcquire()
    {
        PopUpItem.SetActive(false);
        PopUpMenanam.SetActive(true);
        panel.SetActive(true);
        img.SetActive(true);
        tutup.SetActive(true);
        watercan.enabled = true;
        shovel.enabled = true;
        ParticleEffectSFX.Play();

        if (particleEffect.isPlaying)
        {
            particleEffect.Stop();
        }
        else
        {
            particleEffect.Play();
        }
    }
}
