using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SunumLayer
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            _personelServices= KernelFactory.GetService<IPersonelServices>();
        }

       private IPersonelServices _personelServices;
       private IUrunServices _urunServices;

        private class KernelFactory
        {
        }
    }

    internal interface IPersonelServices
    {
    }
    internal interface IUrunServices
    {
    }
}
