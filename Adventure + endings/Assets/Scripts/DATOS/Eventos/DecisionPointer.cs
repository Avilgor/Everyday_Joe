using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionPointer : MonoBehaviour
{
    public int num;

    public void SaveOption()
    {
        DATOS.decisiones[DATOS.ArrayPointer] = num;
        DATOS.ArrayPointer++;
    }
}
