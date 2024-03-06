using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bebas;

public class Monster : MonoBehaviour
{
        public int health;
        public string name;
        public typeSize ukuran;
        public typeMonster jenisMonster;

     public void tampilanInfo()
    {
        Debug.Log("Health " + health + " Nama " + name + " Size " + ukuran + " Tipe Monster " + jenisMonster);
    }   

}
