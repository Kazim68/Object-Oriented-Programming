using Pacman.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class PacmanPlayer : GameObject
    {
        // constructor
        public PacmanPlayer(char character, GameCell currentCell, GameObjectType type) : base(character, currentCell, type) { }

        public GameCell move(GameDirection direction)
        {
            GameCell next = base.CurrentCell.NextCell(direction); // getting next cell
            
            if (next != null)
            {
                next.Grid = CurrentCell.Grid;
                GameObject temp = new GameObject(' ', GameObjectType.NONE);
                GameCell cell = base.CurrentCell;                      // getting current cell of pacman
                cell.Object = temp;                                    // storing new temp in current cell
                GridUI.printCharacter(cell.X, cell.Y, temp.Character); // printing current character on console
                base.CurrentCell = next;
                GridUI.printCharacter(CurrentCell.X, CurrentCell.Y, base.Character); // printing pacman on new cell
            }
            return next;
        }

        // print pacman
        public void printPacman()
        {
            GridUI.printCharacter(base.CurrentCell.X, base.CurrentCell.Y, base.Character);
        }
    }
}
