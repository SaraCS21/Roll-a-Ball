using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerControler : MonoBehaviour
{
    public TMP_Text countText;
    public TMP_Text winText;

    private Rigidbody rb;
    private int count;

    private float movementX;
    private float movementY;

    public float speed = 10.0f;
    public string nextSceneName;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();

        rb = GetComponent<Rigidbody>();

        winText.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            audioManager.PlaySFX(audioManager.stunned);
            Destroy(gameObject);

            winText.gameObject.SetActive(true);
            winText.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnJump(InputValue jumpValue)
    {
        audioManager.PlaySFX(audioManager.jump);
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    void Update()
    {
        if (winText.gameObject.activeSelf)
        {
            UnlockNewLevel();
        }

        // Permitir al jugador avanzar a la siguiente escena después de ganar
        if (winText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.N))
        {
            LoadNextScene();
        }
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("PickUp"))
        {
            audioManager.PlaySFX(audioManager.coin);

            other.gameObject.SetActive(false);

            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString() + " / 12";

        if (count >= 12)
        {
            winText.gameObject.SetActive(true);
            SceneController.instance.NextLevel();

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    // Función para cargar la siguiente escena
    void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex); // Cargar la siguiente escena por índice
        
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
