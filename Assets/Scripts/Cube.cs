using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float interval;
    
   

    public void ChangInvisibleState() => gameObject.SetActive(!gameObject.activeSelf);
}
