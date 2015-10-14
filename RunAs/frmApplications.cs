using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAs
{
    public partial class frmApplications : Form
    {
        public List<SavedApp> Applications { get; set; }
        public frmApplications()
        {
            InitializeComponent();
            //Properties.Settings.Default["ApplicationList"] = "blah";
            //lblApplications.Text = Properties.Settings.Default["ApplicationList"].ToString();

            Applications = new List<SavedApp>();
            ShowAppList();
        }

        public void ShowAppList()
        {
            //List<Apps> apps = new List<Apps>();
            //apps.Add(new Apps(){
            //    Name = "Test App",
            //    Path = "blah"
            //});

            //lstApps.Items.Add("col 1").SubItems.AddRange(new string[] { "test", "best", "west" });

            string appListString = Properties.Settings.Default["ApplicationList"].ToString();
            List<string> apps = appListString.Split(",".ToCharArray()).ToList();
            foreach (var a in apps)
            {
                string name = a.Split("|".ToCharArray())[0];
                string path = a.Split("|".ToCharArray())[0];

                Applications.Add(new SavedApp()
                {
                    Name = name,
                    Path = path
                });
                lbxApps.Items.Add(name);
            }
        }
    }

    public class SavedApp
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
