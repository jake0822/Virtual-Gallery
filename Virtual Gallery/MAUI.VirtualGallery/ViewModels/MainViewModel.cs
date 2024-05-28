using Library.VirtualGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.VirtualGallery.ViewModels
{
    internal class MainViewModel
    {
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
