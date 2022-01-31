using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public string name_object = "";
    public Transform vectory_animation;
    public Transform player;
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
            print (name_object+""+player.transform.position);
            vectory_animation.transform.position = player.transform.position;
        }
        print ("triger activation");
    }
    
    // Игрок перестал соприкосаться с объектом
    private void OnTriggerExit(Collider other) {
        SceneManager.LoadScene("level_0");
    }
}
