using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shild_activation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject Shild;
    private int time = 0;
    void Start()
    {
        Shild.transform.position = new Vector3 (100, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 0){
            Shild.transform.position = new Vector3 (100, 100, 100);
        }
        else {
            time--;
        }
    }
    public void activation(){
        time = time + 600;
        Shild.transform.position = Player.transform.position; 
    }
}
