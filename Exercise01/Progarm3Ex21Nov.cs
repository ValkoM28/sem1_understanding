int batteryPercent = 30;
string powerMode = "";
switch(batteryPercent)
{
    case <= 10:
        powerMode = "PowerSaver";
        break;
    case <= 20:
        powerMode = "Restricted";
        break;
    case <= 50:
        powerMode = "Balanced";
        break;
    case >50:
        powerMode = "Performance";
        break;
}
Console.WriteLine($"The battery percentage is {batteryPercent}, the power mode is {powerMode}.");