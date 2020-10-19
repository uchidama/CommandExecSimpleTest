using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class CommandExec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var arguments = "test.txt";
        var exProcess = new Process();
        exProcess.StartInfo.CreateNoWindow = true;
        exProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        exProcess.StartInfo.FileName = "/usr/bin/touch";
        exProcess.StartInfo.Arguments = arguments;
        exProcess.EnableRaisingEvents = true;

        //外部のプロセスを実行する
        exProcess.Start();
        exProcess.WaitForExit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
