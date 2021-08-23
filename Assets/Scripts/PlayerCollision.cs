using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Enemy")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
         
        if(collisionInfo.collider.tag =="Last")
        {
            SceneManager.LoadScene("End_Credits");
            Debug.Log("Last");
        }
    }
}
