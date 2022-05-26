using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontstop : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
