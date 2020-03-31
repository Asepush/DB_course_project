using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Worker
    {
        private int id;
        private string name;
        private string surname;
        private string patronomyc;
        private int passNo;
        private int passSer;
        private string address;
        private bool criminalRec;
        private int id_post;
        private int id_pub;
        private string username;
        private string password;

        public Worker(int id, string name, string surname, string patronomyc, int passNo, int passSer, string address, bool criminalRec, int id_post, int id_pub, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.patronomyc = patronomyc;
            this.passNo = passNo;
            this.passSer = passSer;
            this.address = address;
            this.criminalRec = criminalRec;
            this.id_post = id_post;
            this.id_pub = id_pub;
            this.username = username;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronomyc { get => patronomyc; set => patronomyc = value; }
        public int PassNo { get => passNo; set => passNo = value; }
        public int PassSer { get => passSer; set => passSer = value; }
        public string Address { get => address; set => address = value; }
        public bool CriminalRec { get => criminalRec; set => criminalRec = value; }
        public int Id_post { get => id_post; set => id_post = value; }
        public int Id_pub { get => id_pub; set => id_pub = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Worker worker &&
                   id == worker.id &&
                   name == worker.name &&
                   surname == worker.surname &&
                   patronomyc == worker.patronomyc &&
                   passNo == worker.passNo &&
                   passSer == worker.passSer &&
                   address == worker.address &&
                   criminalRec == worker.criminalRec &&
                   id_post == worker.id_post &&
                   id_pub == worker.id_pub &&
                   username == worker.username &&
                   password == worker.password;
        }
    }
}
