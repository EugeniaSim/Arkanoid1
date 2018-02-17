using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDelete : MonoBehaviour {

    public int attempts;
    
    public bool Removal() {
        attempts--;
        if (attempts == 0) {
            return true;
        }
        return false;
    }

}
