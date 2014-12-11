using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPlayer
    {
        private string playerID;
        private string fullName;
        private string birthday;
        private int positionID;
        private int nationalID;
        private string numberOfCloth;
        private int height;
        private int weight;

        public DTOPlayer()
        {

        }

        public DTOPlayer(string _playerID, string _fullName, string _birthday, int _position, int _nationalID, string _numberOfCloth, int _height, int _weight)
        {
            this.playerID = _playerID;
            this.fullName = _fullName;
            this.birthday = _birthday;
            this.positionID = _position;
            this.nationalID = _nationalID;
            this.numberOfCloth = _numberOfCloth;
            this.height = _height;
            this.weight = _weight;
        }

        public string PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }

        public int NationalID
        {
            get { return nationalID; }
            set { nationalID = value; }
        }

        public string NumberOfCloth
        {
            get { return numberOfCloth; }
            set { numberOfCloth = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
