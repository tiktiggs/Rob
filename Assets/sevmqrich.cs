using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sevmqrich : MonoBehaviour
{
    public GameObject Sevmaqrich;
    public Image Kextotatam1;
    public Image Kextotatam2;
    public Image Kextotatam3;
    public Image Kextotatam4;

    public int kextotNum;

    public float SminX1, SmaxX1, SminY1, SmaxY1;
    public float SminX2, SmaxX2, SminY2, SmaxY2;
    public float SminX3, SmaxX3, SminY3, SmaxY3;
    public float SminX4, SmaxX4, SminY4, SmaxY4;

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
        if (Kextotatam1.GetComponent<Image>().color.a <= 0.05f && Kextotatam2.GetComponent<Image>().color.a <= 0.05f && Kextotatam3.GetComponent<Image>().color.a <= 0.05f && Kextotatam4.GetComponent<Image>().color.a <= 0.05f)
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
        }

    }
}
