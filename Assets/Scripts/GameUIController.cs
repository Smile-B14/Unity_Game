using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private Button menuBtn;
    [SerializeField] private Button startBtn;
    [SerializeField] private Button optionBtn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionPanel.SetActive(!optionPanel.activeSelf);
        }
    }

    private void Start()
    {
        menuBtn.onClick.AddListener(OnMenuBtnClick);
        startBtn.onClick.AddListener(OnStartBtnClick);
        optionBtn.onClick.AddListener(OnOptionBtnClick);
    }

    private void OnMenuBtnClick()
    {
         startPanel.SetActive(true);
         optionPanel.SetActive(false);
    }

    private void OnOptionBtnClick()
    {
        startPanel.SetActive(false);
        optionPanel.SetActive(true);
    }

    private void OnStartBtnClick()
    {
        SceneManager.LoadScene(0);
    }
}
