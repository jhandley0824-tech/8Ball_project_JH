using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MagigBall : MonoBehaviour
{
    private string[]answers={ "Yes","NO","AskAgian","Outlookgood","VeruDoughtful"};
    public TextMeshProUGUI answersText;

    // Start is called before the first frame update
    void Start()
    {
        //answersText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Input.GetKeyDown(KeyCode.Space))
        {
            int index=Random.Range(0,answers.Length);
            answersText.text = answers[index];
            

        }
      



    }






}


