using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeping : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreCard;
    // Start is called before the first frame update
    void Start()
    {
        scoreCard.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
