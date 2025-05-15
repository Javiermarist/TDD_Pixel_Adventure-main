using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class NinjaFrogMovementTest
{
    private GameObject NinjaFrog;
    private GameObject Ground;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator NinjaFrogWalk()
    {   
        yield return new WaitForSeconds(1);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Ground = GameObject.Find("Ground");
        Assert.That(NinjaFrog.GetComponent<Rigidbody2D>().linearVelocity == Vector2.zero, "Frog isn't moving");
    }
    
    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
