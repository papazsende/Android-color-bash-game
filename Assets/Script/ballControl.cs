using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ballControl : MonoBehaviour
{
    public float a;
    public AudioSource Pop;
    //rotation - * time.deltaTime
    public float speed;
    Rigidbody rb;
    public Color[] renk;
    public Text ScoreText;
    MeshRenderer topRengi;
    public bool hasGameStarted = false;
    float Points;
    public string currentBallColor;
    // Start is called before the first frame update
    void Start()
    {
        topRengi = gameObject.GetComponent<MeshRenderer>();
        rb = gameObject.GetComponent<Rigidbody>();
        randomColorPicker();
        Points = 0;
        hasGameStarted = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasGameStarted = true;

        }
        if (hasGameStarted) 
        {
            rb.useGravity = true;
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector3.up * speed;
                Pop.Play();
            }
        }

    }

    void randomColorPicker()
    {
        int RandInt;
        RandInt = Random.Range(0, 4);

        switch (RandInt)
        {
            case 0:
                topRengi.material.color = renk[0];
                currentBallColor = "Green";
                break;
            case 1:
                topRengi.material.color = renk[1];
                currentBallColor = "Purple";
                break;
            case 2:
                topRengi.material.color = renk[2];
                currentBallColor = "Yellow";
                break;
            case 3:
                topRengi.material.color = renk[3];
                currentBallColor = "Blue";
                break;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == currentBallColor)
        {
            Points = Points + 5;
            ScoreText.text = Points.ToString();
            randomColorPicker();
        }
        else
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }
}

