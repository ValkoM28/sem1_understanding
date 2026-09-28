int batteryLevel = 30;
string lightColor = "";


if(batteryLevel == 100)
{
    lightColor = "White";
}
else if(batteryLevel >= 75)
{
    lightColor = "Blue";
}
else if(batteryLevel >= 50)
{
    lightColor = "Green";
}
else if(batteryLevel >= 25)
{
    lightColor = "Yellow";
}
else
{
    lightColor = "Red";
}


lightColor = batteryLevel switch
{
    100 => "White",
    >=75 => "Blue",
    >=50 => "Green",
    >=25 => "Yellow",
    >=0 => "Red",
};


switch(batteryLevel)
{
    case 100:
        lightColor = "White";
        break;
    case >=75:
        lightColor = "Blue";
        break;
    case >=50:
        lightColor = "Green";
        break;        
    case >=25:
        lightColor = "Yellow";
        break;    
    case >=0:
        lightColor = "Red";
        break;
}


Console.WriteLine($"The battery level is {batteryLevel}, the color is {lightColor}");