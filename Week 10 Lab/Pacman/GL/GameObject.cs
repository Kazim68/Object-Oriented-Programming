using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class GameObject
    {
        private char character;
        private GameObjectType type;
        private GameCell currentCell;

        // getters and setters
        public char Character { get => character; set => character = value; }
        public GameObjectType Type { get => type; set => type = value; }
        public GameCell CurrentCell { get => currentCell; set => currentCell = value; }

        // constructor
        public GameObject(char character, GameObjectType type)
        {
            this.Character = character;
            this.type = type;
        }

        public GameObject(char Character) { this.Character = Character; this.type = GameObjectType.NONE; }

        public GameObject(char character, GameCell currentCell, GameObjectType type)
        {
            this.Character = character;
            this.currentCell = currentCell;
            this.type = type;
        }

        // get game object type
        public static GameObjectType getGameObjectType(string displayCharacter)
        {
            return GameObjectType.NONE;
        }
    }
}
