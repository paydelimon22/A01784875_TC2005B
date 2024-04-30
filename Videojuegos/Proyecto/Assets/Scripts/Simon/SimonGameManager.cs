using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonGameManager : MonoBehaviour
{
    public List<int> gameSequence;
    public List<int> playerSequence;
    public int Score;
    bool gameOver;
    bool isPlaying;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePlayerSequence([SerializeField]int btn)
    {
        playerSequence.Add(btn);
    }

    public void UpdateGameSequence()
    {
        int randAdd = Random.Range(1, 9);
        gameSequence.Add(randAdd);
    }

    public void playSound([SerializeField] AudioSource key){
        key.Play();
    }
}
