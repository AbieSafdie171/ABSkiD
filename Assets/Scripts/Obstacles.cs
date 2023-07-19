using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    AstronautPlayer astronautPlayer;

    public AudioSource treeSound;

    // Start is called before the first frame update
    void Start()
    {
        astronautPlayer = GameObject.FindObjectOfType<AstronautPlayer>();
    }

    private void OnTriggerEnter(Collider other){

            Debug.Log("Collision!!");
            if (gameObject != null)
                treeSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(astronautPlayer.transform.position);
    }
}
