using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Number : MonoBehaviour
{
    public int value;
    private void change(float black, Color color)
    {
        color.Change(black);   
    }

    // Start is called before the first frame update
    void Start()
    { 
        value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshPro>().text = value.ToString();
    }
}
