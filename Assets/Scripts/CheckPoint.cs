using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
   [SerializeField] private Transform userPosition;

   // Start is called before the first frame update
   void Start()
   {
       LoadData();

       userPosition.position = new Vector3 (PlayerPrefs.GetFloat("positionX", 700.3867f), PlayerPrefs.GetFloat("positionY", 77.83562f), PlayerPrefs.GetFloat("positionZ", -128.094f));
   }


   public void SaveData()
   {
       PlayerPrefs.SetFloat("positionX", userPosition.position.x);
       PlayerPrefs.SetFloat("positionY", userPosition.position.y);
       PlayerPrefs.SetFloat("positionZ", userPosition.position.z);
   }

   void OnTriggerEnter(Collider collider)
   {
        if (collider.gameObject.layer == 7)
        {
           SaveData(); 
        }
   }

   void LoadData()
   {
    PlayerPrefs.GetFloat("positionX", 700.3867f);
    PlayerPrefs.GetFloat("positionY", 77.83562f);
    PlayerPrefs.GetFloat("positionZ", -128.094f);
   }
}





