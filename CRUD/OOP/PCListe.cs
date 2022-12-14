using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CRUD.OOP
{
    // Klasse B
    class PCListe

    {
        List<Computer> computers = new List<Computer>();

        public void create(string Brand, string model, long ID)
        {
            Computer PCToCreate = new Computer();

            PCToCreate.Brand = Brand;
            PCToCreate.Model = model;
            PCToCreate.ID = ID;
            computers.Add(PCToCreate);
        }

        

        public Computer Read(long ID)
        {
            Computer ComputerMedID = null;

            foreach (Computer c in computers)
            {
                if (ID == c.ID)
                    ComputerMedID = c;


            }
            return ComputerMedID;
        }


        public void remove(long ID)
        {
            Computer PCToDelete = null;

            foreach (Computer c in computers)
            {
                if (ID == c.ID)
                    PCToDelete = c;
            }

            if (PCToDelete != null)
                computers.Remove(PCToDelete);
        }
        public List<Computer> getAll()
        {
            return computers;
        }







    }

}
