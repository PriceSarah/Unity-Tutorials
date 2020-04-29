using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenuBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(int sceneBuildIndex)
    {
        EditorSceneManager.LoadScene(sceneBuildIndex);
    }

}
