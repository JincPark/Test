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
            ToastMsg.Instrance.showMessage("Ű�� �Ծ����ϴ�." + KeyCount.ToString() + "/3", 1.0f); ;

            Destroy(other.gameObject);

            if (KeyCount >= 3)
            {
                Invoke("GateOpen", 3f);
            }
            //other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "NextScene")
        {
            ToastMsg.Instrance.showMessage("�����!~~",3.0f);
            StartCoroutine(FadeOut());
            Invoke("EndingScene", 3f);
        }

    }

    void GateOpen()
    {
        ToastMsg.Instrance.showMessage("Ű�� ��� �����߽��ϴ�. Ż�ⱸ�� ���Ƚ��ϴ�.", 3.0f);
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
