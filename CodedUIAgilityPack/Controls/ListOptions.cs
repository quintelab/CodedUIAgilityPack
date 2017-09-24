namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing RadioButton items and DropDownList items
    /// </summary>
    public class ListOptions
    {
        private string _name;
        private string _value;
        private string _description;

        /// <summary>
        /// Item name (ID)
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Item Vaue
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        /// <summary>
        /// Item text
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Constructor used for RadioButtom control
        /// </summary>
        /// <param name="name">Html ID</param>
        /// <param name="value">Value</param>
        /// <param name="description">Description</param>
        public ListOptions(string name, string value, string description)
        {
            _name = name;
            _value = value;
            _description = description;
        }

        /// <summary>
        /// Constructor used for DropDownList control
        /// </summary>
        /// <param name="value"></param>
        /// <param name="description"></param>
        public ListOptions(string value, string description)
        {
            _value = value;
            _description = description;
        }
    }
}
