using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject _elmasPrefab;
    public float height;
    public float time;
    public int score;
    public Text scoreText;
    public Text TimeText;
    public float GameTime = 60;
    public bool oyunBittimi=false;
    public GameObject gameOverPanel;
    public GameObject otherPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnElmas(time));
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    private void Update()
    {
        GameTime -= Time.deltaTime;
        int time = Mathf.RoundToInt(GameTime);
        TimeText.text = time.ToString() + " sn";
        if (GameTime<=0 && oyunBittimi == false)
        {
            oyunBittimi=true;
        } 
        if (oyunBittimi == true)
        {
            StopAllCoroutines();
            gameOverPanel.SetActive(true);
            otherPanel.SetActive(false);
        }
        
    }
    public void updateScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
    
    public IEnumerator spawnElmas(float time)
    {
        while (true)
        {
            Instantiate(_elmasPrefab, new Vector3(Random.Range(-height, height), 10, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);//1sn bekle demek
        }
        
    } 
    public void oyunBitti()
    {
        SceneManager.LoadScene(0);
    }
    
}
