using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button buttonAsterisk;
    public Button button0;
    public Button buttonHash;

    public Text codeText;
    private string _currentText = "";
    public string properKey = "2908";

    public Animator Lid;

    public bool wasSolved;

    public AudioSource openDoorSound;

    private AudioSource sound1;
    private AudioSource sound2;
    private AudioSource sound3;
    private AudioSource sound4;
    private AudioSource sound5;
    private AudioSource sound6;
    private AudioSource sound7;
    private AudioSource sound8;
    private AudioSource sound9;
    private AudioSource soundAsterisk;
    private AudioSource sound0;
    private AudioSource soundHash;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(ButtonClicked1);
        button2.onClick.AddListener(ButtonClicked2);
        button3.onClick.AddListener(ButtonClicked3);
        button4.onClick.AddListener(ButtonClicked4);
        button5.onClick.AddListener(ButtonClicked5);
        button6.onClick.AddListener(ButtonClicked6);
        button7.onClick.AddListener(ButtonClicked7);
        button8.onClick.AddListener(ButtonClicked8);
        button9.onClick.AddListener(ButtonClicked9);
        buttonAsterisk.onClick.AddListener(ButtonClickedAsterisk);
        button0.onClick.AddListener(ButtonClicked0);
        buttonHash.onClick.AddListener(ButtonClickedHash);

        sound1 = button1.GetComponent<AudioSource>();
        sound2 = button2.GetComponent<AudioSource>();
        sound3 = button3.GetComponent<AudioSource>();
        sound4 = button4.GetComponent<AudioSource>();
        sound5 = button5.GetComponent<AudioSource>();
        sound6 = button6.GetComponent<AudioSource>();
        sound7 = button7.GetComponent<AudioSource>();
        sound8 = button8.GetComponent<AudioSource>();
        sound9 = button9.GetComponent<AudioSource>();
        soundAsterisk = buttonAsterisk.GetComponent<AudioSource>();
        sound0 = button0.GetComponent<AudioSource>();
        soundHash = buttonHash.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = _currentText;

        if (_currentText == properKey)
        {
            //openDoorSound.Play();
            wasSolved = true;
            OpenDoor();
        }

        if (_currentText.Length >= 4)
        {
            _currentText = "";
        }
    }

    void OpenDoor()
    {
        Lid.SetBool("state", true);
    }

    public void AddDigit(string digit)
    {
        _currentText += digit;
    }

    private void ButtonClicked1()
    {
        sound1.Play();
        AddDigit("1");
    }
    
    private void ButtonClicked2()
    {
        sound2.Play();
        AddDigit("2");
    }
    
    private void ButtonClicked3()
    {
        sound3.Play();
        AddDigit("3");
    }
    
    private void ButtonClicked4()
    {
        sound4.Play();
        AddDigit("4");
    }
    
    private void ButtonClicked5()
    {
        sound5.Play();
        AddDigit("5");
    }
    
    private void ButtonClicked6()
    {
        sound6.Play();
        AddDigit("6");
    }
    
    private void ButtonClicked7()
    {
        sound7.Play();
        AddDigit("7");
    }
    
    private void ButtonClicked8()
    {
        sound8.Play();
        AddDigit("8");
    }
    
    private void ButtonClicked9()
    {
        sound9.Play();
        AddDigit("9");
    }
    
    private void ButtonClickedAsterisk()
    {
        soundAsterisk.Play();
        AddDigit("*");
    }
    
    private void ButtonClicked0()
    {
        sound0.Play();
        AddDigit("0");
    }
    
    private void ButtonClickedHash()
    {
        soundHash.Play();
        AddDigit("#");
    }
}

