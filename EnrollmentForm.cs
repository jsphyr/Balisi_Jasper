using System;
using System.ComponentModel.Design;
using System.Numerics;

class EnrollmentForm
{
    static void Main(string[] args)
    {   //array for courses 
        string[] course = {"BS in Computer Science",
                           "BS in Information Technology",
                           "BS in Business Administration",
                           "BS in Accountancy",
                           "BS in Architecture"};

        //array for courses' tuition
        int[] modePayment = {33249,32099,34129,35099,36299};

        //prompt to begin or end the enrollment form
        Console.WriteLine("Do you want to enroll in STI Dasmarinas?\n-------------------------------------------------------------\n" +
            "Press [1] to Proceed\nPress [2] to Cancel\n-------------------------------------------------------------");
        Console.Write("Enter your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());
        
        //if the user wants to enroll
        if (choice == 1)
        {
            Console.Clear();

            Console.Write("First Name: ");
            string fName = Convert.ToString(Console.ReadLine());

            Console.Write("Middle Initial: ");
            string mName = Convert.ToString(Console.ReadLine());

            Console.Write("Last Name: ");
            string lName = Convert.ToString(Console.ReadLine());
            Console.Clear();

            //minimum tuition fee requirement
            Console.WriteLine("The range of tuition fee per sem is 32099-36299");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Is the amount within your price range?\nPress [1] to continue\nPress [2] to cancel");
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.Write("Enter your choice: ");
            int payment = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //if the payment condition is true
            if (payment == 1) {
                Console.WriteLine("Welcome " + fName + " " + mName + ". " + lName + "!");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Choose your preferred course below!");
                Console.WriteLine("-------------------------------------------------------------");

                //prints courses
                for (int i = 0; i < course.Length; i++)
                {
                    Console.WriteLine($"Course {i + 1}: {course[i]}");
                }

                //user's input of preffered course
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Enter your course of choice: ");
                int cChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //prompt for document requirements
                Console.WriteLine("Submit the following requirements below: (fileName(docType)");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("1. Good_Moral (pdf)\n2. Form_137 (pdf)\n3. PSA (pdf)\n4. SHS_Diploma (pdf)");
                Console.WriteLine("-------------------------------------------------------------");
                Console.Clear();

                //folder location of the required documents from user input
                Console.Write("Enter folder directory of the requirements: ");
                string path = Convert.ToString(Console.ReadLine());
                string directorPath = (@path);
                Console.Clear();

                //countdown for checking
                for (int timer = 3; timer >= 0; timer--)
                {
                    Console.WriteLine("Checking for requirements...in {0}", timer);
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }

                //documents needed
                string[] filesToCheck =
                {
                "Good_Moral.txt",
                "Form_138.txt",
                "PSA.txt",
                "SHS_Diploma.txt",
                };

                //variable for file checking
                bool ifValid = true;

                foreach (string fileName in filesToCheck)
                {
                    string filePath = Path.Combine(directorPath, fileName);
                    if (File.Exists(filePath))
                    {
                        
                        Console.WriteLine($"File {fileName} exist!");
                        
                    }
                    else
                    {
                        //if there aren't any documents found
                        Console.WriteLine($"File {fileName} does not exist!");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Please submit the required files.");
                        ifValid = false;
                        break;
                    }
                }

                //while the file exists
                while (ifValid)
                {   

                    //if documents are found
                    int currentYear = DateTime.Now.Year;
                    int nextYear = currentYear + 1;
                    switch (cChoice)//i used "ifValid=false" to prevent an infinite loop
                    {
                        case 1:

                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Press [1] for installment basis\nPress [2] for cash basis");
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Enter your choice: ");

                            int modeChoice = Convert.ToInt32(Console.ReadLine());
                            if (modeChoice == 1) 
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                int installmentPay = modePayment[0] / 10;
                                Console.Clear();
                                Console.WriteLine("Your monthly due for the S.Y. is " + installmentPay);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[0] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            else
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.Clear();
                                int wholePayment = modePayment[0] * 2;
                                Console.WriteLine("Your whole due for the the S.Y. " + currentYear + "-" + nextYear + " is " + wholePayment);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[0] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            ifValid = false; 
                            break;

                        case 2:
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Press [1] for installment basis\nPress [2] for cash basis");
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Enter your choice: ");

                            int modeChoice1 = Convert.ToInt32(Console.ReadLine());
                            if (modeChoice1 == 1)
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                int installmentPay = modePayment[1] / 10;
                                Console.Clear();
                                Console.WriteLine("Your monthly due for the S.Y. is " + installmentPay);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[1] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            else
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                
                                Console.Clear();
                                int wholePayment = modePayment[1] * 2;
                                Console.WriteLine("Your whole due for the the S.Y. " + currentYear + "-" + nextYear + " is " + wholePayment);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[1] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            ifValid = false; 
                            break;

                        case 3:
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Press [1] for installment basis\nPress [2] for cash basis");
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Enter your choice: ");
                        
                            int modeChoice2 = Convert.ToInt32(Console.ReadLine());
                            if (modeChoice2 == 1)
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                int installmentPay = modePayment[2] / 10;
                                Console.Clear();
                                Console.WriteLine("Your monthly due for the S.Y. is " + installmentPay);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[2] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            else
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.Clear();
                                int wholePayment = modePayment[2] * 2;
                                Console.WriteLine("Your whole due for the the S.Y. " + currentYear + "-" + nextYear + " is " + wholePayment);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[2] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            ifValid = false; 
                            break;

                        case 4:
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Press [1] for installment basis\nPress [2] for cash basis");
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Enter your choice: ");
                         
                            int modeChoice3 = Convert.ToInt32(Console.ReadLine());
                            if (modeChoice3 == 1)
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                int installmentPay = modePayment[3] / 10;
                                Console.Clear();
                                Console.WriteLine("Your monthly due for the S.Y. is " + installmentPay);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[3] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            else
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.Clear();
                                int wholePayment = modePayment[3] * 2;
                                Console.WriteLine("Your whole due for the the S.Y. " + currentYear + "-" + nextYear + " is " + wholePayment);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[3] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            ifValid = false; 
                            break;

                        case 5:
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Press [1] for installment basis\nPress [2] for cash basis");
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.Write("Enter your choice: ");

                            int modeChoice4 = Convert.ToInt32(Console.ReadLine());
                            if (modeChoice4 == 1)
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.Clear();
                                int installmentPay = modePayment[4] / 10;
                                Console.WriteLine("Your monthly due for the S.Y. is " + installmentPay);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[4] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            else
                            {
                                Console.Clear();
                                for (int timer = 3; timer >= 0; timer--)
                                {
                                    Console.WriteLine("Please wait...in {0}", timer);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.Clear();
                                int wholePayment = modePayment[4] * 2;
                                Console.WriteLine("Your whole due for the the S.Y. " + currentYear + "-" + nextYear + " is " + wholePayment);
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("You are enrolled for " + course[4] + " in S.Y. " + currentYear + "-" + nextYear);
                            }
                            ifValid = false; 
                            break;
                    }
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Thank you for choosing STI Dasmarinas!");
                }
            }
            else
            {   
                //if the payments are less than 32000
                Console.WriteLine("Your payment is insufficient...");
            }
        }

        else
        {
            //if the user decides to cancel the enrollment form
            Console.Clear();
            Console.WriteLine("Thank you for your respose!");
        }
    }
} 