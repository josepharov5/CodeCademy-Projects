using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Your code goes here
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";
  
    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);

    //increase passenger age by 1
    passengerAge++;
    Console.WriteLine(passengerAge);

    //explictly convert passengerAge to a double and assign to new variable
    double passengerAgeDouble = (double) passengerAge;
    Console.WriteLine(passengerAge);

    //implicitly convert pasengerAge to a doulbe and assign to new variable
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);

    //convert passengerAge to a string
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);


  }
}