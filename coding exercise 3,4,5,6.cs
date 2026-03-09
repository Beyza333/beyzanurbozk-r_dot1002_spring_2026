//codig exercise 3 kıss1
public bool IsPlayerDead() {
    // health <= 0 ifadesi zaten true veya false sonucunu verir.
    // O yüzden sonucu direkt return edebiliriz.
    return (health <= 0); 
}
// codig exercise 4 kıss2

List<int> startingLevels = new List<int>() { 1, 2, 3 };

void Start() ;
// codig exersize 5 yagnı1
 public class HealthPotion {
    private const int HealAmount = 10;

    public void Consume(Player player) {
        player.Heal(HealAmount);
    }
}
//codig exercise 6 yagnı2
public class HealthPotion {
    private const int HealAmount = 10;

    public void Consume(Player player) {
        player.Heal(HealAmount);
    }
}

// I used AI to help me.
   
  
