using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ParticleDeactivate());
    }

    IEnumerator ParticleDeactivate()
    {
        yield return new WaitForSecondsRealtime(2);
        gameObject.SetActive(false);
    }
}





/*    
     
    //start ile Ienumerator kullanımını hoca beğenmedi, değiştirilecek
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(2);
        gameObject.SetActive(false);
    }
*/