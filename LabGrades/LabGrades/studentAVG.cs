using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SW = System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace LabGrades
{
    public class studentAVG
    {
        Double gradeOne, gradeTwo, gradeThree, gradeFour, gradeFive;
        Double result;
        int num;
        int i;
        
        
        List<string> grades = new List<string>();

       
        string[] names =  new string[5];
        double[] finalGrade = new double[5];
        string[] letter = new string[5];
        

        public void Main(string[] studentName, double[] grad, int studentNum)
        {
            

            num = studentNum;
            names = studentName;
            finalGrade = grad;


            StudentData();
           
        
        
        }


       


        private void StudentData()
        {
            

           
               
                if (finalGrade[num] >= 90)
                {

                    letter[num] = "A";
                
                }
                else if (finalGrade[num] >= 80 && finalGrade[num] <= 89)
                {

                    letter[num] = "B";
                
                }

                else if (finalGrade[num] >= 70 && finalGrade[num] <= 79)
                {
                
                    letter[num] = "C";
                
                }
                else if (finalGrade[num] >= 65 && finalGrade[num] <= 69)
                {

                    letter[num] = "D";


                }
                else
                {

                    letter[num] = "F";
                }

                if (num == 6)
                {
                    SW.MessageBox.Show("Final Grade for " + names[1] + " is " + letter[1] + "\n" + "Final Grade for " + names[2] + " is " + letter[2] + "\n" + "Final Grade for " + names[3] + " is " + letter[3] + "\n" + "Final Grade for " + names[4] + " is " + letter[4] + "\n" + "Final Grade for " + names[5] + " is " + letter[5]);
                }
        }


    }
}


 //SW.MessageBox.Show("Final Grade for " + names[1] + " is " + finalGrade[1] + "\n" + "Final Grade for " + names[2] + " is " + finalGrade[2] + "\n" + "Final Grade for " + names[3] + " is " + finalGrade[3] + "\n" + "Final Grade for " + names[4] + " is " + finalGrade[4] + "\n" + "Final Grade for " + names[5] + " is " + finalGrade[5]);