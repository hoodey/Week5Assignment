using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class View : MonoBehaviour
{
    //Array to hold each row and square for updating
    [SerializeField] GameObject[] rows;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateView(Color[] colorz, char[] letterz)
    {
        GameObject imageChildren;
        GameObject boxChildren;

        for (int i = 0; i < 5; i++)
        {
            imageChildren = rows[Model.numGuesses].transform.GetChild(i).gameObject;
            Graphic i_Graphic = imageChildren.GetComponent<Graphic>();
            i_Graphic.color = colorz[i];

            boxChildren = imageChildren.transform.GetChild(0).gameObject;
            TMP_Text i_Text = boxChildren.GetComponent<TMP_Text>();
            i_Text.text = letterz[i].ToString();
        }
    }

}
