using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    public void testFire()
    {
        Vector3 holder = player.gameObject.transform.localScale;
        player.gameObject.transform.localScale = new Vector3(holder.x * 1.2f, holder.y * 1.2f);
    }

    public void testMove()
    {
        Debug.Log("Moving");
    }
}
