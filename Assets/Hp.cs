using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public Texture2D icon;
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 200, 50), icon);
    }
}
