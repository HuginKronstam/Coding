using School.Data;
using System;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {

        private Student _student;
        public Student Student {
            get
            {
                if( _student == null )
                {
                    _student = new Student();
                }
                _student.FirstName = firstName.Text;
                _student.LastName = lastName.Text;
                _student.DateOfBirth = DateTime.Parse(dateOfBirth.Text);


                return _student;
            }
        set {
                firstName.Text = value.FirstName;
                lastName.Text = value.LastName;
                dateOfBirth.Text = value.DateOfBirth.ToString("d");

                _student = value;
            }
        }
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        #endregion
    }
}
