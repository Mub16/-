using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class localization : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void swich(){
        //Общий код изменения языка в игре
    }
    public void swichUA(){
        XmlTextReader reader = new XmlTextReader("Data/loc.xml");
        //button.GetComponentInChildren<Text>().text = reader.IsStartElement("menu");

    }
    public void swichUSA(){
        XmlTextReader reader = new XmlTextReader("Data/loc.xml");
        //button.GetComponentInChildren<Text>().text = reader.IsStartElement("menu");
    }
}
