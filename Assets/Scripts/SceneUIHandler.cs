using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneUIHandler : MonoBehaviour
{
    public GameObject abstractDataViz;

    public void ToggleObject()
    {
        abstractDataViz.SetActive(!abstractDataViz.activeSelf);
    }
}
