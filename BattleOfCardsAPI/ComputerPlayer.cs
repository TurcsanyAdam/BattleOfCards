﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public class ComputerPlayer : Player
    {

        public ComputerPlayer(string Name ) : base(Name)
        {

        }
        public override string ChooseTheSpecification()
        {
            return "return";
        }
    }
}
