using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class plombich : MonoBehaviour
{
    public GameObject Plombich;
    public Image caries1;
    public Image caries2;
    public Image caries3;
    public Image caries4;



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
        if (caries1.GetComponent<Image>().color.a <= 0.05f && caries2.GetComponent<Image>().color.a <= 0.05f && caries3.GetComponent<Image>().color.a <= 0.05f && caries4.GetComponent<Image>().color.a <= 0.05f)
        {
            clean = true;
        }
        elapsed += Time.deltaTime;
        if (elapsed >= 0.01f)
        {
            elapsed = 0;
            if (Plombich.transform.localPosition.x >= SminX1 && Plombich.transform.localPosition.x <= SmaxX1 && Plombich.transform.localPosition.y >= SminY1 && Plombich.transform.localPosition.y <= SmaxY1)
            {
                if (caries1.GetComponent<Image>().color.a <= 0.6f)
                {
                    caries1.GetComponent<Image>().color -= new Color(0, 0, 0, 0.006f);
                }
            }
            if (Plombich.transform.localPosition.x >= SminX2 && Plombich.transform.localPosition.x <= SmaxX2 && Plombich.transform.localPosition.y >= SminY2 && Plombich.transform.localPosition.y <= SmaxY2)
            {
                if (caries2.GetComponent<Image>().color.a <= 0.6f)
                {
                    caries2.GetComponent<Image>().color -= new Color(0, 0, 0, 0.006f);
                }
            }
            if (Plombich.transform.localPosition.x >= SminX3 && Plombich.transform.localPosition.x <= SmaxX3 && Plombich.transform.localPosition.y >= SminY3 && Plombich.transform.localPosition.y <= SmaxY3)
            {
                if (caries3.GetComponent<Image>().color.a <= 0.6f)
                {
                    caries3.GetComponent<Image>().color -= new Color(0, 0, 0, 0.006f);
                }
            }
            if (Plombich.transform.localPosition.x >= SminX4 && Plombich.transform.localPosition.x <= SmaxX4 && Plombich.transform.localPosition.y >= SminY4 && Plombich.transform.localPosition.y <= SmaxY4)
            {
                if (caries4.GetComponent<Image>().color.a <= 0.6f)
                {
                    caries4.GetComponent<Image>().color -= new Color(0, 0, 0, 0.006f);
                }
            }
        }
    }
}
