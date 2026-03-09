
//C# Coding Exercises - Design Principles 1
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResourceManager : MonoBehaviour {
    // Tüm UI metinlerini bir listede veya Inspector'dan atanan bir yapıda tutuyoruz
    [System.Serializable]
    public struct ResourceUI {
        public string resourceName;
        public Text resourceText;
    }

    public List<ResourceUI> resources;

    // Tek bir fonksiyon ile tüm kaynakları güncelleyebiliriz
    public void UpdateResource(string name, int amount) {
        foreach (var res in resources) {
            if (res.resourceName == name) {
                res.resourceText.text = "Amount: " + amount.ToString();
                break;
            }
        }
    }
}

//I used AI to help me.