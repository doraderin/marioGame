using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioData : MonoBehaviour
{
    private int powerUp = 0;
    private int score = 0;

    public void Powered(){//powerUp arttırma
        if (powerUp <2){
            powerUp++;
        }
        score += 1000;
    }
    //powerUp = 0 : bebek Mario
    //powerUp = 1 : büyük Mario
    //powerUp = 2 : ateş Mario

    public void Ouch(){//powerUp azaltma
        if(powerUp >= 0){
            powerUp--;
        }
        else{
            //game over
        }
    }

    public int GetPP(){
        return (powerUp);
    }
}
