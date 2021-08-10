using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabs : MonoBehaviour

{
    public Animator PI;
    public GameObject heart;
    public Animator Prefences;
    public Animator Passion;

    public Animator Personalinf;
    public Animator Qualification;

    
    // Start is called before the first frame updatsse
    void Start()
    {
        
    }
    public void ScrollSelf()
    {
        PI.SetBool("Scroll", false);
        Prefences.SetBool("Scroll", false);
        Passion.SetBool("Scroll", false);
        heart.SetActive(true);
    }
    public void ScrollPersonalInfo()
    {

        PI.SetBool("Scroll", true); 
        Prefences.SetBool("Scroll", false);
        Passion.SetBool("Scroll", false);
        


    }
    public void ScrollPrefences()
    {

        Prefences.SetBool("Scroll", true);
        PI.SetBool("Scroll", false);
        
        Passion.SetBool("Scroll", false);



    }
    public void ScrollPassion()
    {

        Passion.SetBool("Scroll", true);
        Prefences.SetBool("Scroll", false);
        PI.SetBool("Scroll", false);

        



    }

    public void ScrollQualification()
    {
        Personalinf.SetBool("Scroll", false);
        Qualification.SetBool("Scroll", true);

    }
    public void ScrollPI()
    {
        Personalinf.SetBool("Scroll", true);
        Qualification.SetBool("Scroll", false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
