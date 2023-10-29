using UnityEngine;
using UnityEngine.Profiling;

public class TestMemory : MonoBehaviour
{
    private void Start()
    {
        Invoke(nameof(Test), 3f);
    }

    private void Test()
    {
        Profiler.BeginSample("Create Custom Class");
        print(Profiler.GetTotalAllocatedMemoryLong());
        Profiler.EndSample();
    }
}
