using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billington_Luke_LogicLoops
{
    class Character
    {

        private string mDisplay;
        private string mName;
        private string mBio;
        private int mBaseHealth;
        private int mBaseDamage;
        private int mBaseEnergy;

        public Character(string _display, string _name, string _bio, int _baseHealth, int _baseDamage, int _baseEnergy)
        {
            this.mDisplay = _display;
            this.mName = _name;
            this.mBio = _bio;
            this.mBaseHealth = _baseHealth;
            this.mBaseDamage = _baseDamage;
            this.mBaseEnergy = _baseEnergy;
        }

        public string GetDisplay()
        {
            return mDisplay;
        }

        public string GetName()
        {
            return mName;
        }

        public string GetBio()
        {
            return mBio;
        }

        public int GetBaseHealth()
        {
            return mBaseHealth;
        }

        public int GetBaseDamage()
        {
            return mBaseDamage;
        }

        public int GetBaseEnergy()
        {
            return mBaseEnergy;
        }

        public void SetDisplay(string _display)
        {
            mDisplay = _display;
        }

        public void SetName(string _name)
        {
            mName = _name;
        }

        public void SetBio(string _bio)
        {
            mBio = _bio;
        }

        public void SetBaseHealth(int _baseHealth)
        {
            mBaseHealth = _baseHealth;
        }

        public void SetBaseDamage(int _baseDamage)
        {
            mBaseDamage = _baseDamage;
        }

        public void SetBaseEnergy(int _baseEnergy)
        {
            mBaseEnergy = _baseEnergy;
        }
    }
}
