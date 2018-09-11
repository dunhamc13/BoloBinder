using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoloCreator
{
    class Settings
    {
        public bool SortNewestFirst { get; set; } = true;
        public bool PutApprehensionPhotosFirst { get; set; } = true;
        public string ApprehensionFolderName{ get; set; } = "APP";
        public string PmrFolderName { get; set; } = "PMR";
        public string KtrFolderName { get; set; } = "KTR";
        public bool IncludeApprehensions { get; set; } = true;
        public bool IncludePmrs { get; set; } = true;
        public bool IncludeKtrs { get; set; } = true;
        public bool IncludeMisc { get; set; } = true;
        public bool SortByType { get; set; } = true;



        public Settings() { }
    }

}
