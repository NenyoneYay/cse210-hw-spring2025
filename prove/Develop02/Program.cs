using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

//Include function to read a file into a Journal.


// Journal Read_File(string fileName){
//     //This code reads the file at location fileName and stores the value into a Journal.
// }
class Program
{
    static void Main(string[] args)
    {

        Journal loadedJournal = new Journal();
        loadedJournal._journalContents = new List<Entry>();
        int entryCount = 1;
        do
        {
            string filePath;
            string menuResponse;

            Console.WriteLine("Please select an option: \n1: Load journal\n2: Save journal\n3: Write new journal entry\n4: Display loaded journal\n0: Quit program");

            menuResponse = Console.ReadLine();

            if (menuResponse == "0") //Quit program
            {
                break;
            }

            else if (menuResponse == "1") //Load journal from filename
            {
                //Journal loadedJournal = new Journal();
                List<string> fileList = new List<string>();
                Console.WriteLine("Enter the name of the journal you would like to load: ");
                filePath = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filePath + ".txt");
                foreach (string line in lines)
                {
                    fileList.Add(line);
                }
                loadedJournal._journalContents.Clear();
                loadedJournal._journalName = fileList[0]; //Load the journals name


                int fileListLength = fileList.Count;
                int fileIndex = 1;
                int entryIndex;

                while (fileIndex < (fileListLength))
                {
                    entryIndex = 0;
                    while (entryIndex < 3)
                    {
                        Entry tempEntry = new Entry();
                        tempEntry._entryNumber = int.Parse(fileList[entryIndex + fileIndex]);
                        entryIndex += 1;
                        tempEntry._date = fileList[entryIndex + fileIndex];
                        entryIndex += 1;
                        tempEntry._userWriting = fileList[entryIndex + fileIndex];
                        entryIndex += 1;
                        loadedJournal._journalContents.Add(tempEntry);
                    }
                    fileIndex += 3;
                }
            }

            else if (menuResponse == "2") //Save journal to filename
            {
                if (loadedJournal._journalName == "")
                {
                    Console.WriteLine("Please give a name to this journal: ");
                    loadedJournal._journalName = Console.ReadLine();
                }
                filePath = loadedJournal._journalName;
                using (StreamWriter outputFile = new StreamWriter(filePath + ".txt"))
                {
                    outputFile.WriteLine(loadedJournal._journalName);
                    foreach (Entry itemEntry in loadedJournal._journalContents)
                    {
                        outputFile.WriteLine(itemEntry._entryNumber);
                        outputFile.WriteLine(itemEntry._date);
                        outputFile.WriteLine(itemEntry._userWriting);
                    }
                }
            }

            else if (menuResponse == "3") //Write an entry into the currently loaded journal
            {
                loadedJournal._journalContents.Add(loadedJournal._Write_Entry(entryCount));
                Thread.Sleep(500);
            }

            else if (menuResponse == "4") //Display all entries in the currently loaded journal
            {
                Console.WriteLine("Now displaying: " + loadedJournal._journalName);
                foreach (Entry entriesToDisplay in loadedJournal._journalContents)
                {
                    entriesToDisplay._display();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine("Invalid choice. ");
                Thread.Sleep(500);
            }

        } while (true);
    }
}