using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonGameManager : MonoBehaviour
{
    public List<int> gameSequence;
    public List<int> playerSequence;
    [SerializeField] int keyInt;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSequence([SerializeField]int btn)
    {
        playerSequence.Add(btn);
    }

    public void playSound([SerializeField] AudioSource key){
        key.Play();
    }
}
