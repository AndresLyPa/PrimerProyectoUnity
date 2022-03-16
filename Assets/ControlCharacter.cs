using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour
{
    public GameObject characterPrincipal;
    public float velocidad = 20f;
    public GameObject Bala;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(-3.452276F, 0.1900001F, -3.704882F);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.forward * Time.deltaTime;
        }
        //Cuando presione La tecla DOWN el carro avanza hacia atrás o en reversa
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position -= transform.forward * Time.deltaTime;
        }
        //Cuando presione La tecla RIGHT
        if (Input.GetKey(KeyCode.RightArrow)) {
            //transform.position += vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //Cuando presione La tecla LEFT
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //transform.position -= vector3.right * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);
        }    
        //Cuando presione La tecla space hago un disparo
        if (Input.GetKey(KeyCode.Space)) {
            Instantiate(Bala, transform.position, transform.rotation);
        }
        //Cuando presione La tecla A hago un turbo
        if (Input.GetKeyDown(KeyCode.A)) {
            transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }
    }
}
