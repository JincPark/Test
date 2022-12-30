using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public Image FadeOutCanvers;

    private void Update()
    {
        
    }
    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float fadeCount = 1;
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;

            FadeOutCanvers.color = new Color(255, 255, 255, fadeCount);

            yield return new WaitForSeconds(0.01f);
        }
    }
}
