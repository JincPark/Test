using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScritpt : MonoBehaviour
{
    public GameObject Gate;
    //public static bool NextScene = false;
    private void Awake()
    {
        Gate.SetActive(false);
    }
}
