using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    public abstract class CardList : List<Card>
    {

        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }


        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}