using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100; //体力
	private int power = 25; //攻撃力
	// ------------- 課題 ----------------
	private int mp = 53; //魔力
	//攻撃用の関数
	public void Attack(){
		Debug.Log ( this.power + "のダメージを与えた");
	}
	//防御用の関数
	public void Defence(int damage){
		Debug.Log ( damage + "のダメージを受けた");
		//残りHPを減らす
		this.hp -= damage;
	}
	// ------------- 課題 ----------------
	//魔法用の関数
	public void Magic(int mgc){
		//mpが足りていいない場合
		//if (mp < 5){
			//Debug.Log ( "MPが足りないため魔法が使えない。");
		//それ以外の場合
		//} else {
			//mpを減らす
			//this.mp -= 5 * mgc;
			//Debug.Log ( "魔法攻撃をした。残りのMPは" + this.mp + "。");

		//}
		//mpが足りている場合
		if (mp > 5) {
			//mpを減らす
			this.mp -= 5 * mgc;
			//減らしたmpで魔法攻撃の表示
			Debug.Log ("魔法攻撃をした。残りのMPは" + this.mp + "。");
		} else {
			Debug.Log ( "MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	//[Hello,UnityChan」と表示する関数
	//void hello(){
		//Debug.Log ("Hello, UnityChan");
	//}

	//「Hello」に続けて引数の文字列を表示する関数
	//void HelloName(string name){
		//Debug.Log ("Hello, " + name);
	//}
	//「Hello」に続けてint型の引数
	//void HelloName(int name){
		//Debug.Log ("Hello, " + name);
	//}

	//第一引数と第二引数の値を足した値を返す関数
	//int Add(int a, int b){
		//第一引数と第二引数の値を足して、変数cに代入する
		//int c = a + b;
		//変数cを呼び出し元の関数に戻す
		//return c;
	//}
	//三つ目の引数
	//int Add(int a, int b, int c){
		//3つの引数の値を足して、変数dに代入する
		//int d = a + b + c;
		//変数dを呼び出し元の関数に戻す
		//return d;

	// Use this for initialization
	void Start () {

		//コンソールにhallo,Worldと表示
		//Debug.Log("Hallo,World.");

		//変数の宣言
		//int score;
		//変数の代入
		//score = 150;
		//コンソールに変数の中身を表示
		//Debug.Log(score);

		//変数を初期化する
		//int a = 3;
		//int b = 4;
		//変数aと変数bの合計値を変数cに代入する
		//int c = a + b;
		//変数cを表示する
		//Debug.Log(c);

		//moneyを200で初期化する
		//int money = 200;
		//moneyを50で初期化する
		//int money = 50;
		//if (money >= 100) {
		//moneyの値が100以上の場合、文字列を表示する
		//Debug.Log("ポーションを買う");
		//}

		//moneyを200で初期化する
		//int money = 200;
		//moneyを50で初期化する
		//int money = 50;
		//if (money >= 100) {
		//moneyが100以上の場合
		//Debug.Log ("ポーションを買う");
		//moneyが100未満の場合
		//} else {
		//Debug.Log ("武器を売る");
		//}

		//moneyを100で初期化する
		//int money = 100;
		//moneyを50で初期化する
		//int money = 50;
		//moneyを200で初期化する
		//int money = 200;
		//if (money <= 50) {
		//moneyが50以下だった場合の処理
		//Debug.Log ("武器を売る");
		//} else if (money >= 200) {
		//moneyが200以上だった場合の処理
		//Debug.Log ("武器を買う");
		//} else {
		//それ以外の場合の処理
		//Debug.Log ("ポーションを買う");
		//}

		//numを1で初期化する
		//int num = 1;
		//valに代入する値を条件によって切り換える（三項演算子）
		//int val = (num == 1) ? -100 : 100;
		//valの値を表示する
		//Debug.Log (val);

		//変数valを規定
		//int val;
		//変数numに1を代入
		//int num = 1;
		//numの価が1の場合
		//if (num == 1) {
		//val = -100;
		//それ以外の場合
		//} else {
		//val = 100;
		//}
		//valの値を表示する
		//Debug.Log (val);

		//変数aを3で初期化する
		//int a = 3;
		//if (a == 3) {
		//変数aが3の場合、変数bを５で初期化する
		//int b = 5;
		//変数bの値を表示する
		//Debug.Log( b );
		//}
		//変数bの値を表示する
		//Debug.Log( b );
		//5回処理を繰り返す
		//for (int i = 0; i < 5; i++){
		//15回処理を繰り返す
		//for (int i = 0; i < 15; i++){
		//Debug.Log(i);
		//}

		//sumを0で初期化する
		//int sum = 0;
		//10回処理を繰り返す
		//for (int i = 1; i <= 10; i++){
		//iの値をsumに足す
		//sum += i;
		//}
		//Debug.Log(sum);

		//要素数5の配列を初期化する
		//int[] points = new int[5];
		//配列の各要素に値を代入する
		//points [0] = 30;
		//points [1] = 20;
		//points [2] = 50;
		//points [3] = 10;
		//points [4] = 80;
		//配列の要素をすべて表示する
		//for (int i = 0; i < 5; i++){
		//Debug.Log (points [i]);
		//}

		//配列を初期化する
		//int[] points = {30, 20, 50, 10, 80, 15, 60, 100};
		//別配列の用意
		//int[] points = {30, 200, 50, 10, 40, 15, 60, 100 ,30 ,45, 65,};
		//配列の要素数のぶんだけ処理を繰り返す
		//for (int i = 0; i < points.Length; i++){
		//配列の要素が50以上の場合
		//if( points[i] >= 50 ){
		//配列の要素を表示する
		//Debug.Log (points [i]);
		//}
		//}

		//Hello関数を呼び出す
		//hello();

		//HelloNmae関数に「Unity」という引数を渡す
		//HelloName ("Unity");
		//int用
		//HelloName (5);

		//int関数に「3」と「6」の引数を渡し、返り値をnum変数に代入する
		//int num = Add (3,6);
		//numを表示する
		//Debug.Log(num);
		//int関数に「3」と「6」と「9」の引数を渡し、返り値をnum変数に代入する
		//int num = Add (3,6,9);
		//numを表示する
		//Debug.Log(num);

		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();
		//攻撃用関数を呼び出す
		lastboss.Attack ();
		//防御用関数を呼び出す
		lastboss.Defence (3);
		// ------------- 課題 ----------------
		lastboss.Magic (1); //1回目
		lastboss.Magic (1); //2回目
		lastboss.Magic (1); //3回目
		lastboss.Magic (1); //4回目
		lastboss.Magic (1); //5回目
		lastboss.Magic (1); //6回目
		lastboss.Magic (1); //7回目
		lastboss.Magic (1); //8回目
		lastboss.Magic (1); //9回目
		lastboss.Magic (1); //10回目
		lastboss.Magic (1); //魔力切れ
	}

		// ------------- 課題 ----------------
		//要素数が5個のint型の配列 arrayを宣言
		//int[] array = {10, 20, 30, 40, 50,};

		//for文を使用して各要素の値を順番に表示
		//for (int i = 0; i < 5; i++) {
			//Debug.Log (array [i]);
		//}

		//for文を使用して各要素の値を逆順に表示
		//for (int i = 4; i > -1; i--) {
			//Debug.Log (array [i]);
		//}

		//}
	
	// Update is called once per frame
	void Update () {
		
	}
}
