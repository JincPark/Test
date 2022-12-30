using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetkeyScript : MonoBehaviour
{
    public int KeyCount = 0;
    public GameObject Gate;
    public Image FadeOutCanvers;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Key")
        {
            KeyCount++;
            ToastMsg.Instrance.showMessage("키를 먹었습니다." + KeyCount.ToString() + "/3", 1.0f); ;

            Destroy(other.gameObject);

            if (KeyCount >= 3)
            {
                Invoke("GateOpen", 3f);
            }
            //other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "NextScene")
        {
            ToastMsg.Instrance.showMessage("가즈아!~~",3.0f);
            StartCoroutine(FadeOut());
            Invoke("EndingScene", 3f);
        }

    }

    void GateOpen()
    {
        ToastMsg.Instrance.showMessage("키를 모두 수집했습니다. 탈출구가 열렸습니다.", 3.0f);
        Gate.SetActive(true);
    }
    void EndingScene()
    {
        new WaitForSeconds(2);
        SceneManager.LoadScene("Ending");
    }
    IEnumerator FadeOut()
    {
        float fadeCount = 0;
        while (fadeCount < 1)
        {
            fadeCount += 0.02f;

            FadeOutCanvers.color = new Color(255, 255, 255, fadeCount);

            yield return new WaitForSeconds(0.01f);
        }
    }
}
