using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{

    public AudioSource pickupsfx;

    public Renderer rend;

    public Renderer rend2;

    void Start()
    {
        if (gameObject.name != "X-Factor" && gameObject.name != "X-Factor(Clone)"){
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other){

        // Debug.Log(gameObject.name);

        if (other.gameObject.name != "Player"){
            return;
        }
        pickupsfx.Play();
        if (gameObject.name != "X-Factor" && gameObject.name != "X-Factor(Clone)"){
            rend.enabled = false;}
        else {
            rend.enabled = false;
            rend2.enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
    }
}
