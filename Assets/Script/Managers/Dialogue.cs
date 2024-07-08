using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// fix to acomodate for new Dialogue system
[System.Serializable]
public class Dialogue 
{
    public string name;
    [TextArea(1,5)]
    public string sentences;
}