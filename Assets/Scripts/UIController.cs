using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //public GameObject avatarImage;
    //public GameObject myNameText;
    //private bool active = false;
    //public Image ColorChangingImage;
    //private bool isRed = false;

    //public void SwitchButtonMode()
    //{
    //    avatarImage.SetActive(active);
    //    myNameText.SetActive(active);
    //    active = !active;
    //}

    //public void ChangeColor()
    //{
    //    if (isRed)
    //    {
    //        ColorChangingImage.color = Color.red;
    //    }
    //    else
    //    {
    //        ColorChangingImage.color = Color.white;
    //    }

    //    isRed = !isRed;
    //}

    [SerializeField] private Button startBtn;
    [SerializeField] private Button optionBtn;
    [SerializeField] private Button menuBtn;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private TMP_Dropdown myDropdown;

    private void Start()
    {
        startBtn.onClick.AddListener(OnStartBtnClick);
        optionBtn.onClick.AddListener(OnOptionBtnClick);
        menuBtn.onClick.AddListener(OnMenuBtnClick);
        myDropdown.onValueChanged.AddListener(OnMyDropDownChanged);
    }

    private void OnStartBtnClick()
    {
        SceneManager.LoadScene(0);
    }

    private void OnOptionBtnClick()
    {
        startPanel.SetActive(false);
        optionPanel.SetActive(true);
    }

    private void OnMenuBtnClick()
    {
        startPanel.SetActive(true);
        optionPanel.SetActive(false);
    }

    private void OnMyDropDownChanged(int arg0)
    {
        Debug.Log(myDropdown.options[arg0]);
    }

}
