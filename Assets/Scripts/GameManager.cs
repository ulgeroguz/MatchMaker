using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public List<GameObject> WaitingList;
    public GameObject backto;
    public GameObject PanelOpener;
    public Animator FirstScenePanelScroll;
    public Animator SecondScenePanelScroll;
    public Animator anim;
    public Camera Secondcam;
    public GameObject NextButton;
    public GameObject NextButton2;

    public GameObject FirstPanelGroup;
    public GameObject SecondPanelGroup;
    public GameObject acceptrejectbutton;
    public Slider LoveMeter;
    public GameObject LoveMeterObj;
    private bool maxVal;
    private bool minVal = true;
    public ParticleSystem Heartparticle;
    public ParticleSystem BrokenHparticle;
    public ParticleSystem Skull;
    public ParticleSystem AngerParticle;
    public ParticleSystem brokenheartparticle;
    public ParticleSystem firework1;
    public ParticleSystem firework2;
    public ParticleSystem firework3;
    public ParticleSystem sadface;

    public List<GameObject> EmptyHearts;
    public List<GameObject> FullHearts;
    public GameObject HeartObj;

    public GameObject WinUI;
    public GameObject FailUI;

    public GameObject Popup;
    public Text PopupText;

    public Informations info;
    public Informations[] infoData;
    public Animator CAmAnim;
    public Animator DateAnim;
    public GameObject DatePerson;
    
    public Animator WaitingDateAnim;
    public GameObject WaitingDate;

    public GameObject chair1;
    public GameObject chair2;

    public List<Image> FailCountdown;

    // Start is called before the first frame update
    void Start()
    {


        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
       
        if (sceneName=="DateScene")
        {
            
            WaitingList[PanelInfo.index].SetActive(true);
            WaitingDate = WaitingList[PanelInfo.index];
           
            if (PanelInfo.matchPercentage<50)
            {
                DatePerson.transform.position =new Vector3(-21.088f, DatePerson.transform.position.y, DatePerson.transform.position.z);
                DateAnim.SetTrigger("Anger");
                
                chair2.SetActive(false);
                chair1.SetActive(false);
               
                WaitingDateAnim =WaitingList[PanelInfo.index].GetComponent<Animator>();
                WaitingDateAnim.SetTrigger("Rejected");
                WaitingDate.transform.position = new Vector3(-19.67f, DatePerson.transform.position.y, DatePerson.transform.position.z);
                LoveMeterObj.SetActive(false);
                HeartObj.SetActive(false);

                Invoke("RejectParticles",2);
                
            }
        }
    }
    public void RejectParticles()
    {
        Skull.Play();
        AngerParticle.Play();
        brokenheartparticle.Play();

        Invoke("FailedUI", 3);
        
    }

    public void FailedUI()
    {
        FailUI.SetActive(true);
        InvokeRepeating("FailCount", 1, 2);
    }
    int c = 0;
    public void FailCount()
    {
        FailCountdown[c].enabled = false;
        FailCountdown[c+1].enabled =true;
        c++;
        if (c==4)
        {
            CancelInvoke("FailCount");
        }
    }

    int count = 0;
    public void Next()
    {
        if (count > 3)
        {
            count = 0;

        }
            WaitingList[count].SetActive(false);
            WaitingList[count+1].SetActive(true); 
            count += 1;



    }
    public void FirstPanelUp()
    {
        PanelOpener.SetActive(false);
        FirstScenePanelScroll.SetBool("Scroll", true);
        acceptrejectbutton.SetActive(true);
     


    }
    public void Scroll()
    {
        anim.SetBool("Scroll", false);
    }

    public void SecondSceneOpen()
    {
        Secondcam.enabled = true;
        FirstPanelGroup.SetActive(false);
        SecondPanelGroup.SetActive(true);
        SecondScenePanelScroll.SetBool("Scroll", true);
        NextButton.SetActive(true);
        acceptrejectbutton.SetActive(false);
        backto.SetActive(true);
        NextButton2.SetActive(false);
       


    }
    public void BackTo()
    {
        Secondcam.enabled = false;
        FirstPanelGroup.SetActive(true);
        SecondPanelGroup.SetActive(false);
        FirstScenePanelScroll.SetBool("Scroll", true);
        NextButton.SetActive(false);
        NextButton2.SetActive(true);
        backto.SetActive(false);

    }
    public void ClosePopup()
    {
        Popup.SetActive(false);
    }
    public void OpenDate()
    {
        SceneManager.LoadScene("DateScene");
    }

    public void Match()
    {
        Popup.SetActive(true);

        if (PanelInfo.matchPercentage<50)
        {
            PopupText.text = "Match is less than 50%. Do you still want to match them?";
        }
        else
        {
            PopupText.text = "Your match is "+ PanelInfo.matchPercentage + "%. Do you still want to match them?";
        }
       
        Debug.Log(PanelInfo.matchPercentage + " are you cola?");

        
    }
    public void Win()
    {
        WinUI.SetActive(true);
    }
    // Update is called once per frame
    float countBitTime;
    int countHeart = 1;
    void Update()
    {
        if (LoveMeterObj.activeSelf/*&&attackMeterGameObj!=null*/)
        {

            //attackMeter.value = Mathf.PingPong(Time.unscaledTime, attackMeter.maxValue);
            if (minVal)
            {
                LoveMeter.value += Time.unscaledDeltaTime * 0.9f;
                if (LoveMeter.value == LoveMeter.maxValue)
                {
                    minVal = false;
                    maxVal = true;
                    countBitTime++;
                }
            }
            if (maxVal)
            {
                LoveMeter.value -= Time.unscaledDeltaTime * 0.9f;
                if (LoveMeter.value == LoveMeter.minValue)
                {
                    maxVal = false;
                    minVal = true;
                   countBitTime++;
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (LoveMeter.value > 0.3f && LoveMeter.value < 0.7f)
                {
                    Debug.Log("naber kanka");
                    Heartparticle.Play();
                    EmptyHearts[countHeart].SetActive(false);
                    FullHearts[countHeart].SetActive(true);
                    countHeart += 1;
                    if (countHeart==6)
                    {
                        HeartObj.SetActive(false);
                        LoveMeterObj.SetActive(false);
                        firework1.Play();
                        firework2.Play();
                        firework3.Play();
                        CAmAnim.SetTrigger("Win");
                        Invoke("Win", 5);

                    }
                }
                else
                {
                    countHeart -= 1;
                    BrokenHparticle.Play();
                    EmptyHearts[countHeart].SetActive(true);
                    FullHearts[countHeart].SetActive(false);
                    if (countHeart==0)
                    {
                        HeartObj.SetActive(false);
                        LoveMeterObj.SetActive(false);
                        BrokenHparticle.Play();
                        sadface.Play();
                        Invoke("FailedUI", 2);
                    }
                    
                }
                
            } 
           
        }
    }
}
