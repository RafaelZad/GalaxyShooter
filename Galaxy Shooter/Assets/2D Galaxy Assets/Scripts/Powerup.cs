using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
   
    [SerializeField]
    private int powerupID; // 0 = triple shot, 1 = speed boost, 2 = shield

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colidiu com: " + other.name);
       
        if(other.tag == "Player")
        {
            //access the player
            Player player = other.GetComponent<Player>();
        
            if(player != null)
            {   
                
                if (powerupID == 0)
                {
                    player.TripleShotPowerUpOn(); //enable triple shot
                }
                else if(powerupID == 1)
                {
                    player.SpeedBoostPowerUpOn(); //enable speed boost
                }
                else if(powerupID == 2)
                {
                    //enable shield
                }
                
             }

            Destroy(this.gameObject);

        }

        
          
    }    

}


