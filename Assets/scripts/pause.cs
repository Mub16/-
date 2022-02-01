using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public float timer;
    public bool ispuse;
    public bool guipuse;
public void stop(){
Time.timeScale = timer;
   if (Input.GetKeyDown(KeyCode.Escape) && ispuse == false)
  {
   ispuse = true;
  }
   else if (Input.GetKeyDown(KeyCode.Escape) && ispuse == true)
  {
   ispuse = false;
  }
   if (ispuse == true)
  {
   timer = 0;
   guipuse = true;

  }
  else if (ispuse == false)
  {
   timer = 1f;
   guipuse = false;

  }
 }
 public void OnGUI()
  {
   if (guipuse == true)
   {
    Cursor.visible = true;// включаем отображение курсора
     if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 150f, 150f, 45f), "<-"))
     {
       ispuse = false;
       timer = 0;
       Cursor.visible = false;
     }
    if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), 150f, 45f), "0"))
     {
      ispuse = false;
      timer = 0;
      Application.LoadLevel("SampleScene"); // здесь при нажатии на кнопку загружается другая сцена

     }
   }
}
void Update()
{
    stop();
 }
 public void triger_stop(){
     ispuse = true;
     //stop();
   if (ispuse == true)
  {
   timer = 0;
   guipuse = true;

  }
  else if (ispuse == false)
  {
   timer = 1f;
   guipuse = false;

  }
}
}