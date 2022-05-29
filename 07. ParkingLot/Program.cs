using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {

        string command;
        var parkingLot = new HashSet<string>();

        while ((command = Console.ReadLine()) != "END")
        {
            var cmdArgs = command.Split(", ");
            string direction = cmdArgs[0];
            string carNumber = cmdArgs[1];

            if (direction == "IN")
            {
                parkingLot.Add(carNumber);
            }
            else if (direction == "OUT")
            {
                parkingLot.Remove(carNumber);
            }
        }
        if (parkingLot.Count > 0)
        {
            Console.Write(string.Join("\n", parkingLot));
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}
