using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class maqrich : MonoBehaviour
{
    public GameObject Maqrich;
    public GameObject jraqash;

    public Image Dexinatam1;
    public Image Dexinatam2;
    public Image Dexinatam3;
    public Image Dexinatam4;

    public Image jur;

    public float SminX1, SmaxX1, SminY1, SmaxY1;
    public float SminX2, SmaxX2, SminY2, SmaxY2;
    public float SminX3, SmaxX3, SminY3, SmaxY3;
    public float SminX4, SmaxX4, SminY4, SmaxY4;

    public float JminX1, JmaxX1, JminY1, JmaxY1;

    float elapsed = 0f;

    public static bool clean,cleanJur;
    // Start is called before the first frame update
    void Start()
    {
        clean = false;
        cleanJur = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dexinatam1.GetComponent<Image>().color.a <= 0.05f && Dexinatam2.GetComponent<Image>().color.a <= 0.05f && Dexinatam3.GetComponent<Image>().color.a <= 0.05f && Dexinatam4.GetComponent<Image>().color.a <= 0.05f)
        {
            clean = true;
        }
        if (Dexinatam1.GetComponent<Image>().color.a <= 0.05f && Dexinatam2.GetComponent<Image>().color.a <= 0.05f && Dexinatam3.GetComponent<Image>().color.a <= 0.05f && Dexinatam4.GetComponent<Image>().color.a <= 0.05f &&jur.GetComponent<Image>().color.a <= 0.05f)
        {
            cleanJur = true;
        }
        elapsed += Time.deltaTime;
        if (elapsed >= 0.01f)
        {
            elapsed = 0;
            if (Maqrich.transform.localPosition.x >= SminX1 && Maqrich.transform.localPosition.x <= SmaxX1 && Maqrich.transform.localPosition.y >= SminY1 && Maqrich.transform.localPosition.y <= SmaxY1)
            {
                Dexinatam1.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
                jur.GetComponent<Image>().color += new Color(0, 0, 0, 0.002f);
            }
            if (Maqrich.transform.localPosition.x >= SminX2 && Maqrich.transform.localPosition.x <= SmaxX2 && Maqrich.transform.localPosition.y >= SminY2 && Maqrich.transform.localPosition.y <= SmaxY2)
            {
                Dexinatam2.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
                jur.GetComponent<Image>().color += new Color(0, 0, 0, 0.002f);
            }
            if (Maqrich.transform.localPosition.x >= SminX3 && Maqrich.transform.localPosition.x <= SmaxX3 && Maqrich.transform.localPosition.y >= SminY3 && Maqrich.transform.localPosition.y <= SmaxY3)
            {
                Dexinatam3.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
                jur.GetComponent<Image>().color += new Color(0, 0, 0, 0.002f);
            }
            if (Maqrich.transform.localPosition.x >= SminX4 && Maqrich.transform.localPosition.x <= SmaxX4 && Maqrich.transform.localPosition.y >= SminY4 && Maqrich.transform.localPosition.y <= SmaxY4)
            {
                Dexinatam4.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
                jur.GetComponent<Image>().color += new Color(0, 0, 0, 0.002f);
            }

            if (jraqash.transform.localPosition.x >= JminX1 && jraqash.transform.localPosition.x <= JmaxX1 && jraqash.transform.localPosition.y >= JminY1 && jraqash.transform.localPosition.y <= JmaxY1)
            {
                jur.GetComponent<Image>().color -= new Color(0, 0, 0, 0.008f);
            }
        }
    }
}
