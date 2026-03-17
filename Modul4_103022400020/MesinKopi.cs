using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400020
{
    public class MesinKopi
    {
        enum State { Off, StandBy, Brewing, Maintenance}

        public static void trigger()
        {

            State state = State.Off;
            string[] Statename = { "Off", "StandBy", "Brewing", "Maintenance" };
            do
            {
                Console.WriteLine("\n" + Statename[(int)state]);
                Console.Write("Enter Command : ");

                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Off:
                        if (command == "Power_On")
                            Console.WriteLine("StandBy");
                        state = State.StandBy;
                        break;
                    case State.StandBy:
                        if (command == "Start_Brew")
                            state = State.Brewing;
                        else if (command == "Start_Maintenance")
                            state = State.Maintenance;
                        else if (command == "Power_Off")
                            state = State.Off;
                        break;
                    case State.Brewing:
                        if (command == "Finish_Brew")
                            state = State.StandBy;
                        break;
                    case State.Maintenance:
                        if (command == "Finish_Maintenance")
                            state = State.StandBy;
                        break;

                }
                Console.WriteLine("State telah diubah menjadi: " + Statename[(int)state]);
            }while (state  != State.Off);
        }
    }
}
