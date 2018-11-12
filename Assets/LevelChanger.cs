using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;

    public void fadeToLevel()
    {
        animator = this.gameObject.GetComponent<Animator>();
        animator.SetTrigger("FadeOut");
    }

    public void fadeComplete(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
