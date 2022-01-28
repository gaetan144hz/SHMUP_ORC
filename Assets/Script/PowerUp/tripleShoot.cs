using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShoot : MonoBehaviour
{
    public GameObject player;

    Coroutine secondaryWeapon;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    private void OnColliderEnter2D(Collision2D collision)
    {
        //GameObject player = collision.gameObject;
        //playerScript = player.GetComponent<PlayerHealth>();

        if (collision.gameObject.tag == "Player")
        {
            secondaryWeapon = StartCoroutine(UpgradeShoot());
        }
    }

    IEnumerator UpgradeShoot()
    {
        while (true)
        {
            this.GetComponent<SecondaryWeapon>().enabled = true;
            yield return new WaitForSeconds(2);
            this.GetComponent<SecondaryWeapon>().enabled = false;
            StopCoroutine(secondaryWeapon);
        }
    }
}
