using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Graph
    {
        public List<Flight> GetConnectingFlights(string fromFlight, string toFlight)
        {
            string fromtxt = fromFlight;
            string totxt = toFlight;
            Boolean flag = false;
            Flight flight = new Flight();
            List<Flight> alreadyVisited = new List<Flight>();
            Stack<Flight> myStack = new Stack<Flight>();
            List<Flight> myList = new List<Flight>();
            var apiData = flight.GetApiData();

            //Start from the origin city(fromtxt) that the user chooses and
            //find all the flights from there and put them
            //into a data structure (I used a Stack for a depth-first search).
            //Also put the origin city in an already visited List
            foreach (Flight f in apiData)
            {
                if (f.City1.Contains(fromtxt))
                {
                    myStack.Push(f);
                    alreadyVisited.Add(f);
                }
            }
            Console.WriteLine(myStack);
            Console.WriteLine(alreadyVisited);
            //While the stack data structure is not empty (use Count in C#)
            //and you haven’t found the destination city yet (use a boolean flag),
            //Pop the first flight(flight1)from the stack and print it out.
            //Save it in a visited data structure.

            while (myStack.Count > 0 && flag == false)
            {
                if (alreadyVisited.Any(n => n.City2 == totxt))
                    flag = true;
                //var alreadyInList = alreadyVisited.Find(x => (x.City2 == totxt))
                var first = myStack.Pop();
                myList.Add(first);
                alreadyVisited.Add(first);

                //Check if it’s the destination(city2) you are looking for.
                //If it is, you’re done.Display the results.
                if (totxt.Contains(first.City2))
                {
                    var destination = first;
                    myList.Add(destination);
                    Console.WriteLine(destination);
                    // done return result
                    break;
                }
                //Else  For each flight2 in the flights
                //If flight2’s city1 is equal to flight1’s city2 and it hasn’t been visited before,
                //push it into your stack data structure(so that your while loop above will consider
                //this in between flight).
                else
                {
                    foreach (var fl in apiData)
                    {
                        //(alreadyVisited.Any(n => n.City2 == totxt))
                        if (fl.City1 == fl.City2 && alreadyVisited.Any(n => n.City2 == totxt))
                        {
                            myStack.Push(fl);
                            myList.Add(fl);
                        }
                    }
                    Console.WriteLine(myStack);
                    Console.WriteLine(alreadyVisited);
                    Console.WriteLine(myList);
                }
            }
            return myList;
        }

    }
}


