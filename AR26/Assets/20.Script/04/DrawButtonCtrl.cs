using UnityEngine;
using TMPro;

public class DrawButtonCtrl : MonoBehaviour
{
     public TextMeshProUGUI dText;
     public DrawLines drawLines;
    int toggle = 0;

    public void ChangeMode()
    {
        toggle = (toggle + 1) % 2;
        if(toggle == 1)
        {
            dText.text = "Stop";
            drawLines.AllowDraw(true);
        }
        else
        {
            dText.text = "Draw";
            drawLines.AllowDraw(false);
        }
    }
}