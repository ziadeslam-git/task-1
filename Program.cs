Console.WriteLine("How many small carpet you like cleaned?");
int smallRooms = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many large carpet you like cleaned?");
int largeRooms = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Estimate for cleaning:");
Console.WriteLine("smallRoomPri:25$.00");
decimal smallRoomPrice = 25.00m;
Console.WriteLine("large RoomPrice:35$.00");
decimal largeRoomPrice = 35.00m;
decimal totalEstimate = (smallRooms * smallRoomPrice) + (largeRooms * largeRoomPrice);
Console.WriteLine($"Total estimate for cleaning {smallRooms} small rooms and {largeRooms} large rooms is: ${totalEstimate}");
Console.WriteLine(" estimate and are valid for 30 days");
decimal salesTaxRate = 0.06m;
decimal salesTax = totalEstimate * salesTaxRate;
Console.WriteLine($"Total estimate including sales tax is: ${totalEstimate + salesTax}");

