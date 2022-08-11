using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeConversion : MonoBehaviour
{
       
    public int hour, min, sec;
    public string format;
        
       void Start() {
            ConvertTimes();
        
       }
        public void ConvertTimes() 
        {
            
            if(format == "AM") {

                Debug.Log(hour + ":" + min + ":" + sec + format);
            }

            else {
                 hour += 12;
                 Debug.Log(hour + ":" + min + ":" + sec + format);
            }
            

            
        }
}
