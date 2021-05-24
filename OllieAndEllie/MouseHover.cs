using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    private Color onColor;
    private Color offColor;
    public bool isStart;
    public bool isQuit;

    void Start()
    {
        onColor = new Color(1, 1, 1);
        offColor = new Color(0.7f, 0.6f, 0.2f);
        GetComponent<TextMesh>().color = offColor;
        
    }

    private void OnMouseEnter()
    {
        GetComponent<TextMesh>().color = onColor;
    }

    private void OnMouseExit()
    {
        GetComponent<TextMesh>().color = offColor;

    }

    private void OnMouseUp()
    {
        if (isStart)
        {
            SceneManager.LoadScene(1);
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }
}
