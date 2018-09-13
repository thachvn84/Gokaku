using System;
using System.Collections.Generic;
using System.Text;

namespace Gokaku.Models
{
    public enum MenuItemType
    {
        LevelSelect,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
