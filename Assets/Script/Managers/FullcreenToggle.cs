using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullcreenToggle : MonoBehaviour
{
    public void OnClick(){ Screen.fullScreen = !Screen.fullScreen ? true : false; }
}
