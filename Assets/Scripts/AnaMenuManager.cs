using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnaMenuManager : MonoBehaviour
{
    public GameObject _shopPanel;
    public GameObject _AnaMenuPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region AnaMenuMethodlari
    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MarketeGit()
    {
        _shopPanel.SetActive(true);
        _AnaMenuPanel.SetActive(false);
    }
    public void OyunuBitir()
    {
        Application.Quit();
    }
    #endregion
    #region MaerketMethodlari
    public void AnaMenuyeDon()
    {
        _shopPanel.SetActive(false);
        _AnaMenuPanel.SetActive(true);
    }
    #endregion

}
