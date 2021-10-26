using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_social_media
{
    public class EL
    {
        int id;
        string firstname, lastname,emailorphone,password;
        DateTime dob;
        byte isactive;
        public int ID
        {
            get
            {
                return id;
            }            
        }
        public string FIRSTNAME
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LASTNAME
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string EMAILORPHONE
        {
            get
            {
                return emailorphone;
            }
            set
            {
                emailorphone = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public byte ACTIVE
        {
            get
            {
                return isactive;
            }
            set
            {
                isactive = value;
            }
        }
    }
}