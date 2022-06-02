using CSharpHub;

async Task FillWaterAsync()
{
    Console.WriteLine("Filling water to kettle");
    await WaitingInfo.WaitDots(6, "fill the water");
    Console.WriteLine("Kettle is full of water");
}

async Task BoilWaterAsync()
{
    Console.WriteLine("Started boiling the water");
    await WaitingInfo.WaitNumbers(25, "boil the water");
    Console.WriteLine("Water is boiled");
}

async Task PrepareCupAsync()
{
    Console.WriteLine("Preparing cup for coffee");
    await WaitingInfo.WaitNumbers(5, "prepare cup", "c");
    Console.WriteLine("Cup is prepared");
}

async Task PrepareMilkAsync()
{
    Console.WriteLine("Preparing milk");
    await WaitingInfo.WaitNumbers(5, "prepare milk", "m");
    Console.WriteLine("Milk is prepared");
}

await FillWaterAsync();
Task boiledWater = BoilWaterAsync();


await PrepareCupAsync();
await PrepareMilkAsync();
await boiledWater;

