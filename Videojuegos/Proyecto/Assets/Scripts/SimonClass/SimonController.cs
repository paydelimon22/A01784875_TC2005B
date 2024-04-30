/*
Game mamanger Script
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SimonController : MonoBehaviour
{

    [SerializeField] List<SimonBtn> buttons;
    [SerializeField] List<int> sequence;
    [SerializeField] float delay;
    [SerializeField] int level;
    [SerializeField] bool playerTurn = false;

    [SerializeField]int counter;

    // Start is called before the first frame update
    void Start()
    {
        PrepareButtons();
        StartCoroutine(PlaySequence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrepareButtons(){
        for(int i = 0; i <buttons.Count; i++){
            int index = i;
            buttons[i].gameObject.GetComponent<Button>().onClick.AddListener(() => ButtonPressed(index));
        }
        AddToSequence();
    }

    public void ButtonPressed(int index){
        if(playerTurn){
            if(index == sequence[counter]){
                counter ++;
                if(counter == sequence.Count){
                    level++;
                    counter = 0;
                    playerTurn = false;
                    AddToSequence();
                    StartCoroutine(PlaySequence());
                }
        }
        else{
            Debug.Log("Game Over!");
            }
        }
    }

    void AddToSequence(){
        sequence.Add(Random.Range(0, buttons.Count));
    }

    IEnumerator PlaySequence(){
        yield return new WaitForSeconds(delay);
        foreach (int index in sequence){
            buttons[index].Highlight();
            yield return new WaitForSeconds(delay);
        }
        playerTurn = true;
    }
}
