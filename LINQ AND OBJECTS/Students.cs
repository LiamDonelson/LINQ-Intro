using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AND_OBJECTS
{
    public class Students
    {
        //1) properties - yes we want to track age and name
        //2) Constructor - Yes as well, we want to use the constructor to fill in our properties
        //3) Methods - no we just represent to sell it, we dont care driving/accelerating 

        // the get and set allow us to alter the properties as the class is running
        // There are a lot with these so for right now know the get and set need to be there
        // Reason being is a) they're useful and b) .NET LOVES properties 
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructors are methods without a return type or static,they build and return an instance of the matching class.
        // In order to tell C# I am making a Student consturctor, the signature MUST match the name of the class

        // When I put parameters into my constuctor I am telling others this object REQUIRES these inputs
        // By having the parameter match the properties I am telling others THESE PARAMETERS are intended to fill in properties


        public Students(string Name, int Age)
        {
            //Why do we want to do the this.Name? fill out my property
            // Other languages call their this keyword as self

            this.Name = Name;
            this.Age = Age;

        }




    }
}
