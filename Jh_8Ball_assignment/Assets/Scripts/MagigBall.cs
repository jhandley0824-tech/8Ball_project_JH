using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MagigBall : MonoBehaviour
{
    private string[]Goodanswers={ "Yes","Your a Winner","Your Future is Looking Bright","Outlookgood",""};
    private string[]Badanswers={ "Try again never","NO","AskAgian","You Suck Try Again","Very Doughtful"};
    public TextMeshProUGUI answersText;

    [Range(0, 100)]
    public int probabilityForGoodAnswer;

    // Start is called before the first frame update
    void Start()
    {
        //answersText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rand = Random.Range(0, 100);

            if (probabilityForGoodAnswer > rand)
            {
                int index = Random.Range(0, Goodanswers.Length);
                answersText.text = Goodanswers[index];
            }
            else
            { 
                int index = Random.Range(0, Badanswers.Length);
                answersText.text = Badanswers[index];
            }

        }
    }
}


