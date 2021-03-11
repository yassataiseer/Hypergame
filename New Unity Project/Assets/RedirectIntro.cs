using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class RedirectIntro : MonoBehaviour
{   
    public void Redirect(string sceneName){
        Application.LoadLevel(sceneName);
    }
}
