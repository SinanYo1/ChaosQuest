using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinningScreen : MonoBehaviour
{
    public CanvasGroup fadePanel;
    public float fadeDuration = 2f;

    void Start()
    {
        fadePanel.alpha = 0; // Startet unsichtbar
    }

    public void ShowWinningScreen()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float time = 0;
        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            fadePanel.alpha = time / fadeDuration;
            yield return null;
        }
        fadePanel.alpha = 1;
    }
}

//Dieser Code ist nur dafür zuständig das die UI einen gewissen Fade Effekt hat wenn der Gewinner Screen angezeigt wird
