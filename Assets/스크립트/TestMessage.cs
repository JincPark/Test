using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMessage : MonoBehaviour
{
    private void OnMouseUp()
    {
        ToastMsg.Instrance.showMessage("���콺�� �÷Ƚ��ϴ�!", 2.0f);
    }
}
