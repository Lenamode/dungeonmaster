using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    // Animation Variables
    private Animator startButtonAnimator;
    private Animator playButtonAnimator;
    private Animator instructionsButtonAnimator;
    private Animator exitButtonAnimator;
    private Animator creditsButtonAnimator;
    private Animator backButtonAnimator;

    public Animation moveCam;

    //Button Variables
    private GameObject startButton;
    private GameObject playButton;
    private GameObject instructionsButton;
    private GameObject backButton;
    private GameObject exitButton;
    private GameObject creditsButton;
    private GameObject logo;
    private GameObject creditText;
    private GameObject introText;

    public void Start()
        {
            moveCam = this.gameObject.GetComponent<Animation>();
            startButtonAnimator = GameObject.Find("StartButton").GetComponent<Animator>();
            playButtonAnimator = GameObject.Find("PlayButton").GetComponent<Animator>();
            exitButtonAnimator = GameObject.Find("ExitButton").GetComponent<Animator>();
            creditsButtonAnimator = GameObject.Find("CreditsButton").GetComponent<Animator>();
            instructionsButtonAnimator = GameObject.Find("IntroButton").GetComponent<Animator>();

            logo = GameObject.Find("Logo");
            startButton = GameObject.Find("StartButton");
            playButton = GameObject.Find("PlayButton");
            exitButton = GameObject.Find("ExitButton");
            backButton = GameObject.Find("BackButton");
            instructionsButton = GameObject.Find("IntroButton");
            creditsButton = GameObject.Find("CreditsButton");
            creditText = GameObject.Find("CreditText");
            introText = GameObject.Find("IntroText");

            hideMe();
    }

    public void hideMe()
    {
        playButton.SetActive(false);
        exitButton.SetActive(false);
        instructionsButton.SetActive(false);
        creditsButton.SetActive(false);
        backButton.SetActive(false);
        logo.SetActive(false);
        creditText.SetActive(false);
        introText.SetActive(false);
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        showMe();
    }

        public void moveCamera()
    {
        
        startButtonAnimator.SetTrigger("Disabled");
        startButton.SetActive(false);
        StartCoroutine(wait());
        moveCam.Play("CamDown");
    }

        public void showCredits()
    {
        backButton.SetActive(true);
        creditText.SetActive(true);
        playButton.SetActive(false);
        exitButton.SetActive(false);
        instructionsButton.SetActive(false);
        creditsButton.SetActive(false);
    }

    public void showIntro()
    {
        backButton.SetActive(true);
        introText.SetActive(true);
        playButton.SetActive(false);
        exitButton.SetActive(false);
        instructionsButton.SetActive(false);
        creditsButton.SetActive(false);
    }

    public void showMe()
    {
        playButton.SetActive(true);
        exitButton.SetActive(true);
        instructionsButton.SetActive(true);
        creditsButton.SetActive(true);
        logo.SetActive(true);
        backButton.SetActive(false);
        creditText.SetActive(false);
        introText.SetActive(false);

    }

    public void exitMe()
    {
        Application.Quit();
    }
    }
