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

    [SerializeField]int counter = 0;

    [SerializeField] int numButtons;
    [SerializeField] GameObject ButtonPrefab;
    [SerializeField] Transform ButtonParent;
    [SerializeField] GameObject GameOverTxt;


    // Start is called before the first frame update
    void Start()
    {
        PrepareButtons();
    }

    void PrepareButtons(){
        for(int i = 0; i <numButtons; i++){
            int index = i;
            GameObject newButton = Instantiate(ButtonPrefab, ButtonParent);
            newButton.GetComponent<Image>().color = Color.HSVToRGB((float)index/numButtons,1,1);
            newButton.GetComponent<SimonBtn>().Init(index);
            buttons.Add(newButton.GetComponent<SimonBtn>());
            buttons[i].gameObject.GetComponent<Button>().onClick.AddListener(() => ButtonPressed(index));
        }
        AddToSequence();
    }

    public void ButtonPressed(int index){
        if(playerTurn){
            if(index == sequence[counter++]){
                buttons[index].Highlight();
                if(counter == sequence.Count){
                    playerTurn = false;
                    level++;
                    counter = 0;
                    AddToSequence();
                }
        }
        else{
            Debug.Log("Game Over!");
            }
        }
    }

    void AddToSequence(){
        sequence.Add(Random.Range(0, numButtons));
        StartCoroutine(PlaySequence());
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
