using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using TMPro;
using System.Globalization;

public class EncodingAndDecoding : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;
    public string inputString;
    [SerializeField] TextMeshProUGUI outputtxt;
    
   

    public void Update() 
    {
       
    }

    public void Start()
    {
        
    }

    public void encoding()
    {
        inputString = txt.text.ToString();
        List<char> charList = new List<char>();
        string encodingstring = "";
        charList.AddRange(inputString.ToCharArray());
        foreach (char character in charList)
        {
            int i = (int)character + 5;
            encodingstring = encodingstring + ((char)i);

        }
        outputtxt.text = encodingstring;
        

    }
    public void Decoding()
    {
        inputString = txt.text.ToString();
        List<char> charList = new List<char>();
        string encodingstring = "";
        charList.AddRange(inputString.ToCharArray());
        foreach (char character in charList)
        {
            int i = (int)character - 5;
            encodingstring = encodingstring + ((char)i);

        }
        outputtxt.text = encodingstring;
       
    }
    public void keyboradOpening()
    {
        TouchScreenKeyboard keyborad;
        keyborad = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
    public void clipBoardCopy()
    {

        inputString = outputtxt.text;
        txt.text = inputString;
    }


}

