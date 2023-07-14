/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectOfSixFor14_07
{
	/// <summary>
	/// Description of Levelup.
	/// </summary>
	public class Levelup
	{
		private int exp;
        private int xpNeeded;
        private int level = 1;
        public int Exp
        {
            get
            {
                return this.exp;
            }
            set
            {
                this.exp = value;
            }
        }
        public int XpNeeded
        {
            get
            {
                return this.xpNeeded;
            }
            set
            {
                this.xpNeeded = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
        public void LevelUp(int xp, int nxp, int level)
        {
            int newlevelup = level;
            do
            {
                if (xp >= nxp)
                {
                    newlevelup++;
                    xp = xp - nxp;
                    nxp *= 2;

                }
            }
            while (xp >= nxp);
            if (newlevelup > level)
            {
                level = newlevelup;
                this.level = level;
                this.xpNeeded = nxp;
                this.exp = xp;
                Console.WriteLine("--{3}-- You advanced to level {0}! (-- {1}/{2}XP till next level) --{3}--", level, xp, nxp, (char)0x2191);
            }
        }
        public bool YesLevelUp(int xp, int XpLevelUp, int bonus, int level)
        {
            if (xp >= XpLevelUp)
            {
                return true;
            }
            else
            {
                xp += bonus;
                return false;
            }
        }
	}
}
