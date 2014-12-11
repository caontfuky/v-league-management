using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPlayer
    {
        public string playerID;
        public string fullName;
        public string birthday;
        public int positionID;
        public int nationalID;
        public string numberOfCloth;
        public int height;
        public int weight;

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

    }
}
