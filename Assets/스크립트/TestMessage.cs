using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMessage : MonoBehaviour
{
    private void OnMouseUp()
    {
        ToastMsg.Instrance.showMessage("마우스를 올렸습니다!", 2.0f);
    }
}
