using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class bestSavePosition : MonoBehaviour
{
    public float samplingRate = 1f; // sample rate in Hz
    public string outputFilePath;

    private StreamWriter _sw;

    public void OnEnable()
    {
        _sw = System.IO.File.AppendText(outputFilePath);
        InvokeRepeating("SampleNow", 0, 1 / samplingRate);
    }

    public void OnDisable()
    {
        _sw.Close();
        CancelInvoke();
    }

    public void SampleNow()
    {
        //_sw.WriteLine("t {0} x {1} z {2} fx {3} fz {4}",
        _sw.WriteLine("t {0} x {1} z {2} y {3}",
           //Time.time, transform.position.x, transform.position.z, transform.forward.x, transform.forward.z);
           Time.time, transform.position.x, transform.position.z, transform.position.y);
    }
}


