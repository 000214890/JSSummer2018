using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabGrades
{
    public partial class frmLab : Form
    {
        //variables
        
        String  name,grade1,grade2, grade3, grade4,grade5;

        int count = 0;

        double gradeOne, gradeTwo, gradeThree, gradeFour, gradeFive;
        double result, labResult;
       
        // arrray  variables
        string[] studentName = new string[5];
        double[] finalGrade = new double[5];
        double[] AvgFinalGarde = new double[5];
        double[] aveGradeOne = new double[5];
        
        double[] aveGradeTwo = new double[5];
        double[] aveGradeThree = new double[5];
        double[] aveGradeFour = new double[5];
        double[] aveGradeFive = new double[5];
        double[] aveResult = new double[5];


       

        public frmLab()
        {
            InitializeComponent();
        }

        private void frmLab_Load(object sender, EventArgs e)
        {
                 this.Size = new Size(297, 410);
                 button2.Enabled = false;
                 btnIndividual.Text = " Student One";
               
        }


        #region Controls

        //button handles student labs
        private void btnIndividual_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                if (count == 0)
                {

                    btnIndividual.Text = "Student Two";


                }
                else if (count == 1)
                {



                    btnIndividual.Text = "Student Three";


                }
                else if (count == 2)
                {
                    btnIndividual.Text = "Student four";




                }
                else if (count == 3)
                {
                    btnIndividual.Text = "Student five";


                }

                name = txtbxStudent.Text;
                studentName[count] = name;


                grade1 = txtbxGOne.Text;
                grade2 = txtbxGTwo.Text;
                grade3 = txtbxGThree.Text;
                grade4 = txtbxGFour.Text;
                grade5 = txtbxGFive.Text;



                calculations();
                count++;
            }
            this.Size = new Size(642, 383);
            button2.Enabled = true;
        }

        //closes form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //button handles lab avg
        private void button2_Click_1(object sender, EventArgs e)
        {
            labResult = ((aveGradeOne[0] + aveGradeOne[1] + aveGradeOne[2] + aveGradeOne[3] + aveGradeOne[4]) / 5);
            lblLabOne.Text = "LAB ONE: " + "Aveareg for Lab One is " + labResult;

            labResult = ((aveGradeTwo[0] + aveGradeTwo[1] + aveGradeTwo[2] + aveGradeTwo[3] + aveGradeTwo[4]) / 5);
            lblLabTwo.Text = "LAB TWO: " + "Aveareg for Lab Two is " + labResult;

            labResult = ((aveGradeThree[0] + aveGradeThree[1] + aveGradeThree[2] + aveGradeThree[3] + aveGradeThree[4]) / 5);
            lblLabThree.Text = "LAB THREE: " + "Aveareg for Lab Three is " + labResult;


            labResult = ((aveGradeFour[0] + aveGradeFour[1] + aveGradeFour[2] + aveGradeFour[3] + aveGradeFour[4]) / 5);
            lblLabFour.Text = "LAB FOUR: " + "Aveareg for Lab Four is " + labResult;


            labResult = ((aveGradeFive[0] + aveGradeFive[1] + aveGradeFive[2] + aveGradeFive[3] + aveGradeFive[4]) / 5);
            lblLabFive.Text = "LAB FIVE: " + "Aveareg for Lab Five is " + labResult;

            button1.Enabled = false;
            button2.Enabled = false;
        }
      
        #endregion

        #region FUNCTIONS

        //cals each students lab grade
        private void calculations()
        {

            gradeOne = Convert.ToDouble(grade1);
            aveGradeOne[count] = gradeOne;

            gradeTwo = Convert.ToDouble(grade2);
            aveGradeTwo[count] = gradeTwo;

            gradeThree = Convert.ToDouble(grade3);
            aveGradeThree[count] = gradeThree;

            gradeFour = Convert.ToDouble(grade4);
            aveGradeFour[count] = gradeFour;

            gradeFive = Convert.ToDouble(grade5);
            aveGradeFive[count] = gradeFive;

            result = ((gradeOne + gradeTwo + gradeThree + gradeFour + gradeFive) / 5);
            finalGrade[count] = result;

            //print to form once condition is met
            if (count == 4)
            {
                lblstudentone.Text = "STUDENT ONE: " + "Student avg for " + Convert.ToString(studentName[0]) + " is " + finalGrade[0];
                lblStudentTwo.Text = "STUDENT TWO: " + "Student avg for " + Convert.ToString(studentName[1]) + " is " + finalGrade[1];
                lblStudentThree.Text = "STUDENT THREE: " + "Student avg for " + Convert.ToString(studentName[2]) + " is " + finalGrade[2];
                lblStudentFour.Text = "STUDENT FOUR: " + "Student avg for " + Convert.ToString(studentName[3]) + " is " + finalGrade[3];
                lblStudentFive.Text = "STUDENT FIVE: " + "Student avg for " + Convert.ToString(studentName[4]) + " is " + finalGrade[4];
                
              
                }


        }

        #endregion

        #region VALIDATION

        private bool ValidateForm()
        {
            if (String.IsNullOrEmpty(txtbxGOne.Text))
            {

                MessageBox.Show("You must enter a grade", "Validation Error", MessageBoxButtons.OK);
                txtbxGOne.Focus();
                return false;
            }


            if(String.IsNullOrEmpty(txtbxGTwo.Text))
            {
                MessageBox.Show("You must enter a grade", "Validation Error", MessageBoxButtons.OK);
                txtbxGOne.Focus();
                return false;
            
            }


            if(String.IsNullOrEmpty(txtbxGThree.Text))
            {
                MessageBox.Show("You must enter a grade", "Validation Error", MessageBoxButtons.OK);
                txtbxGOne.Focus();
                return false;
            
            }

            if (String.IsNullOrEmpty(txtbxGFive.Text))
            {

                MessageBox.Show("You must enter a grade", "Validation Error", MessageBoxButtons.OK);
                txtbxGFive.Focus();
                return false;
            
            }

            if (String.IsNullOrEmpty(txtbxStudent.Text))
            {

                MessageBox.Show("You must enter a student name", "Validation Error", MessageBoxButtons.OK);
                txtbxStudent.Focus();
                return false;
            
            }

            return true;
        }


        #endregion



    }
}
