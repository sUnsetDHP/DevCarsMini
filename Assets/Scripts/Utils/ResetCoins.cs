using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCoins : MonoBehaviour
{
    public void Reset()
    {
        TotalReward.Instance.totalReward = 0;
        User.coins = 0;
    }
}
