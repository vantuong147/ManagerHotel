using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerHotel
{
    class DataHandle
    {
        HotelManagerEntities db;
        public DataHandle()
        {
            db = new HotelManagerEntities();
        }
        /* ----------------------------------------------Clients function------------------------------------------------------- */
        public List<Client> GetAllClients()
        {
            List<Client> lstClient = db.Clients.ToList();
            if (lstClient == null)
            {
                lstClient = new List<Client>();
            }
            return lstClient;
        }
        public bool AddTenantByObject(Client obj)
        {
            if (obj==null)
            {
                return false;
            }
            if (obj.PersonID==null || obj.PersonID=="")
            {
                return false;
            }
            if (db.Clients.AsEnumerable().Where(x => x.PersonID == obj.PersonID).Count() == 0)
            {
                db.Clients.Add(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        /*
        public bool AddTenantByDataset(string personId, string lastName, string firstName, string address, string phone, string pictureHouseholdReg, string pictureIDCard, int roomId)
        {
            Client c = new Client();
            c.PersonID = personId;
            c.LastName = lastName;
            c.FirstName = firstName;
            c.Address = address;
            c.Phone = phone;
            c.PictureOfHouseholdRegistry = pictureHouseholdReg;
            c.PictureOfIDCard = pictureIDCard;
            c.RoomID = roomId;
            return AddTenantByObject(c);
        }
        */
        /* ----------------------------------------------Rooms function------------------------------------------------------- */
        public List<Room> GetAllRooms()
        {
            List<Room> lstRoom = db.Rooms.ToList();
            if (lstRoom == null)
            {
                lstRoom = new List<Room>();
            }
            return lstRoom;
        }
        /*----------------------------------------------Contract function----------------------------------------*/
        public bool AddContractByObj(Contract obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.PersonID=="")
            {
                return false;
            }
            db.Contracts.Add(obj);
            db.SaveChanges();
            return true;
        }
    }
}
