using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
   [SerializeField] private string userName;
   [SerializeField] private int userScore;
   [SerializeField] private Transform userPosition;
   // Start is called before the first frame update
   void Start()
   {
       LoadData();
   }


   public void SaveData()
   {
       PlayerPrefs.SetFloat("positionX", userPosition.x);
       PlayerPrefs.SetFloat("positionY", userPosition.y);
       PlayerPrefs.SetFloat("positionZ", userPosition.z);


       LoadData();
   }

   void OnTriggerEnter(Collider collider)
   {
        if (other.gameObject.layer == 7)
        {
           LoadData(); 
        }
   }

   void LoadData()
   {
    PlayerPrefs.GetFloat("positionX", 700.3867).ToString() + "x " +
    PlayerPrefs.GetFloat("positionY", 77.83562).ToString() + "y " +
    PlayerPrefs.GetFloat("positionZ", -128.094).ToString() + "z ";
   }
}





