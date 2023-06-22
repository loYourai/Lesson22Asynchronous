



var heatThePen = Task.Run(HeatUpAPen);
var boilWater = Task.Run(BoilSomeWater);





await Task.WhenAll(heatThePen);
var fryToEggs = Task.Run(FryTwoEEggs);
await fryToEggs;
var fryThreeSlicesOfBacon = Task.Run(() => FryThreeSlicesOfBacon());

await Task.WhenAll(boilWater);
var coffe = Task.Run(MakeSomeCoffe);

await Task.WhenAll(fryThreeSlicesOfBacon, coffe);



while (true)
{

    await Task.Delay(1000);

}



Console.ReadLine();


async void HeatUpAPen()
{

    Thread.Sleep(1000);
    Console.WriteLine("i'm firing pen...");
}

async void BoilSomeWater()
{

    Thread.Sleep(5000);
    Console.WriteLine("i'm firing water...");
}

async void FryTwoEEggs()
{

    Thread.Sleep(3000);
    Console.WriteLine("i'm firing eggs...");
}

async void FryThreeSlicesOfBacon()
{

    Thread.Sleep(2000);
    Console.WriteLine("i'm firing bacon...");
}


async void MakeSomeCoffe()
{

    Thread.Sleep(1000);
    Console.WriteLine("i'm firing coffee...");
}





