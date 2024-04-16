using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
        public GameObject Player;
        public GameObject charModel;
        public GameManager gameManager;
        private void OnTriggerEnter(Collider other)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            Player.GetComponent<PlayerMove>().enabled = false;
            charModel.GetComponent<Animator>().Play("dying");
            

        }

    private IEnumerable WaitandRestart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameManager.GameOver();
    }
}
