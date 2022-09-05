using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections;
using System.Security.Policy;


namespace GraphAlgorithms
{
    public class Graph
    {
        Form1 frm1 = new Form1();

        public Stack<string> GetConnectingFlights(string fromFlight, string toFlight)
        {
            string fromtxt = fromFlight;
            string totxt = toFlight;
            Boolean flag = false;
            Flight flight = new Flight();
            List<string> alreadyVisited = new List<string>();
            Stack<string> myStack = new Stack<string>();
            var apiData = flight.GetApiData();

            //Start from the origin city(fromTxtBox) that the user chooses and
            //find all the flights from there and put them
            //into a data structure (I used a Stack for a depth-first search).
            //Also put the origin city in an already visited List
            foreach (Flight f in apiData)
            {
                if (f.City1.Contains(fromtxt))
                {
                    myStack.Push(f.City1);
                    alreadyVisited.Add(f.City1);
                }
            }
            Console.WriteLine(myStack);
            //While the stack data structure is not empty (use Count in C#)
            //and you haven’t found the destination city yet (use a boolean flag),
            //Pop the first flight(flight1) from the stack and print it out.
            //Save it in a visited data structure.
            //Check if it’s the destination(city2) you are looking for.
            //If it is, you’re done.Display the results.


            while (myStack.Count > 0 && flag == false)
            {
                if (alreadyVisited.Contains(totxt) == true)
                {
                    flag = true;
                }
                var first = myStack.Pop();
                alreadyVisited.Add(first);


                if (totxt.Contains(first))
                {
                    var destination = first;
                    Console.WriteLine(destination);
                    break;
                    // done return results somehow
                }
                //Else  For each flight2 in the flights
                //If flight2’s city1 is equal to flight1’s city2(toTxtBox) and it hasn’t been visited before,
                //push it into your stack data structure(so that your while loop above will consider
                //this in between flight).
                //Test with Atlantic City, NJ to Syracuse, NY (for some reason needs to
                //go through Miami, FL or Orlando, FL)
                else
                {
                    foreach (var fl in apiData)
                    {
                        if (fl.City1 == totxt && alreadyVisited.Contains(fl.City1) == false)
                        {
                            myStack.Push(totxt);
                        }
                    }
                    Console.WriteLine(myStack);
                    Console.WriteLine(alreadyVisited);
                }
            }


            return myStack;
        }
    }
}

