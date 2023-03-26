using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SevMaqrich2 : MonoBehaviour
{
    public GameObject Sevmaqrich;
    public Image Kextotatam1;
    public Image Kextotatam2;
    public Image Kextotatam3;
    public Image Kextotatam4;
    public Image Kextotatam5;
    public Image Kextotatam6;
    public Image Kextotatam7;
    public Image Kextotatam8;


    public float SminX1, SmaxX1, SminY1, SmaxY1;
    public float SminX2, SmaxX2, SminY2, SmaxY2;
    public float SminX3, SmaxX3, SminY3, SmaxY3;
    public float SminX4, SmaxX4, SminY4, SmaxY4;
    public float SminX5, SmaxX5, SminY5, SmaxY5;
    public float SminX6, SmaxX6, SminY6, SmaxY6;
    public float SminX7, SmaxX7, SminY7, SmaxY7;
    public float SminX8, SmaxX8, SminY8, SmaxY8;

    float elapsed = 0f;

    public static bool clean;
    // Start is called before the first frame update
    void Start()
    {

        clean = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (Kextotatam1.GetComponent<Image>().color.a <= 0.05f && Kextotatam2.GetComponent<Image>().color.a <= 0.05f && Kextotatam3.GetComponent<Image>().color.a <= 0.05f && Kextotatam4.GetComponent<Image>().color.a <= 0.05f && Kextotatam5.GetComponent<Image>().color.a <= 0.05f && Kextotatam6.GetComponent<Image>().color.a <= 0.05f && Kextotatam7.GetComponent<Image>().color.a <= 0.05f && Kextotatam8.GetComponent<Image>().color.a <= 0.05f)
        {
            clean = true;
        }
        elapsed += Time.deltaTime;
        if (elapsed >= 0.005f)
        {
            elapsed = 0;
            if (Sevmaqrich.transform.localPosition.x >= SminX1 && Sevmaqrich.transform.localPosition.x <= SmaxX1 && Sevmaqrich.transform.localPosition.y >= SminY1 && Sevmaqrich.transform.localPosition.y <= SmaxY1)
            {
                Kextotatam1.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX2 && Sevmaqrich.transform.localPosition.x <= SmaxX2 && Sevmaqrich.transform.localPosition.y >= SminY2 && Sevmaqrich.transform.localPosition.y <= SmaxY2)
            {
                Kextotatam2.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX3 && Sevmaqrich.transform.localPosition.x <= SmaxX3 && Sevmaqrich.transform.localPosition.y >= SminY3 && Sevmaqrich.transform.localPosition.y <= SmaxY3)
            {
                Kextotatam3.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX4 && Sevmaqrich.transform.localPosition.x <= SmaxX4 && Sevmaqrich.transform.localPosition.y >= SminY4 && Sevmaqrich.transform.localPosition.y <= SmaxY4)
            {
                Kextotatam4.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX5 && Sevmaqrich.transform.localPosition.x <= SmaxX5 && Sevmaqrich.transform.localPosition.y >= SminY5 && Sevmaqrich.transform.localPosition.y <= SmaxY5)
            {
                Kextotatam5.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX6 && Sevmaqrich.transform.localPosition.x <= SmaxX6 && Sevmaqrich.transform.localPosition.y >= SminY6 && Sevmaqrich.transform.localPosition.y <= SmaxY6)
            {
                Kextotatam6.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX7 && Sevmaqrich.transform.localPosition.x <= SmaxX7 && Sevmaqrich.transform.localPosition.y >= SminY7 && Sevmaqrich.transform.localPosition.y <= SmaxY7)
            {
                Kextotatam7.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
            if (Sevmaqrich.transform.localPosition.x >= SminX8 && Sevmaqrich.transform.localPosition.x <= SmaxX8 && Sevmaqrich.transform.localPosition.y >= SminY8 && Sevmaqrich.transform.localPosition.y <= SmaxY8)
            {
                Kextotatam8.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
        }

    }
}
