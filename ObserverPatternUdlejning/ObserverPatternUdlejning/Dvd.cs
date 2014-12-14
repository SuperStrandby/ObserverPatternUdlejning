using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternUdlejning
{
    public class Dvd
    {
        private string _title;
        private int _barcode;
        private string _position;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        internal Dvd(string title, int barcode, string position)
        {
            _title = title;
            _barcode = barcode;
            _position = position;
        }
    }
}
