using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Coins2 : MonoBehaviour


{ public AudioSource audioSource;
      public Text coinText;
      public AudioSource coinSound;
      private int coinCount = 0;
      public int requiredCoins = 4;
     private void OnTriggerEnter(Collider other)
     {
      if (other.CompareTag("Coins"))
      {
        
         audioSource.Play();
         
         Destroy(other.gameObject);
          coinCount++;
         coinText.text = "Coins:" + coinCount.ToString();
         if ( coinCount >= requiredCoins)
         {
            SceneManager.LoadScene("Winningcondition");

         }
        
      }

     }
      private void   OnCollisionEnter(Collision other) {
         if (other.gameObject.CompareTag("obstacle"))
         {
            SceneManager.LoadScene("Losing");
         }
      }
         
        
     

        
        
     
     
        
     
    
    
    
        
    
}
