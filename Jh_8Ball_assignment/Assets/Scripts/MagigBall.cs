using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagigBall : MonoBehaviour
{
    private string[]answers={ "Yes","NO","AskAgian","Outlookgood","VeruDoughtful"};
    //public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text = GetComponent<TextMeshProUGUI>();

       if(Input.GetKeyDown(KeyCode.Space))
        {
            int index=Random.Range(0,answers.Length);
            answersText.text = answers[index];
            

        }
       







    }

    











}


