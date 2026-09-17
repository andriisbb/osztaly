using osztaly;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(3100, "Golf", "Volkswagen");

Console.WriteLine($"Kék autó: {kek.Marka} {kek.Modell}, gyártási év: {kek.GyartasiEv}");

Console.WriteLine($"Zöld autó: {zold.Marka} {zold.Modell}, gyártási év: {zold.GyartasiEv}");