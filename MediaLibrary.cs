using System;

namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {
        private MediaType[] _items;
        
        public int NumberOfItems => _items.Length;
        
        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }
        public MediaType FindItem(string criteria) 
        {
                MediaType itemToReturn = null;

                foreach (var item in _items) 
                {

                        if (item.Title.ToLower().Contains(criteria.ToLower())) 
                        {
                            itemToReturn = item;
                            break;
                        }

                }
                return itemToReturn;

        }
        public void DisplayItems() 
        {
                for (int index = 0; index < _items.Length; index++) 
                {
                    DisplayItem(_items[index]);
                }

        }
      public static void DisplayItem(MediaType item) 
        {
            if (item == null)
            {
                return;
            }
            
            if (item is Album)
            {
                Console.WriteLine(((Album)item).DisplayText);
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).DisplayText);
            }
            else if (item is Movie)
            {
                Console.WriteLine(((Movie)item).DisplayText);
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
        
        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];                
            }
            else
            {
                Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                
                return null;
            }
        }
    }
}