﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Path : GameObject
    {
        bool _isBlocked;

        Location _source, _destination;

        public Path(string[] idents, string name, string desc, Location source, Location destination) : base(idents, name, desc)
        {
            _source = source;
            _destination = destination;
            _isBlocked = false;

            AddIdentifier("path");
            foreach (string s in name.Split(" "))
            {
                AddIdentifier(s);
            }
        }

        public Location Destination
        {
            get { return _destination; }
        }

        public override string ShortDescription
        {
            get { return Name; }
        }

        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }
    }
}
