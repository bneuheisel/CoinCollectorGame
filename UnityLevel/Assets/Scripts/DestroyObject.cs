using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }
    void OnTriggerEnter (Collider coll)
    {
        if(coll.gameObject.name == "Player")
        {
            Destroy(this.gameObject);

            int score = int.Parse(scoreGT.text);
            score += 1;
            scoreGT.text = score.ToString();
            if (scoreGT.text == "10")
            {
                SceneManager.LoadScene("GameOver");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
