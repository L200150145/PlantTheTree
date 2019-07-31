using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeScene : MonoBehaviour {

    public static FadeScene instance;

    public Image fadeImage;

    public GameObject fademanager;

    public Color startColor;
    public Color endColor;
    public float duration;

    private bool isFading;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        FadeIn();
    }

    public void FadeIn ()
    {
        StartCoroutine(BeginFade());
    }

    public void FadeOutScene()
    {
        StartCoroutine(endFade());
    }

    private IEnumerator BeginFade()
    {
        isFading = true;

        float timer = 0f;

        while(timer <= duration)
        {
            fadeImage.color = Color.Lerp(startColor, endColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        fademanager.SetActive(false);
    }

    private IEnumerator endFade()
    {
        isFading = false;

        float timer = 0f;

        while (timer <= duration)
        {
            fadeImage.color = Color.Lerp(endColor, startColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        fademanager.SetActive(true);
    }

}
