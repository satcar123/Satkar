using DataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace CourseWorkSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FileName = @"E:\myfiles\Application Development\cW\StudentCWs\StudentCWSchema.xml";

        public MainWindow()
        {
            InitializeComponent();
            Startup();
        }

        public static string FileName1 => FileName;

        public void Startup()
        {
            var handler = new Handler();
            //var dataSet = handler.CreateDataSet();
            //AddSampleData(dataSet);
            //dataSet.WriteXmlSchema(@"D:\StudentCWSchema.xml");
            //dataSet.WriteXml(@"D:\StudentCWData.xml");

            ////var dataSet = new DataSet();
            ////dataSet.ReadXmlSchema(FileName1);
            ////dataSet.ReadXml(@"D:\StudentCWData.xml");

            var i = 0;
        }

        private void AddSampleData(DataSet dataSet)
        {
            var dr = dataSet.Tables["Course"].NewRow();
            dr["Name"] = "Business Administration";
            dr["DisplayText"] = "BBA Hons";
            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Course"].NewRow();
            dr["Name"] = "Network & Communication";
            dr["DisplayText"] = "BCA Network";
            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Course"].NewRow();
            dr["Name"] = "Programming & Application Development";
            dr["DisplayText"] = "BSc CSIT Application Development";
            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Ishwor Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220845";
            dr["CourseEnroll"] = 1;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-2);
            dataSet.Tables["Student"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Samyam Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220846";
            dr["CourseEnroll"] = 2;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-1);
            dataSet.Tables["Student"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Safal Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220847";
            dr["CourseEnroll"] = 3;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-3);
            dataSet.Tables["Student"].Rows.Add(dr);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var handler = new Handler();
            var dataSet = handler.CreateDataSet();
            AddSampleData(dataSet);
            dataSet.WriteXmlSchema(@"E:\myfiles\Application Development\cW\StudentCWSchema.xml");
            dataSet.WriteXml(@"E:\myfiles\Application Development\cW\StudentCWData.xml");
        }

        public void Write_to_file()
        {
            String text = txtRegNO.Text;
            System.To.File.WriteAllText()

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
