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

    AudioSource audioSource;

    // Start is called before the first frame update
    public void Init(int index)
    {
        originalColor = GetComponent<Image>().color;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>($"Sounds/{index}");
    }


   public void Highlight(){
    //Change Color
    StartCoroutine(ChangeColor());
    audioSource.Play();

   }

   public void DestroyBtn(){
        Destroy(gameObject);
   }
   
   IEnumerator ChangeColor(){
    GetComponent <Image>().color = Color.white;
    yield return new WaitForSeconds(delay);
    GetComponent <Image>().color = originalColor;
   }
}
