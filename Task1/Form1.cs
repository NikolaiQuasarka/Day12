namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            list1 = new List<Library>();
            Library.FillLibrary(ref list1);
            Update1(list1);

            list2 = new List<HigherEducation>();
            HigherEducation.FillHigherEducation(ref list2);
            Update2(list2);
        }

        List<Library> list1;
        List<HigherEducation> list2;

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var selectedLibrarys = from lib in list1
                                   where (lib.Name.Contains(textBox_Name.Text) & textBox_Name.Text != "") | textBox_Name.Text == ""
                                   where (lib.Location.Contains(textBox_Location.Text) & textBox_Location.Text != "") | textBox_Location.Text == ""
                                   where (TimeSpan.TryParse(textBox_TimeOpen.Text, out TimeSpan start) & lib.TimeOpen == start) | textBox_TimeOpen.Text == ""
                                   where (TimeSpan.TryParse(textBox_TimeClose.Text, out TimeSpan end) & lib.TimeClose == end) | textBox_TimeClose.Text == ""
                                   where (uint.TryParse(textBox_Capacity.Text, out uint capacity) & lib.Capacity > capacity) | textBox_Capacity.Text == ""
                                   orderby lib.Capacity, lib.TimeOpen
                                   select lib;
            Update1(selectedLibrarys.ToList());
        }
        private void Update1(List<Library> list)
        {
            listView1.Items.Clear();
            foreach (var item in list)
            {
                listView1.Items.Add(item.ToString());
            }
        }
        private void Update2(List<HigherEducation> list)
        {
            listView2.Items.Clear();
            foreach (var item in list)
            {
                listView2.Items.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update1(list1);
        }

        private void button2Select_Click(object sender, EventArgs e)
        {
            var selecteEducations = from Ed in list2
                                    where (Ed.UniversityName.Contains(textBoxUName.Text) & textBoxUName.Text != "") | textBoxUName.Text == ""
                                    where (Ed.GivenToPerson.Contains(textBoxGivenTo.Text) & textBoxGivenTo.Text != "") | textBoxGivenTo.Text == ""
                                    where (DateTime.TryParse(textBoxStartDate.Text, out DateTime start) & Ed.StartDate >= start) | textBoxStartDate.Text == ""
                                    where (DateTime.TryParse(textBoxEndDate.Text, out DateTime end) & Ed.EndDate <= end) | textBoxEndDate.Text == ""
                                    where (sbyte.TryParse(textBoxMidMark.Text, out sbyte MMark) & Ed.MidMark >= MMark & MMark < 11 & MMark > 0) | textBoxMidMark.Text == ""
                                    where (Ed.Speciality.Contains(textBoxSpeciality.Text) & textBoxSpeciality.Text != "") | textBoxSpeciality.Text == ""
                                    where (Ed.Degree.Contains(textBoxDegree.Text) & textBoxDegree.Text != "") | textBoxDegree.Text == ""
                                    orderby Ed.EndDate, Ed.MidMark
                                    select Ed;
            Update2(selecteEducations.ToList());
        }

        private void button2Reset_Click(object sender, EventArgs e)
        {
            Update2(list2);
        }
    }
}
