using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionBoton : MonoBehaviour
{
    public int rotacion = 1;
    // Start is called before the first frame update
    
    public void ResetAll (){
        transform.Rotate(0,1,0);
    }
}
