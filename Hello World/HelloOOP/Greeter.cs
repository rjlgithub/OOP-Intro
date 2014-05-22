using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    //This is a Class
    public class Greeter
    {
        #region Fields and Properties
        // traditional Field + Property combination
        //This is a Field
        private string _GreetingMessage;
        //This is a Property
        public string GreetingMessage
        {
            get
            {
                return _GreetingMessage;
            }
            private set
            {
                _GreetingMessage = value;
            }
        }

        // Auto-implemented Property (field as a "backing store" is "auto-generated")
        //This is a Property
        public string FarewellMessage { get; private set; }
        #endregion

        #region Constructors
        //This is a Constructor
        public Greeter(string greeting, string farewell)
        {
            GreetingMessage = greeting;
            FarewellMessage = farewell;
        }
        #endregion

        #region Methods
        //This is a Method
        public string SayGreeting(string name)
        {
            return name + ", " + GreetingMessage;
        }

        //This is a Method
        public string SayGreeting()
        {
            return GreetingMessage;
        }

        //This is a Method
        public string SayGoodbye(string name)
        {
            return name + " - " + FarewellMessage;
        }

        //This is a Method
        public string SayGoodbye()
        {
            return FarewellMessage;
        }
        #endregion
    }
}
