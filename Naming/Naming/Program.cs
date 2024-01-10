// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

int d = 120; //Bir personelin işe girdiğinden beri geçen gün sayısı
int day = 120;
int daysSinceEmployeeHired = 120;

//1. Değişken isimleri, mümkün olduğunca açık, kısa ve  anlaşılır  olmalı.
int calisaninIseGirdigindenBeriGecenGun = 120;
int calisanGunSayisi = 120;

//Code Guideline: Genellikle altyapı ekibi tarafından belirlenen, kurallar dizisi.
/* 
 *  Takım
 *  Departman
 *  Dil (Teknoloji)
 *  Tüm Şirket ->
 *   *  
 */
bool banuAlkan = false;


//kısaltma kullandığınız zaman, herkesin aynı şeyi anladığına emin olun.
var horsePower = 100;
var hitPoint = 100;
var healthPoint = 100;
var hp = 100;

//koleksiyon konusunda, ortak karar verin
var cities = new List<string>();
var cityList = new List<string>();

string strName = "Türkay";
int intAge = 43;
bool isCorrect = true;
bool isChanged = false;
bool hasProduct = true;
if (isCorrect)
{

}

bool boolIsChanged = false;


Random randomNumberGenerator = new Random();
FileStream reportFileStream = null;


//var o = 0;
//var l = 1;

//if (o==l)
//{
//    l = 1;
//}

List<int[]> cellsOnABoard = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();

    foreach (var cell in cellsOnABoard)
    {
        if (cell[0] == CellState.Flagged)
        {
            flaggedCells.Add(cell);
        }

    }
    return flaggedCells;
}
public class CellState
{
    public const int Empty = 0;
    public const int Flagged = 4;
    public const int Bomb = 1;

    //Tam olarak ne olduğu ve niçin kullanıldığı belli olmayan değerlere [Magic Values] diyoruz ve bu bir kod kirliliğidir.
}
public enum CellStateEnum
{
    Empty = 0,
    Flagged = 4,
    Bomb = 1
}







