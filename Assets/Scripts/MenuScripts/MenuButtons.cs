using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class PlayButton : MonoBehaviour
    {
        public void ChangeScene(int index)
        {
            //SceneManager.LoadScene("oynu_sahnesi");
            SceneManager.LoadScene(index);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    
   
    }
}
