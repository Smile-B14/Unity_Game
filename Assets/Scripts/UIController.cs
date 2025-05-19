using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject avatarImage;
    public GameObject myNameText;
    private bool active = false;
    public Image ColorChangingImage;
    private bool isRed = false;

    public void SwitchButtonMode()
    {
        avatarImage.SetActive(active);
        myNameText.SetActive(active);
        active = !active;
    }

    public void ChangeColor()
    {
        if (isRed)
        {
            ColorChangingImage.color = Color.red;
        }
        else
        {
            ColorChangingImage.color = Color.white;
        }

        isRed = !isRed;
    }
}
