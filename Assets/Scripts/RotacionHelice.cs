using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotacionHelice : MonoBehaviour
{
    public TextMeshProUGUI perdiste;
    public int rotacion= 1;
    // Start is called before the first frame update
    void Start()
    {
        perdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            rotacion += 1;
        }
        transform.Rotate(0,rotacion,0);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hubo colisión con la helice");
            Destroy(col.gameObject);
            perdiste.gameObject.SetActive(true);
        }
    }
}
