/*
Highlight Selected Button and Reproduce Sound
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonBtn : MonoBehaviour
{

    Color originalColor;
    [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = GetComponent<Image>().color;
    }

   public void Highlight(){
    //Change Color
    StartCoroutine(ChangeColor());

   }

   IEnumerator ChangeColor(){
    GetComponent <Image>().color = Color.white;
    yield return new WaitForSeconds(delay);
    GetComponent <Image>().color = originalColor;
   }
}
