using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PanelInfo : MonoBehaviour
{
    public new string name;
    public int age;
    public string job;
    public string musictaste;
    public string eyecolor;
    public string haircolor;
    public string passion1;
    public string passion2;
    public string passion3;
    public static int index;
    public static int matchPercentage;
   
    public Text name2;
    public Text age2;
    public Text job2;
    public Text musictaste2;
    public Text eyecolor2;
    public Text haircolor2;
    public Text passion12;
    public Text passion22;
    public Text passion32;

    public Text name3;
    public Text age3;
    public Text job3;
    public Text musictaste3;
    public Text eyecolor3;
    public Text haircolor3;
    public Text passion13;
    public Text passion23;
    public Text passion33;

    public Image agee;
    public Image musictastee;
    public Image eyecolorr;
    public Image haircolorr;
    public Image pasion1;
    public Image pasion2;
    public Image pasion3;
    public int parseage;


    public Informations info;
    public Informations[] infoData;

    private void Start()
    {
        name = info.name;
        age = info.age;
        job = info.job;
        musictaste = info.musictaste;
        eyecolor = info.eyecolor;
        haircolor = info.haircolor;
        passion1 = info.passion1;
        passion2 = info.passion2;
        passion3 = info.passion3;
        index = info.index;
        

        name2.text = name;
        age2.text = age.ToString();
        int.TryParse(age3.text, out parseage);
        job2.text = job;
        musictaste2.text = musictaste;
        eyecolor2.text = eyecolor;
        haircolor2.text = haircolor;
        passion12.text = passion1;
        passion22.text = passion2;
        passion32.text = passion3;


        index = 0;
        if (info.age > parseage)
        {
            agee.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!eyecolor2.text.Equals(eyecolor3.text))
        {
            agee.color = new Color32(255, 255, 255, 200);
        }


        if (eyecolor2.text.Equals(eyecolor3.text))
        {
            eyecolorr.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!eyecolor2.text.Equals(eyecolor3.text))
        {
            eyecolorr.color = new Color32(255, 255, 255, 200);
        }


        if (passion12.text.Equals(passion13.text)|| passion12.text.Equals(passion23.text)|| passion12.text.Equals(passion33.text))
        {
            pasion1.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
        }
        else if (!passion12.text.Equals(passion13.text) || passion12.text.Equals(passion23.text) || passion12.text.Equals(passion33.text))
        {
            pasion1.color = new Color32(255, 255, 255, 200);
        }


        if (musictaste2.text.Equals(musictaste3.text))
        {
            musictastee.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!musictaste2.text.Equals(musictaste3.text))
        {
            musictastee.color = new Color32(255, 255, 255, 200);
        }


        if (haircolor2.text.Equals(haircolor3.text))
        {
            haircolorr.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!haircolor2.text.Equals(haircolor3.text))
        {
            haircolorr.color = new Color32(255, 255, 255, 200);
        }



        if (passion22.text.Equals(passion23.text) || passion22.text.Equals(passion23.text) || passion22.text.Equals(passion33.text))
        {
            pasion2.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
        }
        else if (!passion22.text.Equals(passion23.text) || passion22.text.Equals(passion23.text) || passion22.text.Equals(passion33.text))
        {
            pasion2.color = new Color32(255, 255, 255, 200);
        }



        if (passion32.text.Equals(passion33.text) || passion32.text.Equals(passion23.text) || passion32.text.Equals(passion33.text))
        {
            pasion3.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
           
            
        }
        else if (!passion32.text.Equals(passion33.text) || passion32.text.Equals(passion23.text) || passion32.text.Equals(passion33.text))
        {
            pasion3.color = new Color32(255, 255, 255, 200);
        }

        matchPercentage = info.matchPercentage;
    }
    int i = 1;
    public void Change()
    {
        
        if (i==4)
        {
            i = 0;
            infoData[3].matchPercentage = 0;
            infoData[2].matchPercentage = 0;
            infoData[1].matchPercentage = 0;
            infoData[0].matchPercentage = 0;
        }
       
        info = infoData[i];
        name = info.name;
        age = info.age;
        job = info.job;
        musictaste = info.musictaste;
        eyecolor = info.eyecolor;
        haircolor = info.haircolor;
        passion1 = info.passion1;
        passion2 = info.passion2;
        passion3 = info.passion3;

        name2.text = name;
        age2.text = age.ToString();
        int.TryParse(age3.text, out parseage);
        job2.text = job;
        musictaste2.text = musictaste;
        eyecolor2.text = eyecolor;
        haircolor2.text = haircolor;
        passion12.text = passion1;
        passion22.text = passion2;
        passion32.text = passion3;
        
        index = i;
        i++;
        



        if (info.age>parseage)
        {
            agee.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!eyecolor2.text.Equals(eyecolor3.text))
        {
            agee.color = new Color32(255, 255, 255, 200);
        }


        if (eyecolor2.text.Equals(eyecolor3.text))
        {
            eyecolorr.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!eyecolor2.text.Equals(eyecolor3.text))
        {
            eyecolorr.color = new Color32(255, 255, 255, 200);
        }


        if (passion12.text.Equals(passion13.text) || passion12.text.Equals(passion23.text) || passion12.text.Equals(passion33.text))
        {
            pasion1.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
        }
        else if (!passion12.text.Equals(passion13.text) || passion12.text.Equals(passion23.text) || passion12.text.Equals(passion33.text))
        {
            pasion1.color = new Color32(255, 255, 255, 200);
        }

        if (musictaste2.text.Equals(musictaste3.text))
        {
            musictastee.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!musictaste2.text.Equals(musictaste3.text))
        {
            musictastee.color = new Color32(255, 255, 255, 200);
        }


        if (haircolor2.text.Equals(haircolor3.text))
        {
            haircolorr.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 10;
        }
        else if (!haircolor2.text.Equals(haircolor3.text))
        {
            haircolorr.color = new Color32(255, 255, 255, 200);
        }




        if (passion22.text.Equals(passion23.text) || passion22.text.Equals(passion23.text) || passion22.text.Equals(passion33.text))
        {
            pasion2.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
        }
        else if (!passion22.text.Equals(passion23.text) || passion22.text.Equals(passion23.text) || passion22.text.Equals(passion33.text))
        {
            pasion2.color = new Color32(255, 255, 255, 200);
        }



        if (passion32.text.Equals(passion33.text) || passion32.text.Equals(passion23.text) || passion32.text.Equals(passion33.text))
        {
            pasion3.color = new Color32(105, 255, 137, 200);
            info.matchPercentage += 20;
            
        }
        else if (!passion32.text.Equals(passion33.text) || passion32.text.Equals(passion23.text) || passion32.text.Equals(passion33.text))
        {
            pasion3.color = new Color32(255, 255, 255, 200);
        }
        matchPercentage = info.matchPercentage;
    }

}
