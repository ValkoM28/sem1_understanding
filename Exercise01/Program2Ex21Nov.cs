int playerRank = 25;       // Range: 1-50
int playerPing = 120;        // Range: 0-200 ms
bool hasMicrophone = false;  // true/false
string matchMode="";    // Will store: "Competitive", "Casual", or "Practice"

if((playerRank>=20 && playerPing<100) || hasMicrophone == true)
{
    matchMode="Competitive";
}
else if(playerRank>=10 && playerPing<150)
{
    matchMode="Casual";
}
else
{
    matchMode="Practice";
}
Console.WriteLine($"The rank of the player is {playerRank}, his ping is {playerPing}. So his match mode is {matchMode}");