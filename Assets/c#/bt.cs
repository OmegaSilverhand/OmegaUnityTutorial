using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour

{
    public bool ishit;
    public Counter counter;

    public void OnButtonClick()
    {
        if (Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x) <= 20 && !ishit)
        {
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();
        

        }


    }

    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        ishit = false;
    }


}
