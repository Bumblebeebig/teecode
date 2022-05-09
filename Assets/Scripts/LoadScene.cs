using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load(int index)
    {
        SceneManager.LoadScene(index); 
        // nap scene level 1 bbbb
    }

}
