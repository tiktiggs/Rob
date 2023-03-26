using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipci : MonoBehaviour
{
    public GameObject Shipci;
    public GameObject Sevatam1;
    public GameObject Sevatam2;
    public GameObject Spitakatam1;
    public GameObject Spitakatam2;


    bool sev1;
    bool sev2;
    bool spitak2;
    bool spitak1;

    public float SminX, SmaxX, SminY, SmaxY, ShminX, ShmaxX, ShminY, ShmaxY;

    public static bool clean;
    // Start is called before the first frame update
    void Start()
    {

        clean = false;

        Spitakatam1.SetActive(false);
        Sevatam1.SetActive(true);
        Spitakatam2.SetActive(false);
        Sevatam2.SetActive(false);
        Spitakatam1.SetActive(false);

        sev1 = true;
        sev2 = false;
        spitak2 = false;
        spitak1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spitak1 == true)
        {
            clean = true;
        }
        if (sev1 == true && Shipci.transform.localPosition.x >= SminX && Shipci.transform.localPosition.x <= SmaxX && Shipci.transform.localPosition.y >= SminY && Shipci.transform.localPosition.y <= SmaxY)
        {
            //Sevatam1.transform.SetParent(Shipci.transform);
            Sevatam1.SetActive(false);
            Sevatam2.SetActive(true);
            sev1 = false;
            sev2 = true;
        }
        if (sev2 == true && Shipci.transform.localPosition.x >= ShminX && Shipci.transform.localPosition.x <= ShmaxX && Shipci.transform.localPosition.y >= ShminY && Shipci.transform.localPosition.y <= ShmaxY)
        {
            Sevatam2.SetActive(false);
            Spitakatam2.SetActive(true);
            sev2 = false;
            spitak2 = true;
        }
        if (spitak2 == true && Shipci.transform.localPosition.x >= SminX && Shipci.transform.localPosition.x <= SmaxX && Shipci.transform.localPosition.y >= SminY && Shipci.transform.localPosition.y <= SmaxY)
        {
            Spitakatam1.SetActive(true);
            Spitakatam2.SetActive(false);
            spitak2 = false;
            spitak1 = true;
        }

    }


}
