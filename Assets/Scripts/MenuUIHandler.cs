using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    private InputField inputField;
    
    private string playerName;
//encapsulation
    public string PlayerName
    {
        get { return playerName; }
        set 
        { 
            playerName = value; 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void SaveName()
    {
        playerName = inputField.text;
    }
}
