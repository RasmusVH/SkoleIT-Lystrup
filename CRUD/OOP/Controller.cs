using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.OOP

{
   class Controller
    {
        PCListe MinListe = new PCListe();
        static long LastIDNum = 0;


        public void create(string brand, string model)
        {
            MinListe.create(brand, model, ++LastIDNum);


        }
       public Computer Read(long ID)
        {
            return MinListe.Read(ID);

        }




        public void Delete(long ID)
        {
            MinListe.remove(ID);


        }

        public void update(long ID, string Brand, string model)
        {
            Computer PCToUpdate = MinListe.Read(ID);
            if (PCToUpdate != null)
            {
                PCToUpdate.Brand = Brand;
                PCToUpdate.Model = model;
            }
        }
        public List<Computer> getAll()
        {
            return MinListe.getAll();
        }

    }
}
