using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Areas.ModulStudentskaSluzba.Data
{
    // ViewModel za View Prikazi unutar foldera Student, unutar Area-a ModulStudentskaSluzba
    public class StudentPrikaziViewModel
    {
        public class StudenInfo
        {
            public Student Student { get; set; }
            public float? ECTSukupno { get; set; }
            public int? BrojPolozenihPredmeta { get; set; }
        }
        public List<StudenInfo> studenti;


        // za combobox
        public List<Smjer> smjerovi;
        public IEnumerable<SelectListItem> smjeroviStavke
        {
            get
            {
                List<SelectListItem> stavke = new List<SelectListItem>();
                stavke.Add(new SelectListItem { Value = null, Text = "Svi smjerovi"});
                stavke.AddRange(smjerovi.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Fakultet.Naziv + " " + x.Naziv }).ToList());
                return stavke;
            }
        }
        public int SmjerId { get; set; }
    }
}