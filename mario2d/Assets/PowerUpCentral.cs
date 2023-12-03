using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCentral : MonoBehaviour
{
    public MarioData MD;

    void Start(){
        MD = GameObject.FindWithTag("Player").GetComponent<MarioData>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            MD.Powered();
            Destroy(this.gameObject);
        }
    }
}
