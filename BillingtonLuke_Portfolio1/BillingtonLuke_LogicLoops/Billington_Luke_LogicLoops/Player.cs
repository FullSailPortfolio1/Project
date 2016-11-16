using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billington_Luke_LogicLoops
{
    class Player
    {

        private string mDisplay;
        private string mName;
        private string mBio;
        private int mBaseHealth;
        private int mBaseDamage;
        private int mBaseEnergy;
        private int mHealthMultiplier;
        private int mDamageMultiplier;
        private int mEnergyMultiplier;
        private int mHealth = 150;
        private int mEnergy = 150;
        private Random mRandom;
        private int mX;
        private int mY;
        private int mRoundRoll = 0;
        private int mRoundMultiplier = 0;
        private int mRoundHealth = 0;
        private int mRoundDamage = 0;
        private int mRoundEnergy = 0;
        private string mRoundMessage = "";

        public Player(Character _character, Random _random)
        {
            this.mDisplay = _character.GetDisplay();
            this.mName = _character.GetName();
            this.mBio = _character.GetBio();
            this.mBaseHealth = _character.GetBaseHealth();
            this.mBaseDamage = _character.GetBaseDamage();
            this.mBaseEnergy = _character.GetBaseEnergy();
            this.mHealthMultiplier = 150 / this.mBaseHealth;
            this.mDamageMultiplier = 150 / this.mBaseDamage;
            this.mEnergyMultiplier = 150 / this.mBaseEnergy;
            this.mRandom = _random;
            this.mX = this.mRandom.Next(0,12);
            this.mY = this.mRandom.Next(0, 12);
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

        public int GetHealthMultiplier()
        {
            return mHealthMultiplier;
        }

        public int GetDamageMultiplier()
        {
            return mDamageMultiplier;
        }

        public int GetEnergyMultiplier()
        {
            return mEnergyMultiplier;
        }

        public int GetX()
        {
            return mX;
        }

        public int GetY()
        {
            return mY;
        }

        public int GetHealth()
        {
            return mHealth;
        }

        public int GetEnergy()
        {
            return mEnergy;
        }

        public int GetRoundRoll()
        {
            return mRoundRoll;
        }

        public int GetRoundMultiplier()
        {
            return mRoundMultiplier;
        }

        public int GetRoundHealth()
        {
            return mRoundHealth;
        }

        public int GetRoundDamage()
        {
            return mRoundDamage;
        }

        public int GetRoundEnergy()
        {
            return mRoundEnergy;
        }

        public string GetRoundMessage()
        {
            return mRoundMessage;
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

        public void SetX(int _x)
        {
            mX = _x;
        }

        public void SetY(int _y)
        {
            mY = _y;
        }

        public void SetHealth(int _health)
        {
            mHealth = _health;
        }

        public void SetEnergy(int _energy)
        {
            mEnergy = _energy;
        }

        public void SetRoundRoll()
        {
            mRoundRoll = this.mRandom.Next(1, 7);
        }

        public void SetRoundMultiplier()
        {
            mRoundMultiplier = this.mRandom.Next(1,11);
        }

        public void Attack(Player opponent)
        {
            int energy = this.mRoundMultiplier * this.mEnergyMultiplier;

            if (this.mEnergy < energy)
            {
                this.mRoundDamage = 0;
                this.mRoundEnergy = -1 * energy;
                this.mRoundHealth = 0;
                this.mRoundMessage = "\tThe " + this.mName + " did not have enough energy to attack the " + opponent.GetName() + ", but gained " + energy + " energy.";

                this.mEnergy += energy;
            } else
            {
                int x = Math.Abs(this.mX - opponent.GetX());
                int y = Math.Abs(this.mY - opponent.GetY());
                if (x == 0)
                {
                    x = 1;
                }
                if (y == 0)
                {
                    y = 1;
                }
                int xMultiplier = 12 / x;
                int yMultiplier = 12 / y;
                int randMultiplier = mRandom.Next(1, 11);
                this.mRoundMultiplier = (xMultiplier + yMultiplier + randMultiplier) / 3;

                this.mRoundDamage = this.mRoundMultiplier * this.mDamageMultiplier;
                this.mRoundEnergy = this.mRoundMultiplier * this.mEnergyMultiplier;
                this.mRoundHealth = opponent.GetHealthMultiplier() * this.mRoundDamage;
                this.mRoundMessage = "\tThe " + opponent.GetName() + " lost " + this.mRoundHealth + " health as the " + this.mName + " caused " + this.mRoundDamage + " damage using " + this.mRoundEnergy + " energy.";

                this.mEnergy -= this.mRoundEnergy;
                opponent.SetHealth(opponent.GetHealth() - this.mRoundHealth);
            }
        }

        public void Roll()
        {
            this.SetRoundRoll();
        }

        public void Move(int shrink)
        {
            int moves = 0;
            int min = 0 + shrink;
            int max = 11 - shrink;
            while(moves < this.mRoundRoll)
            {
                int x = this.mX;
                int y = this.mY;
                bool moved = false;
                int direction = this.mRandom.Next(0, 4);
                if (x < min)
                {
                    this.mX = min;
                }
                if (x > max)
                {
                    this.mX = max;
                }
                if (y < min)
                {
                    this.mY = min;
                }
                if (y > max)
                {
                    this.mY = max;
                }
                if (direction == 0)
                {
                    y--;
                    moved = true;
                }
                else if (direction == 1)
                {
                    y++;
                    moved = true;
                }
                else if (direction == 2)
                {
                    x--;
                    moved = true;
                }
                else if (direction == 3)
                {
                    x++;
                    moved = true;
                }

                if (moved == true && x >= min && x <= max && y >= min && y <= max)
                {
                    this.mX = x;
                    this.mY = y;
                    moves++;
                }

            }
        }
    }
}
