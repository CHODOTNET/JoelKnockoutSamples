using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutSamples.ViewModels
{
    public class PeopleViewModel
    {
        public string Category { get; set; }
        public List<PersonViewModel> People { get; set; }
    }
}