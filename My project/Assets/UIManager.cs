using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager current;
    public bool IsDragging;
    public DrawPredefined predefinedShape;
    public Image draggedImage;
    public Sprite stable;
    public Sprite oscillator;
    public Sprite spaceship;
    public Vector3 mousePosi;
    void Start()
    {
        current = this;
        draggedImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        draggedImage.transform.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
    }
    public void DrawShape(int shape)
    {
        predefinedShape = (DrawPredefined)shape;
        IsDragging = true;
        draggedImage.gameObject.SetActive(true);
        if (predefinedShape == DrawPredefined.stable)
        {
            draggedImage.sprite = stable;
        }
        else if (predefinedShape == DrawPredefined.Oscillator)
        {
            draggedImage.sprite = oscillator;
        }
        else if (predefinedShape == DrawPredefined.spaceship)
        {
            draggedImage.sprite = spaceship;
        }
        else
        {
            draggedImage.gameObject.SetActive(false);
        }
    }
    public void restartScene() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void disableDraggedImage()
    {
        draggedImage.gameObject.SetActive(false);
    }
}

public enum DrawPredefined
{
    none,
    stable,
    Oscillator,
    spaceship
}




