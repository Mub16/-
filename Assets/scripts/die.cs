using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject Player;
    public GameObject Shild;
    public string name_object_shild = "";
    public string name_object = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Игрок прикоснулся к объекту
    private void OnTriggerEnter(Collider other) {
        if (other.name == name_object) {
            Player.transform.Translate(1, 1, 1);  
        }
        else if (other.name == name_object_shild) {
            Destroy(Shild);
        }
        print ("triger activation");
    }
    
    // Игрок перестал соприкосаться с объектом
    private void OnTriggerExit(Collider other) {

    }
}
