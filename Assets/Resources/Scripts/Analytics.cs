using System.Collections;

using UnityEngine;

public class Analytics : MonoBehaviour
{
    private int updatesPerSecond;
    private int fixedUpdatesPerSecond;
    private int updateCount;
    private int fixedUpdateCount;

    private IEnumerator Co_MonitorCounts()
    {
        while (isActiveAndEnabled)
        {
            yield return new WaitForSeconds(1f);

            updatesPerSecond = updateCount;
            fixedUpdatesPerSecond = fixedUpdateCount;
            updateCount = fixedUpdateCount = 0;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() => StartCoroutine(Co_MonitorCounts());
    
    // Update is called once per frame
    void Update() => ++updateCount;

    void FixedUpdate() => ++fixedUpdateCount;

    public int UpdatesPerSecond => updatesPerSecond;
    
    public int FixedUpdatesPerSecond => fixedUpdatesPerSecond;
}
