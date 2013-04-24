﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeAnimationAndStanceMessage.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the ChangeAnimationAndStanceMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.Messages.N3Messages.CharacterActionMessages
{
    using SmokeLounge.AOtomation.Messaging.Serialization;

    [AoContract((int)CharacterActionType.ChangeAnimationAndStance)]
    public class ChangeAnimationAndStanceMessage : CharacterActionMessage
    {
        #region Constructors and Destructors

        public ChangeAnimationAndStanceMessage()
        {
            this.CharacterActionType = CharacterActionType.ChangeAnimationAndStance;
        }

        #endregion

        #region Public Properties

        [AoMember(0)]
        public int Unknown1 { get; set; }

        [AoMember(1)]
        public int Unknown2 { get; set; }

        [AoMember(2)]
        public int Unknown3 { get; set; }

        [AoMember(3)]
        public int Unknown4 { get; set; }

        [AoMember(4)]
        public int Unknown5 { get; set; }

        [AoMember(5)]
        public short Unknown6 { get; set; }

        #endregion
    }
}