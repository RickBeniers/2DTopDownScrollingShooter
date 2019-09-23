
using UnityEngine;

public class EnemySight : MonoBehaviour
{
    [SerializeField]
    private bool PlayerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerShipTag")
        {
            Debug.Log("detected");
            PlayerDetected = true;
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
            PlayerDetected = false;
        }
    }

}
