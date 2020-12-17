using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mochi : MonoBehaviour
{

    [SerializeField]
    private int _hunger;
    [SerializeField]
    private int _happiness;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _mood;

    public AudioSource jumpSound;
   
    public bool isJump;

    private int _clickCount;

    private bool _serverTime;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("then", getStringTime());
        updateStatus();
        if (!PlayerPrefs.HasKey("name"))
        {
            PlayerPrefs.SetString("name", "Mochi");
            
        }
        _name = PlayerPrefs.GetString("name");

        if (_hunger >= 50)
        {
            if (_happiness >= 70)
            {
                _mood = "happy";
            }
            else if (_happiness > 50 && _happiness < 70)
            {
                _mood = "neutral";
            }
            else if (_happiness <= 50)
            {
                _mood = "sad";
            }
        }
        else
        {
            _mood = "angry";
        }

        InvokeRepeating("updateOverall", 10.0f, 60.0f);

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("jump", gameObject.transform.position.y > -2.9f);


        if (Input.GetMouseButtonUp(0))
        {

            Vector2 v = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(v), Vector2.zero);
            if (hit)
            {

                if(hit.transform.gameObject.tag == "mochi")
                {
                    _clickCount++;
                    if(_clickCount >= 3)
                    {
                        _clickCount = 0;
                        int rand = UnityEngine.Random.Range(1, 4);
                        updateHappiness(rand);
                        if (_hunger >= 50)
                        {
                            if (_happiness >= 70)
                            {
                                _mood = "happy";
                            }
                            else if (_happiness > 50 && _happiness < 70)
                            {
                                _mood = "neutral";
                            }
                            else if (_happiness <= 50)
                            {
                                _mood = "sad";
                            }
                        }
                        else
                        {
                            _mood = "angry";
                        }


                        if (rand == 1)
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
                            jumpSound.Play();
                        }else if(rand == 2)
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400));
                            jumpSound.Play();
                        }
                        else if(rand == 3)
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600));
                            jumpSound.Play();
                        }

                       
                    }
                }
            }
        }

    }

    public void randomize()
    {
        hunger = UnityEngine.Random.Range(1, 100);
        happiness = UnityEngine.Random.Range(1, 100);
        updateMood();
    }

    public void toy()
    {
        happiness += 5;
        if (happiness > 100)
        {
            happiness = 100;
        }

        if (_hunger >= 50)
        {
            if (_happiness >= 70)
            {
                _mood = "happy";
            }
            else if (_happiness > 50 && _happiness < 70)
            {
                _mood = "neutral";
            }
            else if (_happiness <= 50)
            {
                _mood = "sad";
            }
        }
        else
        {
            _mood = "angry";
        }
    }

    public void food()
    {
        hunger += 5;
        if (hunger > 100)
        {
            hunger = 100;
        }

        if (_hunger >= 50)
        {
            if (_happiness >= 70)
            {
                _mood = "happy";
            }
            else if (_happiness > 50 && _happiness < 70)
            {
                _mood = "neutral";
            }
            else if (_happiness <= 50)
            {
                _mood = "sad";
            }
        }
        else
        {
            _mood = "angry";
        }

    }

    void updateStatus()
    {
        if (!PlayerPrefs.HasKey("_hunger"))
        {
            _hunger = 100;
            PlayerPrefs.SetInt("_hunger", _hunger);
        }
        else
        {
            _hunger = PlayerPrefs.GetInt("_hunger");
        }

        if (!PlayerPrefs.HasKey("_happiness"))
        {
            _happiness = 100;
            PlayerPrefs.SetInt("_happiness", _happiness);
        }
        else
        {
            _happiness = PlayerPrefs.GetInt("_happiness");
        }

        if (!PlayerPrefs.HasKey("_mood"))
        {
            _mood = "neutral";
            PlayerPrefs.SetString("_mood", _mood);
        }
        else
        {
            _mood = PlayerPrefs.GetString("_mood");
        }

        if (!PlayerPrefs.HasKey("then"))
        {
            PlayerPrefs.SetString("then", getStringTime());
        }

        TimeSpan ts = getTimeSpan();
        _hunger -= (int)(ts.TotalHours * 2);
        if(_hunger < 0)
        {
            _hunger = 0;
        }
        _happiness -= (int)((100 - hunger) * (ts.TotalHours / 5));
        if(_happiness < 0)
        {
            _happiness = 0;
        }


        //Debug.Log(getTimeSpan().ToString());
        //Debug.Log(getTimeSpan().TotalHours);

        if (_serverTime)
        {
            updateServer();
        }
        else
        {
            InvokeRepeating("updateDevice", 0f, 30f);
        }
    }

        void updateServer()
        {

        }

        void updateDevice()
        {
        PlayerPrefs.SetString("then", getStringTime());
        }

        TimeSpan getTimeSpan()
    {
        if (_serverTime)
        {
            return new TimeSpan();
        }
        else
        {
            return DateTime.Now - Convert.ToDateTime(PlayerPrefs.GetString("then"));
        }
    }

        string getStringTime()
        {
        DateTime now = DateTime.Now;
        return now.Month + "/" + now.Day + "/" + now.Year + " " + now.Hour + ":" + now.Minute + ":" + now.Second;
        }

        public int hunger {
        get { return _hunger; }
        set { _hunger = value; }
    }

    public int happiness {
        get { return _happiness; }
        set { _happiness = value; }
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string mood
    {
        get { return _mood; }
        set { _mood = value; }
    }

    public void updateHappiness(int i)
    {
        happiness += i;
        if(happiness > 100)
        {
            happiness = 100;
        }

        if (_hunger >= 50)
        {
            if (_happiness >= 70)
            {
                _mood = "happy";
            }
            else if (_happiness > 50 && _happiness < 70)
            {
                _mood = "neutral";
            }
            else if (_happiness <= 50)
            {
                _mood = "sad";
            }
        }
        else
        {
            _mood = "angry";
        }
    }

    public void updateMood()
    {
        int rand = UnityEngine.Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                mood = "neutral";
                break;
            case 1:
                mood = "angry";
                break;
            case 2:
                mood = "sad";
                break;
            case 3:
                mood = "bored";
                break;
        }

    }

    public void updateOverall()
    {
        _hunger -= 1;
        
        _happiness -= (_happiness / _hunger);

        if (_hunger < 0)
        {
            _hunger = 0;
        }
        
        if (_happiness < 0)
        {
            _happiness = 0;
        }

        if (_hunger >= 50)
        {
            if (_happiness >= 70)
            {
                _happiness += 2;
                _mood = "happy";
            }
            else if (_happiness > 50 && _happiness < 70)
            {
                _happiness += 2;
                _mood = "neutral";
            }
            else if (_happiness <= 50)
            {
                _happiness += 2;
                _mood = "sad";
            }
        }
        else
        {
            _happiness -= 1;
            _mood = "angry";
        }
    }

    public void saveMochi()
    {
        if (!_serverTime)
            updateDevice();
        PlayerPrefs.SetInt("_hunger", _hunger);
        PlayerPrefs.SetInt("_happiness", _happiness);
        PlayerPrefs.SetString("_name", _name);
        PlayerPrefs.SetString("_mood", _mood);
        PlayerPrefs.SetString("then", getStringTime());
            }


}



