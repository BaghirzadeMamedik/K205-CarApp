using K205_CarApp.Metods;

Console.WriteLine("1. Yola cix");
Console.WriteLine("2. Benzin doldur");
Console.WriteLine("3. Yanacaq miqdari");
Console.WriteLine("4. Yurush");
Console.WriteLine("5. Cixish");
//////////////////////////////////////////

string daxilEdilenReqem = Console.ReadLine();

Go start = new Go();

decimal benzin = 100M;

/// //////////////////////////////////////


switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        start.HereketeBasla(benzin);

        break;
    case 2:


        break;
    case 3:


        break;
    case 4:


        break;
    case 5:


        break;
    default:

        break;
}

