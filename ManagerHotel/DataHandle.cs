using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Metadata.Edm;
using System.Windows.Forms;

namespace ManagerHotel
{
    class DataHandle
    {
        public HotelManagerEntities db;
        public static string ERR_DATA_MISSED = "Data missed";
        public static string ERR_DATA_EXISTED = "Data existes";
        public static string SUCESS = "Success";
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
        public string AddTenantByObject(Client obj)
        {
            if (obj==null)
            {
                return ERR_DATA_MISSED;
            }
            if (obj.PersonID==null || obj.PersonID=="")
            {
                return ERR_DATA_MISSED;
            }
            if (db.Clients.AsEnumerable().Where(x => x.PersonID == obj.PersonID).Count() == 0)
            {
                db.Clients.Add(obj);
                db.SaveChanges();
                return SUCESS;
            }
            else
            {
                return ERR_DATA_EXISTED;
            }
        }
        public Client GetTenantById(string id)
        {
            Client c = db.Clients.Where(x => x.PersonID == id).FirstOrDefault();
            return c;
        }
        public bool EditTenantById(string id, Client newData)
        {
            Client c = db.Clients.Where(x => x.PersonID == id).FirstOrDefault();
            if (c==null)
            {
                return false;
            }
            c.LastName = newData.LastName;
            c.FirstName = newData.FirstName;
            c.Address = newData.Address;
            c.Phone = newData.Phone;
            c.RoomID = newData.RoomID;
            db.SaveChanges();
            return true;
        }
        public bool isTenantExisted(string id)
        {
            if (GetTenantById(id)==null)
            {
                return false;
            }
            return true;
        }
        public bool RemoveTenantById(string id)
        {
            Client c = GetTenantById(id);
            if (c != null)
            {
                List<Contract> lstContract = c.Contracts.ToList();
                if (lstContract!=null)
                {
                    int i = 0;
                    int n=lstContract.Count;
                    for (i=0;i<n;i++)
                    {
                        db.Contracts.Remove(lstContract.ElementAt(i));
                    }
                }
                db.Clients.Remove(c);
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
        public Room getRoom(int id)
        {
            Room r = db.Rooms.AsEnumerable().Where(x => x.RoomID == id).FirstOrDefault();
            return r;
        }
        public bool IsRoomExist(int id)
        {
            if (getRoom(id)==null)
            {
                return false;
            }
            return true;
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
