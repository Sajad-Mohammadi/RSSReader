using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DAL
{
    public class DALValidator
    {
        public static bool IsFileExisting(string filePath)
        {
            bool isExisting = File.Exists(filePath);
            if (isExisting)
            {
                MessageBox.Show("Hittar inte filen!");
            }
            return isExisting;
        }
    }
}
