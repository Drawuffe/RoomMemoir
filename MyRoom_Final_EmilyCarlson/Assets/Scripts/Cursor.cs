using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSRBEngine : MonoBehaviour
{
    public bool Locked = true;

    // Start is called before the first frame update
    void Start()
    {
      if(Locked)
      {
          Cursor.lockState = CursorLockMode.Locked;
          Cursor.visible = false;

      }
        
    }
}

