using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeScript : MonoBehaviour
{
    public void OnNextClicked()
    {
        SceneManager.LoadScene("ChooseTeamScene");
    }
}
