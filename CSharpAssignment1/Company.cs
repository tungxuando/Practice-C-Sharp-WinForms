using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssignment1
{
    internal class Company
    {
        private List<Taxi> taxiList;
        private List<Journey> journeyList;
        public Company()
        {
            this.taxiList = new List<Taxi>();
            this.journeyList = new List<Journey>();
            readTaxiFile();
            readJourneyFile();
        }

        public List<Taxi> TaxiList
        {
            get
            {
                return this.taxiList;
            }
            set
            {
                this.TaxiList = value;
                writeToTaxiFile();
            }
        }

        public List<Journey> JourneyList
        {
            get
            {
                return this.journeyList;
            }
            set
            {
                this.journeyList = value;
            }
        }

        public void addTaxi(Taxi taxi)
        {
            if (!taxiIdExist(taxi.TaxiId))
            {
                this.taxiList.Add(taxi);
                writeToTaxiFile();
                MessageBox.Show("Taxi id:" + taxi.TaxiId + " has been added");
            }
            else
            {
                throw new Exception("Id existed!");
            }
        }

        public void removeTaxi(Taxi taxi)
        {
            this.taxiList.Remove(taxi);
        }

        public void addJourney(Journey journey)
        {
            if (taxiIdExist(journey.Taxi.TaxiId))
            {
                this.journeyList.Add(journey);
                writeToJourneyFile();
            }
            else
            {
                throw new Exception("Taxi is not added. Please add before continue.");
            }

        }

        public void removeJourney(Journey journey)
        {
            this.journeyList.Remove(journey);
        }

        private bool taxiIdExist(decimal taxiId)
        {
            foreach (Taxi taxi in this.taxiList)
            {
                if (taxi.TaxiId == taxiId)
                {
                    return true;
                }
            }
            return false;
        }

        private void writeToTaxiFile()
        {
            using (StreamWriter sw = new StreamWriter("taxis.txt"))
            {
                foreach (Taxi taxi in this.taxiList)
                {
                    sw.WriteLine(taxi.TaxiId);
                }
            }
        }



        private void readTaxiFile()
        {
            string path = "taxis.txt";
            // Checking if the file exits
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (StreamReader sr = new StreamReader(path))
            {
                // while loop will exit when end of the file is reached
                while (!sr.EndOfStream)
                {
                    // Reading each line
                    string line = sr.ReadLine();

                    decimal taxiId = decimal.Parse(line.Split('|')[0]);


                    // Creating object with the info from the file
                    Taxi taxi = new Taxi(taxiId);
                    // Adding the new object (taxi) to the taxi list
                    this.taxiList.Add(taxi);
                }
            }
        }

        private void writeToJourneyFile()
        {
            using (StreamWriter sw = new StreamWriter("journeys.txt"))
            {
                foreach (Journey journey in this.journeyList)
                {
                    sw.WriteLine(journey.Taxi.TaxiId + "|" + journey.StartTime.Hour + ':' + journey.StartTime.Minute + "|" + journey.EndTime.Hour + ':' + journey.EndTime.Minute + "|" + journey.DayOfWeek + "|" + journey.Distance);
                }
            }
        }

        private void readJourneyFile()
        {
            string path = "journeys.txt";
            // Checking if the file exits
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (StreamReader sr = new StreamReader(path))
            {
                // while loop will exit when end of the file is reached
                while (!sr.EndOfStream)
                {
                    // Reading each line
                    string line = sr.ReadLine();

                    decimal taxiId = decimal.Parse(line.Split('|')[0]);
                    DateTime starTime = DateTime.Parse(line.Split('|')[1]);
                    DateTime endTime = DateTime.Parse(line.Split('|')[2]);
                    DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), line.Split('|')[3]);
                    decimal distance = decimal.Parse(line.Split('|')[4]);

                    Taxi taxi = new Taxi(taxiId);
                    // Creating object with the info from the file
                    Journey journey = new Journey(taxi, starTime, endTime, dayOfWeek, distance);

                    // Adding the new object (journey) to the taxi list
                    this.journeyList.Add(journey);
                }
            }
        }
    }
}
