using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    //Create fields for Cell
    char letter;
    Color color;

    public Cell (char letter, Color color)
    {
        this.letter = letter;
        this.color = color;
    }       

}
