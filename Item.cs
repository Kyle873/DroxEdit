/* --------------------------------------------------
// Item Structure
// 

 NOTES:
 * Header is 8 bytes, 0x9600000008000000
 * Blank items are 4 bytes, simply the blank header
 * Each modifier has it's own corresponding delimiter + ID as well
 * File size is dependant on the size and capacities of the inserted cargo bays
 * The header for the beginning of each bag is 32 bytes long, ending with 0x04000000

    byte[4] header;         // 0x01000000 if an item exists here
    string name;            // Name and prefix are seperated by a -
    string prefix;          // Seperated from name by a -, only the 4 default prefixes are valid
    int id;                 // Randomly generated if none is given, doesn't actually seem to be checked or used in any way
    bool identified;
    int modifierCount;
    Modifier[] modifiers;
    int armor;
    int defense;
    int powerLoad;
    byte[13] delimiter
    int durability;
    int durabilityMax;
    byte[8] unknown;        // Almost always "HB" or "HC", seems to have differing sizes depending on the item type?
    int minLevel;

*/

using System;
using System.Collections.Generic;

namespace DroxEdit
{
    public class Item
    {
        public static string[] Prefixes =
        {
            "Cheap",
            "Budget",
            "Superior",
            "Excellent"
        };

        public string name = "Unknown Item";
        public string imageKey = string.Empty;
        public string prefix = string.Empty;
        public string type = string.Empty;
        public int rank = 0;
        public int rankMax = 0;
        public int id = 0;
        public bool identified = true;
        public int modifierCount = 0;
        public List<String> modifiers = new List<string>();
        public int armor = 0;
        public int defense = 0;
        public int powerLoad = 0;
        public int durability = 10;
        public int durabilityMax = 10;
        public int minLevel = 0;

        public void GenerateID()
        {
            id = new Random((int)DateTime.Now.Ticks).Next(Int32.MinValue, Int32.MaxValue);
        }

        public string GetRarity()
        {
            // Check for having over 7 modifiers, which can only be done in the editor
            if (modifierCount > 7)
                return "Legendary";

            switch (modifierCount)
            {
                case 0: return "Normal";
                case 1: return "Common";
                case 2: return "Uncommon";
                case 3: return "Rare";
                case 4: return "Very Rare";
                case 5: return "Elite";
                case 6: return "Artifact";
                case 7: return "Legendary";
                default: return string.Empty;
            }
        }

        public string GetNumeral()
        {
            switch (rank)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                case 10: return "X";
                case 11: return "XI";
                case 12: return "XII";
                case 13: return "XIII";
                case 14: return "XIV";
                case 15: return "XV";
                case 16: return "XVI";
                case 17: return "XVII";
                case 18: return "XVIII";
                case 19: return "XIX";
                case 20: return "XX";
                case 21: return "XXI";
                case 22: return "XXII";
                case 23: return "XXIII";
                case 24: return "XXIV";
                case 25: return "XXV";
                default: return string.Empty;
            }
        }

        public override string ToString()
        {
            return prefix + " " + name + " " + GetNumeral();
        }
    }
}
