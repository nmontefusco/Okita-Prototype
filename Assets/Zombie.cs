using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public string Name;
    public int peopleEaten;
    public int health;
    GameObject ZombieMesh;


    public Zombie(string n, int hp)
    {
        Name = n;
        peopleEaten = 0;
        hp = health;
        ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Vector3 pos = new Vector3() { x = Random.Range(-10f, 10f), y = 0f, z = Random.Range(-10, 10) };
        ZombieMesh.transform.position = pos;

    }

    void Start()
    {
        string[] names = new string[] { "Stubbs", "Rob", "White" };
        for (int i = 0; i < names.Length; i++)
        {
            Zombie z = new Zombie(names[i], Random.Range(10, 15));
            Debug.Log(z.Name);
        }
    }
}