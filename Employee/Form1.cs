using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable ConvertToDataTable(string filePath)
        {
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("EmpID");
            dt.Columns.Add("ProjectID");
            dt.Columns.Add("DateFrom");
            dt.Columns.Add("DateTo");
            dt.Columns.Add("TotalDays");
    


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split(',');

                DataRow _ravi = dt.NewRow();
                for (int cIndex = 0; cIndex < 4; cIndex++)
                {
                    if(cols[3].ToString()=="NULL" )
                    {  DateTime date = DateTime.Now;
                        cols[3]=date.ToString("yyyy-MM-dd");
                    }

                    _ravi[cIndex] = cols[cIndex];

                    if (cIndex==3)
                    {
                        DateTime d1 = Convert.ToDateTime(cols[3].ToString());
                        DateTime d2 = Convert.ToDateTime(cols[2].ToString());
                        
                        _ravi[4] =(d1 - d2).Days; 
                    }
                }

                dt.Rows.Add(_ravi);
            }

            return dt;
        }
        //create list of data
        public class Project
        {
            public int EmpID { get; set; }
            public int ProjectID { get; set; }
            public int TotalDays { get; set; }
        }
        public class Pairofemployees
        {
            public int EmpID1 { get; set; }
            public int EmpID2 { get; set; }
            public int ProjectID { get; set; }
            public int Daysworked { get; set; }
        }

        // Create Data Table
        DataTable dt = new DataTable();
        /// <summary>
        ///  Grid layout
        /// </summary>
        public void Gridyout()
        {
            EmployeeGrid.Columns["EmpID1"].HeaderText = " Employee ID #1";
            EmployeeGrid.Columns["EmpID2"].HeaderText = " Employee ID #2";
            EmployeeGrid.Columns["ProjectID"].HeaderText = "Project ID";
            EmployeeGrid.Columns["Daysworked"].HeaderText = " Days worked";
        }
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TxtFileName.Text = theDialog.FileName;
                    if ((myStream = theDialog.OpenFile()) != null)
                    {

                        DataTable Rdt= ConvertToDataTable(theDialog.FileName);


                            List<Project> ProjecttList = new List<Project>();
                            List<Pairofemployees> PairofemployeesList = new List<Pairofemployees>();
                            for (int i = 0; i < Rdt.Rows.Count; i++)
                            {
                                Project project = new Project();
                                project.EmpID  = Convert.ToInt32(Rdt.Rows[i]["EmpID"]);
                                project.ProjectID  =int.Parse(Rdt.Rows[i]["ProjectID"].ToString());
                                project.TotalDays = int.Parse(Rdt.Rows[i]["TotalDays"].ToString());

                                ProjecttList.Add(project);
                            }
                            foreach (IGrouping<int, Project> project in ProjecttList.GroupBy(x => x.ProjectID).ToList())
                            {
                                List<Project> projectGroup = project.Take(2).ToList();
                                if (projectGroup.Count == 2)
                                {
                                    Pairofemployees pairofemployees = new Pairofemployees();
                                    {

                                      
                                        pairofemployees.EmpID1 = projectGroup[0].EmpID;
                                        pairofemployees.EmpID2 = projectGroup[1].EmpID;
                                        pairofemployees.ProjectID = projectGroup[0].ProjectID;
                                        pairofemployees.Daysworked = projectGroup.Min(x => x.TotalDays);

                                    };
                                    PairofemployeesList.Add(pairofemployees);
                                }
                            }

                            
                            List<Pairofemployees> Toplist = new List<Pairofemployees>();
                            Toplist = PairofemployeesList.OrderByDescending(x => x.Daysworked).ToList();

                            var source = new BindingSource();
                            source.DataSource = Toplist.First();
                            EmployeeGrid.DataSource = source;
                            EmployeeGrid.Refresh();
                            Gridyout();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
