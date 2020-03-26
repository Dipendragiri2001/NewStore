using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewStore.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<GadgetViewModel> Gadgets { get; set; }

    }
}