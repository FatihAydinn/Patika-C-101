using System;
namespace todo 
{
    public class Board
    {
        private string titles;
        private string contents;
        private string persons;
        private string sizes;

        public string Titles 
        {
            get => titles;
            set => titles = value; 
        }
        public string Contents 
        {
            get => contents; 
            set => contents = value; 
        }
        public string Persons { get => persons; set => persons = value; }
        public string Sizes { get => sizes; set => sizes = value; }
    }
}