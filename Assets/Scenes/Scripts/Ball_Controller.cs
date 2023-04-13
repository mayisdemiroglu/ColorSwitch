using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Ball_Controller : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;

    public string currentColor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorPurple;

    public SpriteRenderer sr;

    public int star;
    public TextMeshProUGUI starText;
    void Start()
    {
        randomColor();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Star")
        {
            star = star + 10;
            starText.text = star.ToString();
            Destroy(col.gameObject);
            return;
        }

        if(col.tag == "ColorChanger")
        {
            randomColor();
            Destroy(col.gameObject);
            return;
        }

        if(col.tag != currentColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void randomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
        } 
    }
}
