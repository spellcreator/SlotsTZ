using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    public int startBalance;
    private int currentBalance;

    public void TakeCoin(int coins)
    {
        currentBalance -= coins;
    }

    public void AddCoin(int coins)
    {
        currentBalance += coins;
    }
}
