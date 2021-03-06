using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RatonLibrary
{
    public static class Reader
    {
        public static string ReadMobs()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("mobs.csv");
                
                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.mobs.Add(Tokens[0]);
                }   
                inputFile.Close();
                return "";
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
        public static string ReadRooms()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("rooms.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.rooms.Add(Tokens[0]);
                }
                inputFile.Close();
                return "Loaded";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
        public static string ReadWeapons()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("weapons.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.weapons.Add(Tokens[0]);
                }
                inputFile.Close();
                return "Loaded";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
        public static string ReadPotions()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("potion.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.potions.Add(Tokens[0]);
                }
                inputFile.Close();
                return "YES";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
        public static string ReadItems()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("items.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.items.Add(Tokens[0]);
                }
                inputFile.Close();
                return "Loaded";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
        public static string ReadTreasure()
        {
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("treasure.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] Tokens = inputFile.ReadLine().Split(',');
                    World.treasures.Add(Tokens[0]);
                }
                inputFile.Close();
                return "Loaded";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
    }
    
}
