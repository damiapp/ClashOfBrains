

public  class Card : MonoBehaviour{

public int id;
public string cardName;
public int power;
public string cardDescription;

public Card()
{

}

public Card(Int id, string CardName, int Power, string CardDescription)
{
id=id;
cardName=CardName;
power=Power;
cardDescription=CardDescription;
}


}