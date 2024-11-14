using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public TMP_Text countText;
    public TMP_Text winText;
    private int count;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        count = 0;
        SetCountText();

        winText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {            
            audioManager.PlaySFX(audioManager.coin);
            
            count++; 
            SetCountText(); 
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (winText.gameObject.activeSelf)
        {
            UnlockNewLevel();
        }

        // Permitir al jugador avanzar a la siguiente escena despu�s de ganar
        if (winText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.N))
        {
            LoadNextScene();
        }
    }

    private void SetCountText()
    {
        countText.text = count.ToString() + " / 12";
        
        if (count >= 12)
        {
            winText.gameObject.SetActive(true);
            SceneController.instance.NextLevel();
        }
    }

        // Funci�n para cargar la siguiente escena
    void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex); // Cargar la siguiente escena por �ndice
        
    }

    void UnlockNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}
