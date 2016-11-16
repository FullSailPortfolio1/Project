using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billington_Luke_LogicLoops
{
    class Game
    {

        private Character[] mCharacters;
        private Random mRandom = new Random();
        private Player mPlayer1;
        private Player mPlayer2;
        private int mRound = 1;
        private bool mGameOn = true;
        private int mShrink = 0;
        private bool mWin = false;

        public Game(Character[] _characters)
        {
            //Import characters.
            this.mCharacters = _characters;

            //Let player choose their character type.
            int player1Type = View.ChooseCharacter(this.mCharacters);

            //Set player 2 as same player type, then choose random until not the same.
            int player2Type = player1Type;
            while (player2Type == player1Type)
            {
                player2Type = this.mRandom.Next(0, this.mCharacters.Length);
            }

            //Initialize players.
            this.mPlayer1 = new Player(this.mCharacters[player1Type], this.mRandom);
            this.mPlayer2 = new Player(this.mCharacters[player2Type], this.mRandom);

        }

        public void Play()
        {
            //Show opponent screen.
            View.Opponent(this.mPlayer1, this.mPlayer2);

            //Start game loop.
            while (this.mGameOn == true)
            {
                //Shrink game board on rounds 5, 15 and 30.
                if(this.mRound == 5)
                {
                    this.mShrink = 1;
                } else if(this.mRound == 15)
                {
                    this.mShrink = 2;
                } else if(this.mRound == 30)
                {
                    this.mShrink = 3;
                }

                //Players roll.
                this.mPlayer1.Roll();
                this.mPlayer2.Roll();

                //Display round roll screen.
                View.Roll(this.mPlayer1, this.mPlayer2, this.mRound, this.mShrink);

                //Display player 1 round move screen.
                View.Move(this.mPlayer1, this.mPlayer2, this.mRound, this.mShrink);

                //Player 2 move.
                this.mPlayer2.Move(this.mShrink);

                //Player 1 hits player 2.
                this.mPlayer1.Attack(this.mPlayer2);

                //Player 2 hits player 1.
                this.mPlayer2.Attack(this.mPlayer1);

                //Detect if health is below 0.
                if (this.mPlayer1.GetHealth() <= 0 || this.mPlayer2.GetHealth() <= 0)
                {
                    //End game.
                    this.mGameOn = false;
                    
                    //Determine winner.
                    if (this.mPlayer1.GetHealth() > this.mPlayer2.GetHealth())
                    {
                        this.mWin = true;
                    }
                }
                else
                {

                    //Display round attack screen.
                    View.Attack(this.mPlayer1, this.mPlayer2, this.mRound, this.mShrink);

                    //Advance to next round.
                    this.mRound++;
                }
            }
        }

        public bool Results()
        {
            //Output winner.
            View.Winner(this.mPlayer1, this.mPlayer2, this.mWin, this.mRound);

            return this.mWin;
        }
    }
}
