 using UnityEngine;
 using System.Collections;
 using UnityEngine.Events;
 
     [System.Serializable]
     public class HealthEvent : UnityEvent<float> { };
 
  public class HealthUpdate : MonoBehaviour
  {
      public float health = 100.0f;
      public HealthEvent healthEvent ;
      private const float coef = 0.2f;
      
      void Update ()
      {
          health -= coef * Time.deltaTime;
          if( healthEvent != null )
              healthEvent.Invoke( health ) ;
      }        
  }
