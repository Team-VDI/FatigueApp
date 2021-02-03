using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadData : MonoBehaviour
{
    public TextAsset dictionaryTextFile;
    private string theWholeFileAsOneLongString;
    private List<string> eachLine;

     public void datafile_read()
    {
        
    theWholeFileAsOneLongString = dictionaryTextFile.text;
     
     eachLine = new List<string>();
     eachLine.AddRange(
                 theWholeFileAsOneLongString.Split("\n"[0]) );
     
     Debug.Log(eachLine[0]);
     Debug.Log(eachLine[1]);
     Debug.Log(eachLine[2]);
     Debug.Log(eachLine[4]);
    }   
}