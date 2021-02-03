using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene_Change : MonoBehaviour
{
    public int scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
