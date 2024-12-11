using UnityEngine.SceneManagement;
using UnityEngine;

public class Levelhandler : MonoBehaviour
{
   public void level1(){
    SceneManager.LoadScene("Level1");
   }
   public void instrucions(){
    SceneManager.LoadScene("instructions");
   }
}
