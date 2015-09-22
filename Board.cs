﻿using System.Collections.Generic;
using System.Dynamic;

namespace Monopoly
{
    public class Board
    {
        private static readonly string[] _propertyNames =
        {
            "Go",
            "Mediterranean Avenue",
            "Community Chest",
            "Baltic Avenue",
            "Income Tax",
            "Reading RailRoad",
            "Oriental Avenue",
            "Chance",
            "Vermont Avenue",
            "Connecticut Avenue",
            "Jail",
            "St. Charles Place",
            "Electric Company",
            "States Avenue",
            "Virginia Avenue",
            "Pennsylvania Railroad",
            "St. James Place",
            "Community Chest",
            "Tennessee Avenue",
            "New York Avenue",
            "Free Parking",
            "Kentucky Avenue",
            "Chance",
            "Indiana Avenue",
            "Illinois Avenue",
            "B. & O. Railroad",
            "Atlantic Avenue",
            "Ventnor Avenue",
            "Water Works",
            "Marvin Gardens",
            "Go To Jail",
            "Pacific Avenue",
            "North Carolina Avenue",
            "Community Chest",
            "Pennsylvania Avenue",
            "Short Line Railroad",
            "Chance",
            "Park Place",
            "Luxury Tax",
            "Boardwalk",
        };
        private List<Property> properties = new List<Property>();

        public static int PropertyCount
        {
            get { return _propertyNames.Length; }
        }

        public static string[] PropertyNames
        {
            get { return _propertyNames; }
        }

        public Board()
        {
            foreach (var name in PropertyNames)
            {
                properties.Add(new Property(name));
            }
        }

        public Property GetProperty(int index)
        {
            return properties[index];
        }
    }
}