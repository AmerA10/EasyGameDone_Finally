using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public static int score;
    public static int ScoreTreshHold;
    void Start()
    {
        score = 0;
        ScoreTreshHold = 5;
        text.text = "starting text";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;
    }
    public static void increaseScore()
    {
       score++;
    }
    public static void increaseTreshHold()
    {
        ScoreTreshHold += 5;
    }
}
