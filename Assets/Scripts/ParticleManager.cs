using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    //start ile Ienumerator kullanımını hoca beğenmedi, değiştirilecek
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(2);
        gameObject.SetActive(false);
    }

}
