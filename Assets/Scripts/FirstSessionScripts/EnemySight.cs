
using UnityEngine;

public class EnemySight : MonoBehaviour
{
    
    public bool PlayerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerShipTag")
        {
            //Debug.Log("detected01");
            PlayerDetected = true;
            GetComponentInParent<EnemyAttack>().EnemyShooting(PlayerDetected);
        }
        else
        {
            //Debug.Log("Error");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "playerShipTag")
        {
            //Debug.Log("out of sight");
            PlayerDetected = false;
        }
    }

}
