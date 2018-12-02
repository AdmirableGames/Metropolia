using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour {
	public Text Win;
	public GameObject[] CanvasPlayer;
	public Text[] BtnText;
	public GameObject[] Conte;
	public Text Text;
	public Text Player1;
	public Text Player2;
	public GameObject Button;
	public Button[] Player1Buttons;
	public Text[] Player1BnTex;
	public Button[] Player2Buttons;
	public Text[] Player2BnTex;
	public Color newColor;
	public GameObject Image;
	int playercoin1;
	int playercoin2;
	int Rand;
	int click = 1;
	public int[] RNC;
	public Image[] PlayerKrap1;
	public Image[] PlayerKrap2;



	public void G2(){PlayerPrefs.SetInt ("QG",1);}

	void Player1Save(){

		//ColorBlock cb = Button.colors;
		//cb.normalColor = newColor;
		//Button.colors = cb;
		playercoin1 = PlayerPrefs.GetInt ("Playercoins1");
		//Blue
		if (PlayerPrefs.GetInt ("G1CellCard01") != 0) {Destroy (Player1Buttons [0]); Player1BnTex [0].text = "Wheat field\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1; }
		if (PlayerPrefs.GetInt ("G1CellCard02") != 0) {Destroy (Player1Buttons [1]); Player1BnTex [1].text = "Farm\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard03") != 0) {Destroy (Player1Buttons [2]); Player1BnTex [2].text = "Forest\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard04") != 0) {Destroy (Player1Buttons [3]); Player1BnTex [3].text = "Mine\nProfit 1 coin"; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard05") != 0) {Destroy (Player1Buttons [4]); Player1BnTex [4].text = "Apple orchard\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard06") != 0) {Destroy (Player1Buttons [5]); Player1BnTex [5].text = "Cornfield\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard07") != 0) {Destroy (Player1Buttons [6]); Player1BnTex [6].text = "Vineyard\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard08") != 0) {Destroy (Player1Buttons [7]); Player1BnTex [7].text = "Flower garden\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard09") != 0) {Destroy (Player1Buttons [8]); Player1BnTex [8].text = "Fishing boat\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard10") != 0) {Destroy (Player1Buttons [9]); Player1BnTex [9].text = "Trawler\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		//White
		if (PlayerPrefs.GetInt ("G1CellCard11") != 0) {Destroy (Player1Buttons [10]); Player1BnTex [10].text = "Sushi bar\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard12") != 0) {Destroy (Player1Buttons [11]); Player1BnTex [11].text = "Cafe\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard13") != 0) {Destroy (Player1Buttons [12]); Player1BnTex [12].text = "Eatery\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard14") != 0) {Destroy (Player1Buttons [13]); Player1BnTex [13].text = "Pizzeria\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard15") != 0) {Destroy (Player1Buttons [14]); Player1BnTex [14].text = "Tavern\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard16") != 0) {Destroy (Player1Buttons [15]); Player1BnTex [15].text = "Restaurant\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard17") != 0) {Destroy (Player1Buttons [16]); Player1BnTex [16].text = "Bar\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard18") != 0) {Destroy (Player1Buttons [17]); Player1BnTex [17].text = "Night club\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard19") != 0) {Destroy (Player1Buttons [18]); Player1BnTex [18].text = "Flower stall\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard20") != 0) {Destroy (Player1Buttons [19]); Player1BnTex [19].text = "Warehouse\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		//Green
		if (PlayerPrefs.GetInt ("G1CellCard21") != 0) {Destroy (Player1Buttons [20]); Player1BnTex [20].text = "Townhall\nРасход\n1 монета"; playercoin1 -= 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard22") != 0) {Destroy (Player1Buttons [21]); Player1BnTex [21].text = "Telecentre\nРасход\n1 монета"; playercoin1 -= 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard23") != 0) {Destroy (Player1Buttons [22]); Player1BnTex [22].text = "Radio center\nРасход\n1 монета"; playercoin1 -= 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard24") != 0) {Destroy (Player1Buttons [23]); Player1BnTex [23].text = "Park\nРасход\n1 монета"; playercoin1 -= 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard25") != 0) {Destroy (Player1Buttons [24]); Player1BnTex [24].text = "Terminal\nРасход\n1 монета"; playercoin1 -= 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard26") != 0) {Destroy (Player1Buttons [25]); Player1BnTex [25].text = "Port\nРасход\n2 монеты"; playercoin1 -= 2; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard27") != 0) {Destroy (Player1Buttons [26]); Player1BnTex [26].text = "Airport\nРасход\n2 монеты"; playercoin1 -= 2; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard28") != 0) {Destroy (Player1Buttons [27]); Player1BnTex [27].text = "Gallery\nРасход\n2 монеты"; playercoin1 -= 2; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard29") != 0) {Destroy (Player1Buttons [28]); Player1BnTex [28].text = "Hospital\nРасход\n2 монеты"; playercoin1 -= 2; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard30") != 0) {Destroy (Player1Buttons [29]); Player1BnTex [29].text = "Museum\nРасход\n2 монеты"; playercoin1 -= 2; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		//Orange
		if (PlayerPrefs.GetInt ("G1CellCard31") != 0) {Destroy (Player1Buttons [30]); Player1BnTex [30].text = "Tax police\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard32") != 0) {Destroy (Player1Buttons [31]); Player1BnTex [31].text = "Motel\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard33") != 0) {Destroy (Player1Buttons [32]); Player1BnTex [32].text = "Venture fund\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard34") != 0) {Destroy (Player1Buttons [33]); Player1BnTex [33].text = "Circus\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard35") != 0) {Destroy (Player1Buttons [34]); Player1BnTex [34].text = "Hotel\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard36") != 0) {Destroy (Player1Buttons [35]); Player1BnTex [35].text = "Business center\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard37") != 0) {Destroy (Player1Buttons [36]); Player1BnTex [36].text = "TV channel\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard38") != 0) {Destroy (Player1Buttons [37]); Player1BnTex [37].text = "Stadium\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard39") != 0) {Destroy (Player1Buttons [38]); Player1BnTex [38].text = "Typography\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard40") != 0) {Destroy (Player1Buttons [39]); Player1BnTex [39].text = "Radio studio\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		//Yellow
		if (PlayerPrefs.GetInt ("G1CellCard41") != 0) {Destroy (Player1Buttons [40]); Player1BnTex [40].text = "Department store\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard42") != 0) {Destroy (Player1Buttons [41]); Player1BnTex [41].text = "Entertainment center\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard43") != 0) {Destroy (Player1Buttons [42]); Player1BnTex [42].text = "Bank\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard44") != 0) {Destroy (Player1Buttons [43]); Player1BnTex [43].text = "Cargo company\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard45") != 0) {Destroy (Player1Buttons [44]); Player1BnTex [44].text = "Oil refinery\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard46") != 0) {Destroy (Player1Buttons [45]); Player1BnTex [45].text = "Cinema\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard47") != 0) {Destroy (Player1Buttons [46]); Player1BnTex [46].text = "Car park\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard48") != 0) {Destroy (Player1Buttons [47]); Player1BnTex [47].text = "Winery\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard49") != 0) {Destroy (Player1Buttons [48]); Player1BnTex [48].text = "Beverage factory\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		if (PlayerPrefs.GetInt ("G1CellCard50") != 0) {Destroy (Player1Buttons [49]); Player1BnTex [49].text = "Taxi park\nProfit 1 coin"; playercoin1 += 1; PlayerPrefs.SetInt ("Playercoins1", playercoin1); Player1.text = "Player1: " + playercoin1;}
		Content (content: 3);
	}

	void Player2Save(){
		playercoin2 = PlayerPrefs.GetInt ("Playercoins2");
		//Blue
		if (PlayerPrefs.GetInt ("G2CellCard01") != 0) {Destroy (Player2Buttons [0]); Player2BnTex [0].text = "Wheat field\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard02") != 0) {Destroy (Player2Buttons [1]); Player2BnTex [1].text = "Farm\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard03") != 0) {Destroy (Player2Buttons [2]); Player2BnTex [2].text = "Forest\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard04") != 0) {Destroy (Player2Buttons [3]); Player2BnTex [3].text = "Mine\nProfit 1 coin"; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard05") != 0) {Destroy (Player2Buttons [4]); Player2BnTex [4].text = "Apple orchard\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard06") != 0) {Destroy (Player2Buttons [5]); Player2BnTex [5].text = "Cornfield\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard07") != 0) {Destroy (Player2Buttons [6]); Player2BnTex [6].text = "Vineyard\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard08") != 0) {Destroy (Player2Buttons [7]); Player2BnTex [7].text = "Flower garden\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard09") != 0) {Destroy (Player2Buttons [8]); Player2BnTex [8].text = "Fishing boat\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard10") != 0) {Destroy (Player2Buttons [9]); Player2BnTex [9].text = "Trawler\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		//White
		if (PlayerPrefs.GetInt ("G2CellCard11") != 0) {Destroy (Player2Buttons [10]); Player2BnTex [10].text = "Sushi bar\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard12") != 0) {Destroy (Player2Buttons [11]); Player2BnTex [11].text = "Cafe\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard13") != 0) {Destroy (Player2Buttons [12]); Player2BnTex [12].text = "Eatery\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard14") != 0) {Destroy (Player2Buttons [13]); Player2BnTex [13].text = "Pizzeria\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard15") != 0) {Destroy (Player2Buttons [14]); Player2BnTex [14].text = "Tavern\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard16") != 0) {Destroy (Player2Buttons [15]); Player2BnTex [15].text = "Restaurant\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard17") != 0) {Destroy (Player2Buttons [16]); Player2BnTex [16].text = "Bar\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard18") != 0) {Destroy (Player2Buttons [17]); Player2BnTex [17].text = "Night club\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard19") != 0) {Destroy (Player2Buttons [18]); Player2BnTex [18].text = "Flower stall\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard20") != 0) {Destroy (Player2Buttons [19]); Player2BnTex [19].text = "Warehouse\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		//Green
		if (PlayerPrefs.GetInt ("G2CellCard21") != 0) {Destroy (Player2Buttons [20]); Player2BnTex [20].text = "Townhall\nРасход\n1 монета"; playercoin2 -= 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard22") != 0) {Destroy (Player2Buttons [21]); Player2BnTex [21].text = "Telecentre\nРасход\n1 монета"; playercoin2 -= 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard23") != 0) {Destroy (Player2Buttons [22]); Player2BnTex [22].text = "Radio center\nРасход\n1 монета"; playercoin2 -= 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard24") != 0) {Destroy (Player2Buttons [23]); Player2BnTex [23].text = "Park\nРасход\n1 монета"; playercoin2 -= 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard25") != 0) {Destroy (Player2Buttons [24]); Player2BnTex [24].text = "Terminal\nРасход\n1 монета"; playercoin2 -= 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard26") != 0) {Destroy (Player2Buttons [25]); Player2BnTex [25].text = "Port\nРасход\n2 монеты"; playercoin2 -= 2; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard27") != 0) {Destroy (Player2Buttons [26]); Player2BnTex [26].text = "Airport\nРасход\n2 монеты"; playercoin2 -= 2; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard28") != 0) {Destroy (Player2Buttons [27]); Player2BnTex [27].text = "Gallery\nРасход\n2 монеты"; playercoin2 -= 2; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard29") != 0) {Destroy (Player2Buttons [28]); Player2BnTex [28].text = "Hospital\nРасход\n2 монеты"; playercoin2 -= 2; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard30") != 0) {Destroy (Player2Buttons [29]); Player2BnTex [29].text = "Museum\nРасход\n2 монеты"; playercoin2 -= 2; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		//Orange
		if (PlayerPrefs.GetInt ("G2CellCard31") != 0) {Destroy (Player2Buttons [30]); Player2BnTex [30].text = "Tax police\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard32") != 0) {Destroy (Player2Buttons [31]); Player2BnTex [31].text = "Motel\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard33") != 0) {Destroy (Player2Buttons [32]); Player2BnTex [32].text = "Venture fund\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard34") != 0) {Destroy (Player2Buttons [33]); Player2BnTex [33].text = "Circus\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard35") != 0) {Destroy (Player2Buttons [34]); Player2BnTex [34].text = "Hotel\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard36") != 0) {Destroy (Player2Buttons [35]); Player2BnTex [35].text = "Business center\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard37") != 0) {Destroy (Player2Buttons [36]); Player2BnTex [36].text = "TV channel\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard38") != 0) {Destroy (Player2Buttons [37]); Player2BnTex [37].text = "Stadium\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard39") != 0) {Destroy (Player2Buttons [38]); Player2BnTex [38].text = "Typography\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard40") != 0) {Destroy (Player2Buttons [39]); Player2BnTex [39].text = "Radio studio\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		//Yellow
		if (PlayerPrefs.GetInt ("G2CellCard41") != 0) {Destroy (Player2Buttons [40]); Player2BnTex [40].text = "Department store\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard42") != 0) {Destroy (Player2Buttons [41]); Player2BnTex [41].text = "Entertainment center\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard43") != 0) {Destroy (Player2Buttons [42]); Player2BnTex [42].text = "Bank\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard44") != 0) {Destroy (Player2Buttons [43]); Player2BnTex [43].text = "Cargo company\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard45") != 0) {Destroy (Player2Buttons [44]); Player2BnTex [44].text = "Oil refinery\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard46") != 0) {Destroy (Player2Buttons [45]); Player2BnTex [45].text = "Cinema\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard47") != 0) {Destroy (Player2Buttons [46]); Player2BnTex [46].text = "Car park\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard48") != 0) {Destroy (Player2Buttons [47]); Player2BnTex [47].text = "Winery\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard49") != 0) {Destroy (Player2Buttons [48]); Player2BnTex [48].text = "Beverage factory\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		if (PlayerPrefs.GetInt ("G2CellCard50") != 0) {Destroy (Player2Buttons [49]); Player2BnTex [49].text = "Taxi park\nProfit 1 coin"; playercoin2 += 1; PlayerPrefs.SetInt ("Playercoins2", playercoin2); Player2.text = "Player2: " + playercoin2;}
		Content (content: 8);
	}

	void Player1Krap(){
		//Blue
		if (PlayerPrefs.GetInt ("G1CellCard01") != 0) {PlayerKrap2[0].color = Color.blue;}else{PlayerKrap2[0].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard02") != 0) {PlayerKrap2[1].color = Color.blue;}else{PlayerKrap2[1].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard03") != 0) {PlayerKrap2[2].color = Color.blue;}else{PlayerKrap2[2].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard04") != 0) {PlayerKrap2[3].color = Color.blue;}else{PlayerKrap2[3].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard05") != 0) {PlayerKrap2[4].color = Color.blue;}else{PlayerKrap2[4].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard06") != 0) {PlayerKrap2[5].color = Color.blue;}else{PlayerKrap2[5].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard07") != 0) {PlayerKrap2[6].color = Color.blue;}else{PlayerKrap2[6].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard08") != 0) {PlayerKrap2[7].color = Color.blue;}else{PlayerKrap2[7].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard09") != 0) {PlayerKrap2[8].color = Color.blue;}else{PlayerKrap2[8].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard10") != 0) {PlayerKrap2[9].color = Color.blue;}else{PlayerKrap2[9].color = Color.clear;}
		//White
		if (PlayerPrefs.GetInt ("G1CellCard11") != 0) {PlayerKrap2[10].color = Color.blue;}else{PlayerKrap2[10].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard12") != 0) {PlayerKrap2[11].color = Color.blue;}else{PlayerKrap2[11].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard13") != 0) {PlayerKrap2[12].color = Color.blue;}else{PlayerKrap2[12].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard14") != 0) {PlayerKrap2[13].color = Color.blue;}else{PlayerKrap2[13].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard15") != 0) {PlayerKrap2[14].color = Color.blue;}else{PlayerKrap2[14].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard16") != 0) {PlayerKrap2[15].color = Color.blue;}else{PlayerKrap2[15].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard17") != 0) {PlayerKrap2[16].color = Color.blue;}else{PlayerKrap2[16].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard18") != 0) {PlayerKrap2[17].color = Color.blue;}else{PlayerKrap2[17].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard19") != 0) {PlayerKrap2[18].color = Color.blue;}else{PlayerKrap2[18].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard20") != 0) {PlayerKrap2[19].color = Color.blue;}else{PlayerKrap2[19].color = Color.clear;}
		//Green
		if (PlayerPrefs.GetInt ("G1CellCard21") != 0) {PlayerKrap2[20].color = Color.blue;}else{PlayerKrap2[20].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard22") != 0) {PlayerKrap2[21].color = Color.blue;}else{PlayerKrap2[21].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard23") != 0) {PlayerKrap2[22].color = Color.blue;}else{PlayerKrap2[22].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard24") != 0) {PlayerKrap2[23].color = Color.blue;}else{PlayerKrap2[23].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard25") != 0) {PlayerKrap2[24].color = Color.blue;}else{PlayerKrap2[24].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard26") != 0) {PlayerKrap2[25].color = Color.blue;}else{PlayerKrap2[25].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard27") != 0) {PlayerKrap2[26].color = Color.blue;}else{PlayerKrap2[26].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard28") != 0) {PlayerKrap2[27].color = Color.blue;}else{PlayerKrap2[27].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard29") != 0) {PlayerKrap2[28].color = Color.blue;}else{PlayerKrap2[28].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard30") != 0) {PlayerKrap2[29].color = Color.blue;}else{PlayerKrap2[29].color = Color.clear;}
		//Orange
		if (PlayerPrefs.GetInt ("G1CellCard31") != 0) {PlayerKrap2[30].color = Color.blue;}else{PlayerKrap2[30].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard32") != 0) {PlayerKrap2[31].color = Color.blue;}else{PlayerKrap2[31].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard33") != 0) {PlayerKrap2[32].color = Color.blue;}else{PlayerKrap2[32].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard34") != 0) {PlayerKrap2[33].color = Color.blue;}else{PlayerKrap2[33].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard35") != 0) {PlayerKrap2[34].color = Color.blue;}else{PlayerKrap2[34].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard36") != 0) {PlayerKrap2[35].color = Color.blue;}else{PlayerKrap2[35].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard37") != 0) {PlayerKrap2[36].color = Color.blue;}else{PlayerKrap2[36].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard38") != 0) {PlayerKrap2[37].color = Color.blue;}else{PlayerKrap2[37].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard39") != 0) {PlayerKrap2[38].color = Color.blue;}else{PlayerKrap2[38].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard40") != 0) {PlayerKrap2[39].color = Color.blue;}else{PlayerKrap2[39].color = Color.clear;}
		//Yellow
		if (PlayerPrefs.GetInt ("G1CellCard41") != 0) {PlayerKrap2[40].color = Color.blue;}else{PlayerKrap2[40].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard42") != 0) {PlayerKrap2[41].color = Color.blue;}else{PlayerKrap2[41].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard43") != 0) {PlayerKrap2[42].color = Color.blue;}else{PlayerKrap2[42].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard44") != 0) {PlayerKrap2[43].color = Color.blue;}else{PlayerKrap2[43].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard45") != 0) {PlayerKrap2[44].color = Color.blue;}else{PlayerKrap2[44].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard46") != 0) {PlayerKrap2[45].color = Color.blue;}else{PlayerKrap2[45].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard47") != 0) {PlayerKrap2[46].color = Color.blue;}else{PlayerKrap2[46].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard48") != 0) {PlayerKrap2[47].color = Color.blue;}else{PlayerKrap2[47].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard49") != 0) {PlayerKrap2[48].color = Color.blue;}else{PlayerKrap2[48].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G1CellCard50") != 0) {PlayerKrap2[49].color = Color.blue;}else{PlayerKrap2[49].color = Color.clear;}
	}

	void Player2Krap(){
		//Blue
		if (PlayerPrefs.GetInt ("G2CellCard01") != 0) {PlayerKrap1[0].color = Color.black;}else{PlayerKrap1[0].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard02") != 0) {PlayerKrap1[1].color = Color.black;}else{PlayerKrap1[1].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard03") != 0) {PlayerKrap1[2].color = Color.black;}else{PlayerKrap1[2].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard04") != 0) {PlayerKrap1[3].color = Color.black;}else{PlayerKrap1[3].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard05") != 0) {PlayerKrap1[4].color = Color.black;}else{PlayerKrap1[4].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard06") != 0) {PlayerKrap1[5].color = Color.black;}else{PlayerKrap1[5].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard07") != 0) {PlayerKrap1[6].color = Color.black;}else{PlayerKrap1[6].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard08") != 0) {PlayerKrap1[7].color = Color.black;}else{PlayerKrap1[7].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard09") != 0) {PlayerKrap1[8].color = Color.black;}else{PlayerKrap1[8].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard10") != 0) {PlayerKrap1[9].color = Color.black;}else{PlayerKrap1[9].color = Color.clear;}
		//White
		if (PlayerPrefs.GetInt ("G2CellCard11") != 0) {PlayerKrap1[10].color = Color.black;}else{PlayerKrap1[10].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard12") != 0) {PlayerKrap1[11].color = Color.black;}else{PlayerKrap1[11].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard13") != 0) {PlayerKrap1[12].color = Color.black;}else{PlayerKrap1[12].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard14") != 0) {PlayerKrap1[13].color = Color.black;}else{PlayerKrap1[13].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard15") != 0) {PlayerKrap1[14].color = Color.black;}else{PlayerKrap1[14].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard16") != 0) {PlayerKrap1[15].color = Color.black;}else{PlayerKrap1[15].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard17") != 0) {PlayerKrap1[16].color = Color.black;}else{PlayerKrap1[16].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard18") != 0) {PlayerKrap1[17].color = Color.black;}else{PlayerKrap1[17].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard19") != 0) {PlayerKrap1[18].color = Color.black;}else{PlayerKrap1[18].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard20") != 0) {PlayerKrap1[19].color = Color.black;}else{PlayerKrap1[19].color = Color.clear;}
		//Green
		if (PlayerPrefs.GetInt ("G2CellCard21") != 0) {PlayerKrap1[20].color = Color.black;}else{PlayerKrap1[20].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard22") != 0) {PlayerKrap1[21].color = Color.black;}else{PlayerKrap1[21].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard23") != 0) {PlayerKrap1[22].color = Color.black;}else{PlayerKrap1[22].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard24") != 0) {PlayerKrap1[23].color = Color.black;}else{PlayerKrap1[23].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard25") != 0) {PlayerKrap1[24].color = Color.black;}else{PlayerKrap1[24].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard26") != 0) {PlayerKrap1[25].color = Color.black;}else{PlayerKrap1[25].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard27") != 0) {PlayerKrap1[26].color = Color.black;}else{PlayerKrap1[26].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard28") != 0) {PlayerKrap1[27].color = Color.black;}else{PlayerKrap1[27].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard29") != 0) {PlayerKrap1[28].color = Color.black;}else{PlayerKrap1[28].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard30") != 0) {PlayerKrap1[29].color = Color.black;}else{PlayerKrap1[29].color = Color.clear;}
		//Orange
		if (PlayerPrefs.GetInt ("G2CellCard31") != 0) {PlayerKrap1[30].color = Color.black;}else{PlayerKrap1[30].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard32") != 0) {PlayerKrap1[31].color = Color.black;}else{PlayerKrap1[31].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard33") != 0) {PlayerKrap1[32].color = Color.black;}else{PlayerKrap1[32].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard34") != 0) {PlayerKrap1[33].color = Color.black;}else{PlayerKrap1[33].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard35") != 0) {PlayerKrap1[34].color = Color.black;}else{PlayerKrap1[34].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard36") != 0) {PlayerKrap1[35].color = Color.black;}else{PlayerKrap1[35].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard37") != 0) {PlayerKrap1[36].color = Color.black;}else{PlayerKrap1[36].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard38") != 0) {PlayerKrap1[37].color = Color.black;}else{PlayerKrap1[37].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard39") != 0) {PlayerKrap1[38].color = Color.black;}else{PlayerKrap1[38].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard40") != 0) {PlayerKrap1[39].color = Color.black;}else{PlayerKrap1[39].color = Color.clear;}
		//Yellow
		if (PlayerPrefs.GetInt ("G2CellCard41") != 0) {PlayerKrap1[40].color = Color.black;}else{PlayerKrap1[40].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard42") != 0) {PlayerKrap1[41].color = Color.black;}else{PlayerKrap1[41].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard43") != 0) {PlayerKrap1[42].color = Color.black;}else{PlayerKrap1[42].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard44") != 0) {PlayerKrap1[43].color = Color.black;}else{PlayerKrap1[43].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard45") != 0) {PlayerKrap1[44].color = Color.black;}else{PlayerKrap1[44].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard46") != 0) {PlayerKrap1[45].color = Color.black;}else{PlayerKrap1[45].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard47") != 0) {PlayerKrap1[46].color = Color.black;}else{PlayerKrap1[46].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard48") != 0) {PlayerKrap1[47].color = Color.black;}else{PlayerKrap1[47].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard49") != 0) {PlayerKrap1[48].color = Color.black;}else{PlayerKrap1[48].color = Color.clear;}
		if (PlayerPrefs.GetInt ("G2CellCard50") != 0) {PlayerKrap1[49].color = Color.black;}else{PlayerKrap1[49].color = Color.clear;}
	}

	//////////////////////////////////////////////////////////


	void Winner(){
		if (PlayerPrefs.GetInt ("G1CellCard21") != 0 && PlayerPrefs.GetInt ("G1CellCard22") != 0 && PlayerPrefs.GetInt ("G1CellCard23") != 0 && PlayerPrefs.GetInt ("G1CellCard24") != 0 && PlayerPrefs.GetInt ("G1CellCard25") != 0 && (PlayerPrefs.GetInt ("G1CellCard26") != 0 && PlayerPrefs.GetInt ("G1CellCard27") != 0 && PlayerPrefs.GetInt ("G1CellCard28") != 0 && PlayerPrefs.GetInt ("G1CellCard29") != 0 && PlayerPrefs.GetInt ("G1CellCard30") != 0))
		{
			CanvasPlayer [0].SetActive (false);
			CanvasPlayer [1].SetActive (false);
			CanvasPlayer [2].SetActive (false);
			CanvasPlayer [3].SetActive (false);
			CanvasPlayer [4].SetActive (true);
			Win.text = "WINNER\nPLAYER1"; 
		}

		if (PlayerPrefs.GetInt ("G2CellCard21") != 0 && PlayerPrefs.GetInt ("G2CellCard22") != 0 && PlayerPrefs.GetInt ("G2CellCard23") != 0 && PlayerPrefs.GetInt ("G2CellCard24") != 0 && PlayerPrefs.GetInt ("G2CellCard25") != 0 && (PlayerPrefs.GetInt ("G2CellCard26") != 0 && PlayerPrefs.GetInt ("G2CellCard27") != 0 && PlayerPrefs.GetInt ("G2CellCard28") != 0 && PlayerPrefs.GetInt ("G2CellCard29") != 0 && PlayerPrefs.GetInt ("G2CellCard30") != 0)) 
		{
			CanvasPlayer [0].SetActive (false);
			CanvasPlayer [1].SetActive (false);
			CanvasPlayer [2].SetActive (false);
			CanvasPlayer [3].SetActive (false);
			CanvasPlayer [4].SetActive (true);
			Win.text = "WINNER\nPLAYER2"; 
		}

	}


	void Start () { 
		Player1Save ();
		Player2Save ();
	}

	void Sefe1(){PlayerPrefs.SetInt("Saver1x0",1);}
	void Sefe2(){PlayerPrefs.SetInt("Saver2x0",1);}

	// Update is called once per frame
	void Update ()
	{   
		Player1Krap ();
		Player2Krap ();

		if (PlayerPrefs.GetInt ("QG") == 0) {QG();}
		if (PlayerPrefs.GetInt ("QG") == 1) {PlayerOf2();}
		int SaveStor1 = PlayerPrefs.GetInt("Saver1x0");
		int SaveStor2 = PlayerPrefs.GetInt("Saver2x0");

		playercoin1 = PlayerPrefs.GetInt("Playercoins1");
		if (SaveStor1 == 1 && playercoin1 > 0){Player1.text = "Player1: " + playercoin1;} else playercoin1 = 0; Player1.text = "Player1: " + playercoin1;
		if (SaveStor1 == 0 && playercoin1 <= 0) {playercoin1 = 3; Player1.text = "Player1: " + playercoin1;}

		playercoin2 = PlayerPrefs.GetInt("Playercoins2");
		if (SaveStor2 == 1 && playercoin2 > 0){Player2.text = "Player2: " + playercoin2;} else playercoin2 = 0; Player2.text = "Player2: " + playercoin2;
		if (SaveStor2 == 0 && playercoin2 <= 0) {playercoin2 = 3; Player2.text = "Player2: " + playercoin2;}

		Winner ();
	}

	void QG(){
		CanvasPlayer [0].SetActive (false); 
		CanvasPlayer [1].SetActive (false);
		CanvasPlayer [2].SetActive (true);
		CanvasPlayer [3].SetActive (false);
	}


	void PlayerOf2(){
		if (click == 1) {
			CanvasPlayer [0].SetActive (true);
			CanvasPlayer [1].SetActive (false);
			CanvasPlayer [2].SetActive (false);
			CanvasPlayer [3].SetActive (true);
		}
		if (click == 2) {
			CanvasPlayer [0].SetActive (false);
			CanvasPlayer [1].SetActive (true);
			CanvasPlayer [2].SetActive (false);
			CanvasPlayer [3].SetActive (true);
		}
		if (click == 3) {
			Restart ();
		}
	}


	void Restart(){SceneManager.LoadScene("Scene");}
	public void Reset()
	{
		click+=1;
		Button.SetActive (true); 
		Image.SetActive(true);
	}


	public void Content(int content){
		if (content == 1) {Conte [0].SetActive (true);Conte [1].SetActive (false);Conte [2].SetActive (false);Conte [3].SetActive (false);Conte [4].SetActive (false);}
		if (content == 2) {Conte [0].SetActive (false);Conte [1].SetActive (true);Conte [2].SetActive (false);Conte [3].SetActive (false);Conte [4].SetActive (false);}
		if (content == 3) {Conte [0].SetActive (false);Conte [1].SetActive (false);Conte [2].SetActive (true);Conte [3].SetActive (false);Conte [4].SetActive (false);}
		if (content == 4) {Conte [0].SetActive (false);Conte [1].SetActive (false);Conte [2].SetActive (false);Conte [3].SetActive (true);Conte [4].SetActive (false);}
		if (content == 5) {Conte [0].SetActive (false);Conte [1].SetActive (false);Conte [2].SetActive (false);Conte [3].SetActive (false);Conte[4].SetActive  (true);}
		if (content == 6) {Conte [5].SetActive (true);Conte [6].SetActive (false);Conte [7].SetActive (false);Conte [8].SetActive (false);Conte [9].SetActive (false);}
		if (content == 7) {Conte [5].SetActive (false);Conte [6].SetActive (true);Conte [7].SetActive (false);Conte [8].SetActive (false);Conte [9].SetActive (false);}
		if (content == 8) {Conte [5].SetActive (false);Conte [6].SetActive (false);Conte [7].SetActive (true);Conte [8].SetActive (false);Conte [9].SetActive (false);}
		if (content == 9) {Conte [5].SetActive (false);Conte [6].SetActive (false);Conte [7].SetActive (false);Conte [8].SetActive (true);Conte [9].SetActive (false);}
		if (content == 10) {Conte [5].SetActive (false);Conte [6].SetActive (false);Conte [7].SetActive (false);Conte [8].SetActive (false);Conte[9].SetActive  (true);}
	}

	public void BrositCubic(){

		Rand = Mathf.RoundToInt (Random.Range(1.5f, 12.4f)); Text.text = "" + Rand; 
		Button.SetActive(false); 
		Image.SetActive(false);
		for (int ct = 0; ct <= 79; ct++)
		{
			RNC[ct] = Mathf.RoundToInt (Random.Range (1.5f, 12.4f)); 
			if (RNC [ct] == Rand){
				BtnText [ct].color = Color.green;
				BtnText[ct].text = "" + RNC[ct];}
			else BtnText [ct].color = Color.red; 
			BtnText[ct].text = "" + RNC[ct];}
		if (PlayerPrefs.GetInt ("G1CellCard01") != 0) {BtnText [0].text = "";}if (PlayerPrefs.GetInt ("G1CellCard02") != 0) {BtnText [1].text = "";}if (PlayerPrefs.GetInt ("G1CellCard03") != 0) {BtnText [2].text = "";}if (PlayerPrefs.GetInt ("G1CellCard04") != 0) {BtnText [3].text = "";}if (PlayerPrefs.GetInt ("G1CellCard05") != 0) {BtnText [4].text = "";}if (PlayerPrefs.GetInt ("G1CellCard06") != 0) {BtnText [5].text = "";}if (PlayerPrefs.GetInt ("G1CellCard07") != 0) {BtnText [6].text = "";}if (PlayerPrefs.GetInt ("G1CellCard08") != 0) {BtnText [7].text = "";}if (PlayerPrefs.GetInt ("G1CellCard09") != 0) {BtnText [8].text = "";}if (PlayerPrefs.GetInt ("G1CellCard10") != 0) {BtnText [9].text = "";}if (PlayerPrefs.GetInt ("G1CellCard11") != 0) {BtnText [10].text = "";}if (PlayerPrefs.GetInt ("G1CellCard12") != 0) {BtnText [11].text = "";}if (PlayerPrefs.GetInt ("G1CellCard13") != 0) {BtnText [12].text = "";}if (PlayerPrefs.GetInt ("G1CellCard14") != 0) {BtnText [13].text = "";}if (PlayerPrefs.GetInt ("G1CellCard15") != 0) {BtnText [14].text = "";}if (PlayerPrefs.GetInt ("G1CellCard16") != 0) {BtnText [15].text = "";}if (PlayerPrefs.GetInt ("G1CellCard17") != 0) {BtnText [16].text = "";}if (PlayerPrefs.GetInt ("G1CellCard18") != 0) {BtnText [17].text = "";}if (PlayerPrefs.GetInt ("G1CellCard19") != 0) {BtnText [18].text = "";;}if (PlayerPrefs.GetInt ("G1CellCard20") != 0) {BtnText [19].text = "";}if (PlayerPrefs.GetInt ("G1CellCard31") != 0) {BtnText [20].text = "";}if (PlayerPrefs.GetInt ("G1CellCard32") != 0) {BtnText [21].text = "";}if (PlayerPrefs.GetInt ("G1CellCard33") != 0) {BtnText [22].text = "";}if (PlayerPrefs.GetInt ("G1CellCard34") != 0) {BtnText [23].text = "";}if (PlayerPrefs.GetInt ("G1CellCard35") != 0) {BtnText [24].text = "";}if (PlayerPrefs.GetInt ("G1CellCard36") != 0) {BtnText [25].text = "";}if (PlayerPrefs.GetInt ("G1CellCard37") != 0) {BtnText [26].text = "";}if (PlayerPrefs.GetInt ("G1CellCard38") != 0) {BtnText [27].text = "";}if (PlayerPrefs.GetInt ("G1CellCard39") != 0) {BtnText [28].text = "";}if (PlayerPrefs.GetInt ("G1CellCard40") != 0) {BtnText [29].text = "";}if (PlayerPrefs.GetInt ("G1CellCard41") != 0) {BtnText [30].text = "";}if (PlayerPrefs.GetInt ("G1CellCard42") != 0) {BtnText [31].text = "";}if (PlayerPrefs.GetInt ("G1CellCard43") != 0) {BtnText [32].text = "";}if (PlayerPrefs.GetInt ("G1CellCard44") != 0) {BtnText [33].text = "";}if (PlayerPrefs.GetInt ("G1CellCard45") != 0) {BtnText [34].text = "";}if (PlayerPrefs.GetInt ("G1CellCard46") != 0) {BtnText [35].text = "";}if (PlayerPrefs.GetInt ("G1CellCard47") != 0) {BtnText [36].text = "";}if (PlayerPrefs.GetInt ("G1CellCard48") != 0) {BtnText [37].text = "";}if (PlayerPrefs.GetInt ("G1CellCard49") != 0) {BtnText [38].text = "";}if (PlayerPrefs.GetInt ("G1CellCard50") != 0) {BtnText [39].text = "";}
		if (PlayerPrefs.GetInt ("G2CellCard01") != 0) {BtnText [40].text = "";}if (PlayerPrefs.GetInt ("G2CellCard02") != 0) {BtnText [41].text = "";}if (PlayerPrefs.GetInt ("G2CellCard03") != 0) {BtnText [42].text = "";}if (PlayerPrefs.GetInt ("G2CellCard04") != 0) {BtnText [43].text = "";}if (PlayerPrefs.GetInt ("G2CellCard05") != 0) {BtnText [44].text = "";}if (PlayerPrefs.GetInt ("G2CellCard06") != 0) {BtnText [45].text = "";}if (PlayerPrefs.GetInt ("G2CellCard07") != 0) {BtnText [46].text = "";}if (PlayerPrefs.GetInt ("G2CellCard08") != 0) {BtnText [47].text = "";}if (PlayerPrefs.GetInt ("G2CellCard09") != 0) {BtnText [48].text = "";}if (PlayerPrefs.GetInt ("G2CellCard10") != 0) {BtnText [49].text = "";}if (PlayerPrefs.GetInt ("G2CellCard11") != 0) {BtnText [50].text = "";}if (PlayerPrefs.GetInt ("G2CellCard12") != 0) {BtnText [51].text = "";}if (PlayerPrefs.GetInt ("G2CellCard13") != 0) {BtnText [52].text = "";}if (PlayerPrefs.GetInt ("G2CellCard14") != 0) {BtnText [53].text = "";}if (PlayerPrefs.GetInt ("G2CellCard15") != 0) {BtnText [54].text = "";}if (PlayerPrefs.GetInt ("G2CellCard16") != 0) {BtnText [55].text = "";}if (PlayerPrefs.GetInt ("G2CellCard17") != 0) {BtnText [56].text = "";}if (PlayerPrefs.GetInt ("G2CellCard18") != 0) {BtnText [57].text = "";}if (PlayerPrefs.GetInt ("G2CellCard19") != 0) {BtnText [58].text = "";}if (PlayerPrefs.GetInt ("G2CellCard20") != 0) {BtnText [59].text = "";}if (PlayerPrefs.GetInt ("G2CellCard31") != 0) {BtnText [60].text = "";}if (PlayerPrefs.GetInt ("G2CellCard32") != 0) {BtnText [61].text = "";}if (PlayerPrefs.GetInt ("G2CellCard33") != 0) {BtnText [62].text = "";}if (PlayerPrefs.GetInt ("G2CellCard34") != 0) {BtnText [63].text = "";}if (PlayerPrefs.GetInt ("G2CellCard35") != 0) {BtnText [64].text = "";}if (PlayerPrefs.GetInt ("G2CellCard36") != 0) {BtnText [65].text = "";}if (PlayerPrefs.GetInt ("G2CellCard37") != 0) {BtnText [66].text = "";}if (PlayerPrefs.GetInt ("G2CellCard38") != 0) {BtnText [67].text = "";}if (PlayerPrefs.GetInt ("G2CellCard39") != 0) {BtnText [68].text = "";}if (PlayerPrefs.GetInt ("G2CellCard40") != 0) {BtnText [69].text = "";}if (PlayerPrefs.GetInt ("G2CellCard41") != 0) {BtnText [70].text = "";}if (PlayerPrefs.GetInt ("G2CellCard42") != 0) {BtnText [71].text = "";}if (PlayerPrefs.GetInt ("G2CellCard43") != 0) {BtnText [72].text = "";}if (PlayerPrefs.GetInt ("G2CellCard44") != 0) {BtnText [73].text = "";}if (PlayerPrefs.GetInt ("G2CellCard45") != 0) {BtnText [74].text = "";}if (PlayerPrefs.GetInt ("G2CellCard46") != 0) {BtnText [75].text = "";}if (PlayerPrefs.GetInt ("G2CellCard47") != 0) {BtnText [76].text = "";}if (PlayerPrefs.GetInt ("G2CellCard48") != 0) {BtnText [77].text = "";}if (PlayerPrefs.GetInt ("G2CellCard49") != 0) {BtnText [78].text = "";}if (PlayerPrefs.GetInt ("G2CellCard50") != 0) {BtnText [79].text = "";}


	}


	public void DeleteSave(){PlayerPrefs.DeleteAll ();Restart ();CanvasPlayer [4].SetActive (false);}



	public void VoidPlayer1(int cn)
	{
		// Blue Content
		if (cn == 1){if (playercoin1 >= 2 && RNC[0] == Rand) {Sefe1();Player1BnTex [0].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard01",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [0].text = "Not buy";}
		if (cn == 2){if (playercoin1 >= 4 && RNC[1] == Rand) {Sefe1();Player1BnTex [1].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 4); PlayerPrefs.SetInt("G1CellCard02",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [1].text = "Not buy";}
		if (cn == 3){if (playercoin1 >= 5 && RNC[2] == Rand) {Sefe1();Player1BnTex [2].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard03",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [2].text = "Not buy";} 
		if (cn == 4){if (playercoin1 >= 6 && RNC[3] == Rand) {Sefe1();Player1BnTex [3].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 6); PlayerPrefs.SetInt("G1CellCard04",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [3].text = "Not buy";} 
		if (cn == 5){if (playercoin1 >= 2 && RNC[4] == Rand) {Sefe1();Player1BnTex [4].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard05",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [4].text = "Not buy";} 
		if (cn == 6){if (playercoin1 >= 1 && RNC[5] == Rand) {Sefe1();Player1BnTex [5].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 1); PlayerPrefs.SetInt("G1CellCard06",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [5].text = "Not buy";} 
		if (cn == 7){if (playercoin1 >= 2 && RNC[6] == Rand) {Sefe1();Player1BnTex [6].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard07",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [6].text = "Not buy";} 
		if (cn == 8){if (playercoin1 >= 1 && RNC[7] == Rand) {Sefe1();Player1BnTex [7].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 1); PlayerPrefs.SetInt("G1CellCard08",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [7].text = "Not buy";} 
		if (cn == 9){if (playercoin1 >= 2 && RNC[8] == Rand) {Sefe1();Player1BnTex [8].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard09",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [8].text = "Not buy";} 
		if (cn == 10){if(playercoin1 >= 5 && RNC[9] == Rand) {Sefe1();Player1BnTex [9].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard10",1);for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [9].text = "Not buy";} 
		// White Content
		if (cn == 11){if (playercoin1 >= 2 && RNC[10] == Rand) {Sefe1();Player1BnTex [10].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard11",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [10].text = "Not buy";} 
		if (cn == 12){if (playercoin1 >= 2 && RNC[11] == Rand) {Sefe1();Player1BnTex [11].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard12",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [11].text = "Not buy";}
		if (cn == 13){if (playercoin1 >= 7 && RNC[12] == Rand) {Sefe1();Player1BnTex [12].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 7); PlayerPrefs.SetInt("G1CellCard13",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [12].text = "Not buy";}
		if (cn == 14){if (playercoin1 >= 2 && RNC[13] == Rand) {Sefe1();Player1BnTex [13].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard14",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [13].text = "Not buy";}		
		if (cn == 15){if (playercoin1 >= 1 && RNC[14] == Rand) {Sefe1();Player1BnTex [14].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 1); PlayerPrefs.SetInt("G1CellCard15",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [14].text = "Not buy";}
		if (cn == 16){if (playercoin1 >= 5 && RNC[15] == Rand) {Sefe1();Player1BnTex [15].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard16",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [15].text = "Not buy";}
		if (cn == 17){if (playercoin1 >= 4 && RNC[16] == Rand) {Sefe1();Player1BnTex [16].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 4); PlayerPrefs.SetInt("G1CellCard17",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [16].text = "Not buy";}
		if (cn == 18){if (playercoin1 >= 6 && RNC[17] == Rand) {Sefe1();Player1BnTex [17].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 6); PlayerPrefs.SetInt("G1CellCard18",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [17].text = "Not buy";}
		if (cn == 19){if (playercoin1 >= 1 && RNC[18] == Rand) {Sefe1();Player1BnTex [18].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 1); PlayerPrefs.SetInt("G1CellCard19",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [18].text = "Not buy";}	
		if (cn == 20){if (playercoin1 >= 4 && RNC[19] == Rand) {Sefe1();Player1BnTex [19].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 4); PlayerPrefs.SetInt("G1CellCard20",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [19].text = "Not buy";}
		// Green Content
		if (cn == 21){if (playercoin1 >= 8) {Player1BnTex [20].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 8); PlayerPrefs.SetInt("G1CellCard21",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [20].text = "Not buy";}
		if (cn == 22){if (playercoin1 >= 35) {Player1BnTex [21].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 35); PlayerPrefs.SetInt("G1CellCard22",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [21].text = "Not buy";}
		if (cn == 23){if (playercoin1 >= 22) {Player1BnTex [22].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 22); PlayerPrefs.SetInt("G1CellCard23",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [22].text = "Not buy";}
		if (cn == 24){if (playercoin1 >= 16) {Player1BnTex [23].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 16); PlayerPrefs.SetInt("G1CellCard24",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [23].text = "Not buy";}		
		if (cn == 25){if (playercoin1 >= 25) {Player1BnTex [24].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 25); PlayerPrefs.SetInt("G1CellCard25",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [24].text = "Not buy";}
		if (cn == 26){if (playercoin1>= 28){Player1BnTex [25].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 28); PlayerPrefs.SetInt("G1CellCard26",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [25].text = "Not buy";}
		if (cn == 27){if (playercoin1>= 40){Player1BnTex [26].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 40); PlayerPrefs.SetInt("G1CellCard27",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [26].text = "Not buy";}
		if (cn == 28){if (playercoin1>= 30){Player1BnTex [27].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 30); PlayerPrefs.SetInt("G1CellCard28",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [27].text = "Not buy";}
		if (cn == 29){if (playercoin1>= 20){Player1BnTex [28].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 20); PlayerPrefs.SetInt("G1CellCard29",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [28].text = "Not buy";}		
		if (cn == 30){if (playercoin1>= 12){Player1BnTex [29].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 12); PlayerPrefs.SetInt("G1CellCard30",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [29].text = "Not buy";}
		// Orange Content
		if (cn == 31){if (playercoin1 >= 8 && RNC[20] == Rand) {Sefe1();Player1BnTex [30].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 8); PlayerPrefs.SetInt("G1CellCard31",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [30].text = "Not buy";}
		if (cn == 32){if (playercoin1 >= 6 && RNC[21] == Rand) {Sefe1();Player1BnTex [31].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 6); PlayerPrefs.SetInt("G1CellCard32",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [31].text = "Not buy";}
		if (cn == 33){if (playercoin1 >= 7 && RNC[22] == Rand) {Sefe1();Player1BnTex [32].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 7); PlayerPrefs.SetInt("G1CellCard33",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [32].text = "Not buy";}
		if (cn == 34){if (playercoin1 >= 5 && RNC[23] == Rand) {Sefe1();Player1BnTex [33].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard34",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [33].text = "Not buy";}		
		if (cn == 35){if (playercoin1 >= 4 && RNC[24] == Rand) {Sefe1();Player1BnTex [34].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 4); PlayerPrefs.SetInt("G1CellCard35",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [34].text = "Not buy";}
		if (cn == 36){if (playercoin1 >= 9 && RNC[25] == Rand) {Sefe1();Player1BnTex [35].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 9); PlayerPrefs.SetInt("G1CellCard36",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [35].text = "Not buy";}
		if (cn == 37){if (playercoin1 >= 8 && RNC[26] == Rand) {Sefe1();Player1BnTex [36].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 8); PlayerPrefs.SetInt("G1CellCard37",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [36].text = "Not buy";}
		if (cn == 38){if (playercoin1 >= 10 && RNC[27] == Rand) {Sefe1();Player1BnTex [37].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 10); PlayerPrefs.SetInt("G1CellCard38",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [37].text = "Not buy";}
		if (cn == 39){if (playercoin1 >= 5 && RNC[28] == Rand) {Sefe1();Player1BnTex [38].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard39",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [38].text = "Not buy";}		
		if (cn == 40){if (playercoin1 >= 6 && RNC[29] == Rand) {Sefe1();Player1BnTex [39].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 6); PlayerPrefs.SetInt("G1CellCard40",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [39].text = "Not buy";}
		// Yellow Content
		if (cn == 41){if (playercoin1 >= 5 && RNC[30] == Rand) {Sefe1();Player1BnTex [40].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard41",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [40].text = "Not buy";}
		if (cn == 42){if (playercoin1 >= 6 && RNC[31] == Rand) {Sefe1();Player1BnTex [41].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 6); PlayerPrefs.SetInt("G1CellCard42",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [41].text = "Not buy";}
		if (cn == 43){if (playercoin1 >= 10 && RNC[32] == Rand) {Sefe1();Player1BnTex [42].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 10); PlayerPrefs.SetInt("G1CellCard43",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [42].text = "Not buy";}
		if (cn == 44){if (playercoin1 >= 9 && RNC[33] == Rand) {Sefe1();Player1BnTex [43].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 9); PlayerPrefs.SetInt("G1CellCard44",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [43].text = "Not buy";}		
		if (cn == 45){if (playercoin1 >= 5 && RNC[34] == Rand) {Sefe1();Player1BnTex [44].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard45",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [44].text = "Not buy";}
		if (cn == 46){if (playercoin1 >= 5 && RNC[35] == Rand) {Sefe1();Player1BnTex [45].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard46",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [45].text = "Not buy";}
		if (cn == 47){if (playercoin1 >= 4 && RNC[36] == Rand) {Sefe1();Player1BnTex [46].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 4); PlayerPrefs.SetInt("G1CellCard47",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [46].text = "Not buy";}
		if (cn == 48){if (playercoin1 >= 5 && RNC[37] == Rand) {Sefe1();Player1BnTex [47].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 5); PlayerPrefs.SetInt("G1CellCard48",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [47].text = "Not buy";}
		if (cn == 49){if (playercoin1 >= 2 && RNC[38] == Rand) {Sefe1();Player1BnTex [48].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 2); PlayerPrefs.SetInt("G1CellCard49",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [48].text = "Not buy";}		
		if (cn == 50){if (playercoin1 >= 1 && RNC[39] == Rand) {Sefe1();Player1BnTex [49].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins1", playercoin1 - 1); PlayerPrefs.SetInt("G1CellCard50",1); for (int i = 0; i<=49; i++){Destroy (Player1Buttons [i]);};}else Player1BnTex [49].text = "Not buy";}
	}

	public void VoidPlayer2(int cn){
		// Blue Content
		if (cn == 1){if (playercoin2 >= 2 && RNC[40] == Rand) {Sefe2();Player2BnTex [0].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard01",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [0].text = "Not buy";}
		if (cn == 2){if (playercoin2 >= 4 && RNC[41] == Rand) {Sefe2();Player2BnTex [1].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 4); PlayerPrefs.SetInt("G2CellCard02",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [1].text = "Not buy";}
		if (cn == 3){if (playercoin2 >= 5 && RNC[42] == Rand) {Sefe2();Player2BnTex [2].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard03",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [2].text = "Not buy";} 
		if (cn == 4){if (playercoin2 >= 6 && RNC[43] == Rand) {Sefe2();Player2BnTex [3].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 6); PlayerPrefs.SetInt("G2CellCard04",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [3].text = "Not buy";} 
		if (cn == 5){if (playercoin2 >= 2 && RNC[44] == Rand) {Sefe2();Player2BnTex [4].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard05",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [4].text = "Not buy";} 
		if (cn == 6){if (playercoin2 >= 1 && RNC[45] == Rand) {Sefe2();Player2BnTex [5].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 1); PlayerPrefs.SetInt("G2CellCard06",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [5].text = "Not buy";} 
		if (cn == 7){if (playercoin2 >= 2 && RNC[46] == Rand) {Sefe2();Player2BnTex [6].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard07",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [6].text = "Not buy";} 
		if (cn == 8){if (playercoin2 >= 1 && RNC[47] == Rand) {Sefe2();Player2BnTex [7].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 1); PlayerPrefs.SetInt("G2CellCard08",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [7].text = "Not buy";} 
		if (cn == 9){if (playercoin2 >= 2 && RNC[48] == Rand) {Sefe2();Player2BnTex [8].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard09",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [8].text = "Not buy";} 
		if (cn == 10){if (playercoin2 >= 5 && RNC[49] == Rand) {Sefe2();Player2BnTex [9].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard10",1);for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [9].text = "Not buy";} 
		// White Content
		if (cn == 11){if (playercoin2 >= 2 && RNC[50] == Rand) {Sefe2();Player2BnTex [10].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard11",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [10].text = "Not buy";} 
		if (cn == 12){if (playercoin2 >= 2 && RNC[51] == Rand) {Sefe2();Player2BnTex [11].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard12",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [11].text = "Not buy";}
		if (cn == 13){if (playercoin2 >= 7 && RNC[52] == Rand) {Sefe2();Player2BnTex [12].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 7); PlayerPrefs.SetInt("G2CellCard13",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [12].text = "Not buy";}
		if (cn == 14){if (playercoin2 >= 2 && RNC[53] == Rand) {Sefe2();Player2BnTex [13].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard14",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [13].text = "Not buy";}		
		if (cn == 15){if (playercoin2 >= 1 && RNC[54] == Rand) {Sefe2();Player2BnTex [14].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 1); PlayerPrefs.SetInt("G2CellCard15",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [14].text = "Not buy";}
		if (cn == 16){if (playercoin2 >= 5 && RNC[55] == Rand) {Sefe2();Player2BnTex [15].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard16",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [15].text = "Not buy";}
		if (cn == 17){if (playercoin2 >= 4 && RNC[56] == Rand) {Sefe2();Player2BnTex [16].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 4); PlayerPrefs.SetInt("G2CellCard17",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [16].text = "Not buy";}
		if (cn == 18){if (playercoin2 >= 6 && RNC[57] == Rand) {Sefe2();Player2BnTex [17].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 6); PlayerPrefs.SetInt("G2CellCard18",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [17].text = "Not buy";}
		if (cn == 19){if (playercoin2 >= 1 && RNC[58] == Rand) {Sefe2();Player2BnTex [18].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 1); PlayerPrefs.SetInt("G2CellCard19",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [18].text = "Not buy";}	
		if (cn == 20){if (playercoin2 >= 4 && RNC[59] == Rand) {Sefe2();Player2BnTex [19].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 4); PlayerPrefs.SetInt("G2CellCard20",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [19].text = "Not buy";}
		// Green Content
		if (cn == 21){if (playercoin2 >= 8) {Player2BnTex [20].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 8); PlayerPrefs.SetInt("G2CellCard21",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [20].text = "Not buy";}
		if (cn == 22){if (playercoin2 >= 35) {Player2BnTex [21].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 35); PlayerPrefs.SetInt("G2CellCard22",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [21].text = "Not buy";}
		if (cn == 23){if (playercoin2 >= 22) {Player2BnTex [22].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 22); PlayerPrefs.SetInt("G2CellCard23",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [22].text = "Not buy";}
		if (cn == 24){if (playercoin2 >= 16) {Player2BnTex [23].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 16); PlayerPrefs.SetInt("G2CellCard24",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [23].text = "Not buy";}		
		if (cn == 25){if (playercoin2 >= 25) {Player2BnTex [24].text ="Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 25); PlayerPrefs.SetInt("G2CellCard25",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [24].text = "Not buy";}
		if (cn == 26){if (playercoin2>= 28){Player2BnTex [25].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 28); PlayerPrefs.SetInt("G2CellCard26",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [25].text = "Not buy";}
		if (cn == 27){if (playercoin2>= 40){Player2BnTex [26].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 40); PlayerPrefs.SetInt("G2CellCard27",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [26].text = "Not buy";}
		if (cn == 28){if (playercoin2>= 30){Player2BnTex [27].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 30); PlayerPrefs.SetInt("G2CellCard28",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [27].text = "Not buy";}
		if (cn == 29){if (playercoin2>= 20){Player2BnTex [28].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 20); PlayerPrefs.SetInt("G2CellCard29",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [28].text = "Not buy";}		
		if (cn == 30){if (playercoin2>= 12){Player2BnTex [29].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 12); PlayerPrefs.SetInt("G2CellCard30",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [29].text = "Not buy";}
		// Orange Content
		if (cn == 31){if (playercoin2 >= 8 && RNC[60] == Rand) {Sefe2();Player2BnTex [30].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 8); PlayerPrefs.SetInt("G2CellCard31",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [30].text = "Not buy";}
		if (cn == 32){if (playercoin2 >= 6 && RNC[61] == Rand) {Sefe2();Player2BnTex [31].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 6); PlayerPrefs.SetInt("G2CellCard32",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [31].text = "Not buy";}
		if (cn == 33){if (playercoin2 >= 7 && RNC[62] == Rand) {Sefe2();Player2BnTex [32].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 7); PlayerPrefs.SetInt("G2CellCard33",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [32].text = "Not buy";}
		if (cn == 34){if (playercoin2 >= 5 && RNC[63] == Rand) {Sefe2();Player2BnTex [33].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard34",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [33].text = "Not buy";}		
		if (cn == 35){if (playercoin2 >= 4 && RNC[64] == Rand) {Sefe2();Player2BnTex [34].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 4); PlayerPrefs.SetInt("G2CellCard35",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [34].text = "Not buy";}
		if (cn == 36){if (playercoin2 >= 9 && RNC[65] == Rand) {Sefe2();Player2BnTex [35].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 9); PlayerPrefs.SetInt("G2CellCard36",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [35].text = "Not buy";}
		if (cn == 37){if (playercoin2 >= 8 && RNC[66] == Rand) {Sefe2();Player2BnTex [36].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 8); PlayerPrefs.SetInt("G2CellCard37",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [36].text = "Not buy";}
		if (cn == 38){if (playercoin2 >= 10 && RNC[67] == Rand) {Sefe2();Player2BnTex [37].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 10); PlayerPrefs.SetInt("G2CellCard38",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [37].text = "Not buy";}
		if (cn == 39){if (playercoin2 >= 5 && RNC[68] == Rand) {Sefe2();Player2BnTex [38].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard39",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [38].text = "Not buy";}		
		if (cn == 40){if (playercoin2 >= 6 && RNC[69] == Rand) {Sefe2();Player2BnTex [39].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 6); PlayerPrefs.SetInt("G2CellCard40",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [39].text = "Not buy";}
		// Yellow Content
		if (cn == 41){if (playercoin2 >= 5 && RNC[70] == Rand) {Sefe2();Player2BnTex [40].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard41",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [40].text = "Not buy";}
		if (cn == 42){if (playercoin2 >= 6 && RNC[71] == Rand) {Sefe2();Player2BnTex [41].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 6); PlayerPrefs.SetInt("G2CellCard42",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [41].text = "Not buy";}
		if (cn == 43){if (playercoin2 >= 10 && RNC[72] == Rand) {Sefe2();Player2BnTex [42].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 10); PlayerPrefs.SetInt("G2CellCard43",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [42].text = "Not buy";}
		if (cn == 44){if (playercoin2 >= 9 && RNC[73] == Rand) {Sefe2();Player2BnTex [43].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 9); PlayerPrefs.SetInt("G2CellCard44",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [43].text = "Not buy";}		
		if (cn == 45){if (playercoin2 >= 5 && RNC[74] == Rand) {Sefe2();Player2BnTex [44].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard45",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [44].text = "Not buy";}
		if (cn == 46){if (playercoin2 >= 5 && RNC[75] == Rand) {Sefe2();Player2BnTex [45].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard46",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [45].text = "Not buy";}
		if (cn == 47){if (playercoin2 >= 4 && RNC[76] == Rand) {Sefe2();Player2BnTex [46].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 4); PlayerPrefs.SetInt("G2CellCard47",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [46].text = "Not buy";}
		if (cn == 48){if (playercoin2 >= 5 && RNC[77] == Rand) {Sefe2();Player2BnTex [47].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 5); PlayerPrefs.SetInt("G2CellCard48",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [47].text = "Not buy";}
		if (cn == 49){if (playercoin2 >= 2 && RNC[78] == Rand) {Sefe2();Player2BnTex [48].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 2); PlayerPrefs.SetInt("G2CellCard49",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [48].text = "Not buy";}		
		if (cn == 50){if (playercoin2 >= 1 && RNC[79] == Rand) {Sefe2();Player2BnTex [49].text = "Purchase"; PlayerPrefs.SetInt ("Playercoins2", playercoin2 - 1); PlayerPrefs.SetInt("G2CellCard50",1); for (int i = 0; i<=49; i++){Destroy (Player2Buttons [i]);};}else Player2BnTex [49].text = "Not buy";}
	}

	public void Exit(){Application.Quit();}
}