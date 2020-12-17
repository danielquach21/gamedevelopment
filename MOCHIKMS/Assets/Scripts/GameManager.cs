using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject happinessText;
    public GameObject hungerText;
    public GameObject mochi;
    public GameObject nameText;
    public GameObject namePanel;
    public GameObject nameInput;
    public GameObject mood;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        happinessText.GetComponent<Text>().text = "" + mochi.GetComponent<Mochi>().happiness;
        hungerText.GetComponent<Text>().text = "" + mochi.GetComponent<Mochi>().hunger;
        nameText.GetComponent<Text>().text = mochi.GetComponent<Mochi>().name;
        mood.GetComponent<Text>().text = mochi.GetComponent<Mochi>().mood;
    }

    public void triggerNamePanel(bool b)
    {
        namePanel.SetActive(!namePanel.activeInHierarchy);
        if (b)
        {
            mochi.GetComponent<Mochi>().name = nameInput.GetComponent<InputField>().text;
            PlayerPrefs.SetString("name", mochi.GetComponent<Mochi>().name);
        }
    }



    public void buttonBehavior(int i)
    {
        switch (i)
        {
            case (0):
            default:
                break;
            case (1):
                break;
            case (2):
                break;
            case (3):
                break;
            case (4):
                mochi.GetComponent<Mochi>().saveMochi();
                SceneManager.LoadScene("Credits");
                break;
        }
    }
}
