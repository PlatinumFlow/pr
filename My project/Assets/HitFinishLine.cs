using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class HitFinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject hitObj = collider.gameObject;

        if (hitObj.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}