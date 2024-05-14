/*
Game mamanger Script
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SimonController : MonoBehaviour
{

    [SerializeField] List<SimonBtn> buttons;
    [SerializeField] List<int> sequence;
    [SerializeField] float delay;
    [SerializeField] int points;
    [SerializeField] bool playerTurn = false;

    [SerializeField]int counter = 0;
    [SerializeField] int level;

    [SerializeField] int numButtons;
    [SerializeField] GameObject ButtonPrefab;
    [SerializeField] Transform ButtonParent;
    [SerializeField] GameObject GameOverTxt;

    [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text levelTxt;
    [SerializeField] TMP_Text mainText;

        // Fake JSON string to simulate the data comming from the API
    public string apiData = @"
    {
        ""buttons"": [
            {
                ""id"": 0,
                ""r"": 1.0,
                ""g"": 0.0,
                ""b"": 0.5
            },
            {
                ""id"": 1,
                ""r"": 0.0,
                ""g"": 0.8,
                ""b"": 0.8
            },
            {
                ""id"": 2,
                ""r"": 0.7,
                ""g"": 0.9,
                ""b"": 0.1
            }
        ]
    }
    ";


    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "Simon Says";
        numButtons = 4;
        level = 1;
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
                    points++;
                    score.text = ("Score: " + points.ToString());
                    levelTxt.text = ("Level: " + level.ToString());
                    counter = 0;
                    if(points == numButtons && numButtons <= 8){
                        NewLevel();
                    }
                    AddToSequence();
                    
                }
        }
        else{
            Debug.Log("Game Over!");
            mainText.text = "Game Over!";
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


    void NewLevel(){
        DeleteButtons();
        sequence.Clear();

        points = 0;
        ++level;
        counter = 0;
        ++numButtons;
        PrepareButtons();
    }

    void DeleteButtons(){
    for(int i = 0; i < buttons.Count; i++){
       buttons[i].DestroyBtn();
    }
    buttons.Clear();
    
}

    public void Reset(){
        playerTurn = false;
        DeleteButtons();
        sequence.Clear();
        
        points = 0;
        level = 0;
        counter = 0;
        mainText.text = "Simon Says";
        score.text = "Score: 0" ;
        levelTxt.text = "Level: 1" ;
        numButtons = 4;
        PrepareButtons();

    }
}
