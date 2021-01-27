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

namespace Coding_Challenge
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      string word = "";
      string[] words = new string[200];
      char[] separator = {' ','\n'};

      DataTable wordTable = new DataTable();

      string previousWord;
      string nextWord;
      string currentWord;
      double numWordOccuranceInFile;
      double numWordsInFile;
      int lineNumber;
      

      // Adds a range to the data table and disbales the enter button until a
      // file is read in.
      private void Form1_Load(object sender, EventArgs e)
      {
         wordTable.Columns.AddRange(new DataColumn[4] { new DataColumn("Word Before", typeof(String)),
                                                        new DataColumn("Word ", typeof(String)),
                                                        new DataColumn("Word After", typeof(String)),
                                                        new DataColumn("Line Number", typeof(String))});

         btnEnter.Enabled = false;
      }

      // Uses a file dialog to read in words from a .txt file. Reads in all words into 
      // a string and splits the string into an array.
      private async void btnRead_Click(object sender, EventArgs e)
      {
         using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Text Files |*.txt", ValidateNames = true, Multiselect = false })
         {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
               {
                  word = await sr.ReadToEndAsync();
                  words = word.Split(separator, 200, StringSplitOptions.RemoveEmptyEntries);
               }     
            }
         }
         btnEnter.Enabled = true;
      }

      // Calls the program to search the array for the selected word then adds the data 
      // source to the gridview and calculates the word totals and percentage.
      private void button1_Click(object sender, EventArgs e)
      {
         searchForSelectedWord(textBox1.Text);

         this.dataGridView1.DataSource = wordTable;

         txtNumTimesWordIsUsed.Text = numWordOccuranceInFile.ToString();
         txtNumWordsInFIle.Text = numWordsInFile.ToString();

         double percentage = (numWordOccuranceInFile / numWordsInFile) * 100;
         string formattedPercentage = percentage.ToString("0.00");
         percentageWordSelected.Text = formattedPercentage.ToString() + "%";

        }


      // Searches the array of of all words in the file and returns the selected word 
      // as well as the previous and next word and increments the line acount after
      // each carrige return.
      void searchForSelectedWord(String selectedWord)
      {
         previousWord = "";
         nextWord = "";
         currentWord = "";

         numWordOccuranceInFile = 0;
         numWordsInFile = words.Length;
         lineNumber = 1;

         for (int i = 0; i < words.Length; i++)
         {
            currentWord = words[i];

            currentWord = currentWord.TrimEnd('\r');
            currentWord = currentWord.TrimEnd('.');

            if (currentWord.Equals(selectedWord))
            {
               numWordOccuranceInFile++;

               int previousIndex = i - 1;
               int nextIndex = i + 1;

               if (previousIndex < 0)
               {
                  previousWord = "NA";
               }
               else
               {
                  previousWord = words[previousIndex];
               }

               if (nextIndex >= words.Length)
               {
                  nextWord = "NA";
               }
               else
               {
                  nextWord = words[nextIndex];

                  if (nextWord.Contains("."))
                  {
                     nextWord = nextWord.TrimEnd('\r');
                     nextWord = nextWord.TrimEnd('.');
                  }
               }

               if (previousWord.Contains("."))
               {
                  previousWord = "NA";
               }

               if (words[i].Contains("."))
               {
                  nextWord = "NA";
               }

               wordTable.Rows.Add(previousWord, selectedWord, nextWord, lineNumber);
            }

            if (words[i].Contains("\r"))
            {
               lineNumber++;
            }
         }
      }

      // Exits the program
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

   }
}
